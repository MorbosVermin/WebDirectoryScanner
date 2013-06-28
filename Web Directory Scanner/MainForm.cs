using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Directory_Scanner
{
    public partial class MainForm : Form
    {

        private bool Dragging { get; set; }
        private Point DragCursorPoint { get; set; }
        private Point DragFormPoint { get; set; }

        private PageManager pageManager;

        public MainForm()
        {
            InitializeComponent();
            ClickHandler.Click += ClickHandler_Click;
            ScanHandler.Started += ScanHandler_Started;
            ScanHandler.Completed += ScanHandler_Completed;

            this.pageManager = new PageManager(this.splitContainer1, this.welcomePage1);

            Dragging = false;
            this.MouseDown += MainForm_MouseDown;
            this.MouseUp += MainForm_MouseUp;
            this.MouseMove += MainForm_MouseMove;
            splitContainer1.Panel1.MouseDown += MainForm_MouseDown;
            splitContainer1.Panel1.MouseUp += MainForm_MouseUp;
            splitContainer1.Panel1.MouseMove += MainForm_MouseMove;
        }

        void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = Point.Subtract(Cursor.Position, new Size(DragCursorPoint));
                this.Location = Point.Add(DragFormPoint, new Size(p));
            }
        }

        void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursorPoint = Cursor.Position;
            DragFormPoint = this.Location;
        }

        void ScanHandler_Completed(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            linkLabel1.Enabled = true;
            btnSave.Visible = true;
        }

        void ScanHandler_Started(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            linkLabel1.Enabled = false;
            btnSave.Visible = false;
        }

        void ClickHandler_Click(object sender, ClickHandler.ClickEventArgs e)
        {
            Console.WriteLine("User clicked button: {0}", e.Name);
            if (e.Name.Equals("exit"))
            {
                //TODO check status and allow user to cancel out if needed.
                Dispose();
            }
            else if (e.Name.Equals("start_config"))
            {
                pageManager.ChangePage(new ConfigurePage());
            }
            else if (e.Name.Equals("cancel_scan"))
            {
                pageManager.ShowWelcomePage();
            }
            else if (e.Name.Equals("start_scan"))
            {
                pageManager.ChangePage(new ScanPage());
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClickHandler.HandleClick(this, new ClickHandler.ClickEventArgs("exit"));
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClickHandler.HandleClick(this, new ClickHandler.ClickEventArgs("start_config"));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
