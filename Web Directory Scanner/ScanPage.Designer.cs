namespace Web_Directory_Scanner
{
    partial class ScanPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnkClose = new System.Windows.Forms.LinkLabel();
            this.lnkSave = new System.Windows.Forms.LinkLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDirectories = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDirectories)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgDirectories, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(639, 433);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lnkClose);
            this.panel1.Controls.Add(this.lnkSave);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 71);
            this.panel1.TabIndex = 0;
            // 
            // lnkClose
            // 
            this.lnkClose.AutoSize = true;
            this.lnkClose.BackColor = System.Drawing.Color.Transparent;
            this.lnkClose.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkClose.LinkColor = System.Drawing.Color.White;
            this.lnkClose.Location = new System.Drawing.Point(409, 11);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.Size = new System.Drawing.Size(39, 18);
            this.lnkClose.TabIndex = 3;
            this.lnkClose.TabStop = true;
            this.lnkClose.Text = "Close";
            this.lnkClose.Visible = false;
            this.lnkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClose_LinkClicked);
            // 
            // lnkSave
            // 
            this.lnkSave.AutoSize = true;
            this.lnkSave.BackColor = System.Drawing.Color.Transparent;
            this.lnkSave.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSave.LinkColor = System.Drawing.Color.White;
            this.lnkSave.Location = new System.Drawing.Point(367, 11);
            this.lnkSave.Name = "lnkSave";
            this.lnkSave.Size = new System.Drawing.Size(36, 18);
            this.lnkSave.TabIndex = 2;
            this.lnkSave.TabStop = true;
            this.lnkSave.Text = "Save";
            this.lnkSave.Visible = false;
            this.lnkSave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSave_LinkClicked);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar1.Location = new System.Drawing.Point(7, 37);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(623, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please wait...";
            // 
            // dgDirectories
            // 
            this.dgDirectories.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgDirectories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDirectories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDirectories.Location = new System.Drawing.Point(3, 80);
            this.dgDirectories.Name = "dgDirectories";
            this.dgDirectories.RowHeadersVisible = false;
            this.dgDirectories.Size = new System.Drawing.Size(633, 350);
            this.dgDirectories.TabIndex = 1;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // ScanPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ScanPage";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(659, 453);
            this.Load += new System.EventHandler(this.ScanPage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDirectories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDirectories;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.LinkLabel lnkClose;
        private System.Windows.Forms.LinkLabel lnkSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
