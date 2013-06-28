using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Web_Directory_Scanner
{
    public partial class ScanPage : UserControl
    {
        private class DirectoryState
        {
            public Image Image { get; set; }
            public HttpStatusCode StatusCode { get; set; }
            public string URL { get; set; }
            public DateTime Timestamp { get; set; }

            public DirectoryState(HttpStatusCode statusCode, string URL)
            {
                Image = (statusCode == HttpStatusCode.OK) ? Properties.Resources.folder : Properties.Resources.NotFound;
                StatusCode = statusCode;
                this.URL = URL;
                this.Timestamp = DateTime.Now;
            }

        }

        private BindingList<DirectoryState> directories;

        public ScanPage()
        {
            InitializeComponent();

            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;

            directories = new BindingList<DirectoryState>();
            dgDirectories.DataSource = directories;
            dgDirectories.Columns[0].Width = 32;
            dgDirectories.Columns[1].Width = 80;
            dgDirectories.Columns[2].Width = 200;
            dgDirectories.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Application.UseWaitCursor = false;
            Application.DoEvents();

            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Value = 100;
            UseWaitCursor = false;
            dgDirectories.UseWaitCursor = false;
            label1.Text = "Scan complete.";
            tableLayoutPanel1.RowStyles[0].Height = 0;
            ScanHandler.CompletedScan(this, new EventArgs());
            
            //TODO Prompt or give user a chance to save results (CSV?)
        }

        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            DirectoryState state = (DirectoryState)e.UserState;
            label1.Text = state.URL;
            if(progressBar1.Style != ProgressBarStyle.Continuous)
                progressBar1.Style = ProgressBarStyle.Continuous;

            progressBar1.Value = e.ProgressPercentage;
            directories.Add(state);
        }

        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string url = Properties.Settings.Default.last_url;
            if (url.EndsWith("/"))
                url = url.Substring(0, url.Length - 1);

            string mode = Properties.Settings.Default.scan_mode;
            List<string> dictionary = new List<string>();
            if (mode.Equals("normal"))
            {
                string[] words = Properties.Settings.Default.strings.Split(',');
                foreach (string word in words)
                    dictionary.Add(word);

            }
            else
            {
                using (StreamReader reader = new StreamReader(File.Open(Properties.Settings.Default.dictionary_path, FileMode.Open)))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                        dictionary.Add(line.Trim());

                }
            }

            int p = 0;
            int c = 0;
            foreach (string word in dictionary)
            {
                string tUrl = String.Format("{0}/{1}", url, word);
                
                try
                {
                    HttpWebResponse response = UrlChecker.GetResponse(tUrl);
                    backgroundWorker1.ReportProgress(p, new DirectoryState(response.StatusCode, tUrl));
                }
                catch (Exception)
                {
                    backgroundWorker1.ReportProgress(p, new DirectoryState(HttpStatusCode.NotFound, tUrl));
                }

                c++;
                p = c * 100 / dictionary.Count;
            }

            e.Result = true;
        }

        private void ScanPage_Load(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
            Application.DoEvents();
            progressBar1.Style = ProgressBarStyle.Marquee;
            ScanHandler.StartedScan(this, new EventArgs());
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
