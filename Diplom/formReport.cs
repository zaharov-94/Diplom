using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class formReport : Form
    {
        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
        public formReport()
        {
            InitializeComponent();
        }

        private void formReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DataSetReports.Orders". При необходимости она может быть перемещена или удалена.
            this.OrdersTableAdapter.Fill(this.DataSetReports.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DataSetReports.Products". При необходимости она может быть перемещена или удалена.
            this.ProductsTableAdapter.Fill(this.DataSetReports.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DataSetReports.Clients". При необходимости она может быть перемещена или удалена.
            this.ClientsTableAdapter.Fill(this.DataSetReports.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DataSetReports.Sales". При необходимости она может быть перемещена или удалена.
            this.SalesTableAdapter.Fill(this.DataSetReports.Sales);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DataSetReports.Ostatok". При необходимости она может быть перемещена или удалена.
            this.OstatokTableAdapter.Fill(this.DataSetReports.Ostatok);
            
            this.ShowIcon = false;
            this.WindowState = FormWindowState.Maximized;


            this.reportViewer.RefreshReport();
        }
        
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (listBox1.SelectedIndex)
            {
                case 0:                       
                        this.reportViewer.LocalReport.ReportEmbeddedResource = "Diplom.Reports.Report1.rdlc";
                        this.reportViewer.LocalReport.DataSources.Clear();
                        reportDataSource1.Name = "DataSet";
                        reportDataSource1.Value = this.OstatokBindingSource;
                        this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
                        this.reportViewer.RefreshReport();
                        break;
                case 1: 
                        this.reportViewer.LocalReport.ReportEmbeddedResource = "Diplom.Reports.Report2.rdlc";
                        this.reportViewer.LocalReport.DataSources.Clear();
                        reportDataSource1.Name = "DataSet";
                        reportDataSource1.Value = this.SalesBindingSource;
                        this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
                        this.reportViewer.RefreshReport();
                        break;
                case 2: 
                        this.reportViewer.LocalReport.ReportEmbeddedResource = "Diplom.Reports.Report3.rdlc";
                        this.reportViewer.LocalReport.DataSources.Clear();
                        reportDataSource1.Name = "DataSet";
                        reportDataSource1.Value = this.ClientsBindingSource;
                        this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
                        this.reportViewer.RefreshReport();
                        break;
                case 3: 
                        this.reportViewer.LocalReport.ReportEmbeddedResource = "Diplom.Reports.Report4.rdlc";
                        this.reportViewer.LocalReport.DataSources.Clear();
                        reportDataSource1.Name = "DataSet";
                        reportDataSource1.Value = this.ProductsBindingSource;
                        this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
                        this.reportViewer.RefreshReport();
                        break;
                case 4: 
                        this.reportViewer.LocalReport.ReportEmbeddedResource = "Diplom.Reports.Report5.rdlc";
                        this.reportViewer.LocalReport.DataSources.Clear();
                        reportDataSource1.Name = "DataSet";
                        reportDataSource1.Value = this.OrdersBindingSource;
                        this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
                        this.reportViewer.RefreshReport();
                        break;
            }
        }
    }
}
