namespace Diplom
{
    partial class mainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxCatalog = new System.Windows.Forms.PictureBox();
            this.pictureBoxHelp = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pictureBoxReport = new System.Windows.Forms.PictureBox();
            this.pictureBoxOrder = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 280);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(691, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxCatalog);
            this.panel1.Controls.Add(this.pictureBoxHelp);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.pictureBoxReport);
            this.panel1.Controls.Add(this.pictureBoxOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 280);
            this.panel1.TabIndex = 5;
            // 
            // pictureBoxCatalog
            // 
            this.pictureBoxCatalog.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCatalog.Image")));
            this.pictureBoxCatalog.Location = new System.Drawing.Point(2, 69);
            this.pictureBoxCatalog.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxCatalog.Name = "pictureBoxCatalog";
            this.pictureBoxCatalog.Size = new System.Drawing.Size(62, 60);
            this.pictureBoxCatalog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCatalog.TabIndex = 0;
            this.pictureBoxCatalog.TabStop = false;
            this.pictureBoxCatalog.Click += new System.EventHandler(this.pictureBoxCatalog_Click);
            this.pictureBoxCatalog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCatalog_MouseDown);
            this.pictureBoxCatalog.MouseLeave += new System.EventHandler(this.pictureBoxCatalog_MouseLeave);
            this.pictureBoxCatalog.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCatalog_MouseMove);
            this.pictureBoxCatalog.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCatalog_MouseUp);
            // 
            // pictureBoxHelp
            // 
            this.pictureBoxHelp.Image = global::Diplom.Properties.Resources.help;
            this.pictureBoxHelp.Location = new System.Drawing.Point(3, 201);
            this.pictureBoxHelp.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxHelp.Name = "pictureBoxHelp";
            this.pictureBoxHelp.Size = new System.Drawing.Size(62, 60);
            this.pictureBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHelp.TabIndex = 10;
            this.pictureBoxHelp.TabStop = false;
            this.pictureBoxHelp.Click += new System.EventHandler(this.pictureBoxHelp_Click);
            this.pictureBoxHelp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxHelp_MouseDown);
            this.pictureBoxHelp.MouseLeave += new System.EventHandler(this.pictureBoxHelp_MouseLeave);
            this.pictureBoxHelp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxHelp_MouseMove);
            this.pictureBoxHelp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxHelp_MouseUp);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(71, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 280);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            this.splitter1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitter1_MouseMove);
            // 
            // pictureBoxReport
            // 
            this.pictureBoxReport.Image = global::Diplom.Properties.Resources.report;
            this.pictureBoxReport.Location = new System.Drawing.Point(3, 135);
            this.pictureBoxReport.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxReport.Name = "pictureBoxReport";
            this.pictureBoxReport.Size = new System.Drawing.Size(62, 60);
            this.pictureBoxReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxReport.TabIndex = 5;
            this.pictureBoxReport.TabStop = false;
            this.pictureBoxReport.Click += new System.EventHandler(this.pictureBoxReport_Click);
            this.pictureBoxReport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxReport_MouseDown);
            this.pictureBoxReport.MouseLeave += new System.EventHandler(this.pictureBoxReport_MouseLeave);
            this.pictureBoxReport.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxReport_MouseMove);
            this.pictureBoxReport.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxReport_MouseUp);
            // 
            // pictureBoxOrder
            // 
            this.pictureBoxOrder.AccessibleDescription = "";
            this.pictureBoxOrder.ErrorImage = null;
            this.pictureBoxOrder.Image = global::Diplom.Properties.Resources.zakaz;
            this.pictureBoxOrder.Location = new System.Drawing.Point(3, 9);
            this.pictureBoxOrder.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxOrder.Name = "pictureBoxOrder";
            this.pictureBoxOrder.Size = new System.Drawing.Size(62, 52);
            this.pictureBoxOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOrder.TabIndex = 4;
            this.pictureBoxOrder.TabStop = false;
            this.pictureBoxOrder.Tag = "";
            this.pictureBoxOrder.Click += new System.EventHandler(this.pictureBoxOrder_Click);
            this.pictureBoxOrder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxOrder_MouseDown);
            this.pictureBoxOrder.MouseLeave += new System.EventHandler(this.pictureBoxOrder_MouseLeave);
            this.pictureBoxOrder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxOrder_MouseMove);
            this.pictureBoxOrder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxOrder_MouseUp);
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Image = global::Diplom.Properties.Resources.close;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(76, 129);
            this.pictureBoxMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimize.TabIndex = 0;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMin_Click);
            this.pictureBoxMinimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMinimize_MouseDown);
            this.pictureBoxMinimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMinimize_MouseUp);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 302);
            this.Controls.Add(this.pictureBoxMinimize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(700, 340);
            this.Name = "mainForm";
            this.Text = "Ведение заказов";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxOrder;
        private System.Windows.Forms.PictureBox pictureBoxReport;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pictureBoxHelp;
        private System.Windows.Forms.PictureBox pictureBoxCatalog;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;

    }
}

