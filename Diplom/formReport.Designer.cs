namespace Diplom
{
    partial class formReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.OstatokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReports = new Diplom.DataSetReports();
            this.OrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OstatokTableAdapter = new Diplom.DataSetReportsTableAdapters.OstatokTableAdapter();
            this.SalesTableAdapter = new Diplom.DataSetReportsTableAdapters.SalesTableAdapter();
            this.ClientsTableAdapter = new Diplom.DataSetReportsTableAdapters.ClientsTableAdapter();
            this.ProductsTableAdapter = new Diplom.DataSetReportsTableAdapters.ProductsTableAdapter();
            this.OrdersTableAdapter = new Diplom.DataSetReportsTableAdapters.OrdersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.OstatokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OstatokBindingSource
            // 
            this.OstatokBindingSource.DataMember = "Ostatok";
            this.OstatokBindingSource.DataSource = this.DataSetReports;
            // 
            // DataSetReports
            // 
            this.DataSetReports.DataSetName = "DataSetReports";
            this.DataSetReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrdersBindingSource
            // 
            this.OrdersBindingSource.DataMember = "Orders";
            this.OrdersBindingSource.DataSource = this.DataSetReports;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Остаток на складе",
            "Продажи по месяцам",
            "Покупки клиентов",
            "Прайс продукции",
            "Продажи за текущий месяц"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 284);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ProductsBindingSource
            // 
            this.ProductsBindingSource.DataMember = "Products";
            this.ProductsBindingSource.DataSource = this.DataSetReports;
            // 
            // ClientsBindingSource
            // 
            this.ClientsBindingSource.DataMember = "Clients";
            this.ClientsBindingSource.DataSource = this.DataSetReports;
            // 
            // SalesBindingSource
            // 
            this.SalesBindingSource.DataMember = "Sales";
            this.SalesBindingSource.DataSource = this.DataSetReports;
            // 
            // OstatokTableAdapter
            // 
            this.OstatokTableAdapter.ClearBeforeFill = true;
            // 
            // SalesTableAdapter
            // 
            this.SalesTableAdapter.ClearBeforeFill = true;
            // 
            // ClientsTableAdapter
            // 
            this.ClientsTableAdapter.ClearBeforeFill = true;
            // 
            // ProductsTableAdapter
            // 
            this.ProductsTableAdapter.ClearBeforeFill = true;
            // 
            // OrdersTableAdapter
            // 
            this.OrdersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отчеты";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 284);
            this.panel1.TabIndex = 4;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet";
            reportDataSource2.Value = this.OstatokBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Diplom.Reports.Report1.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(164, 35);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(316, 284);
            this.reportViewer.TabIndex = 5;
            // 
            // formReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 319);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formReport";
            this.Text = "formReport";
            this.Load += new System.EventHandler(this.formReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OstatokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource OstatokBindingSource;
        private DataSetReports DataSetReports;
        private DataSetReportsTableAdapters.OstatokTableAdapter OstatokTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource SalesBindingSource;
        private DataSetReportsTableAdapters.SalesTableAdapter SalesTableAdapter;
        private System.Windows.Forms.BindingSource ClientsBindingSource;
        private DataSetReportsTableAdapters.ClientsTableAdapter ClientsTableAdapter;
        private System.Windows.Forms.BindingSource ProductsBindingSource;
        private DataSetReportsTableAdapters.ProductsTableAdapter ProductsTableAdapter;
        private System.Windows.Forms.BindingSource OrdersBindingSource;
        private DataSetReportsTableAdapters.OrdersTableAdapter OrdersTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}