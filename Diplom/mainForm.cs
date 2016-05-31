using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Diplom
{
    public partial class mainForm : Form
    {
        private int h1;
        private int w1;
        private List<HelpPage> listHelpPages;
        bool f = false;

        public mainForm()
        {
            InitializeComponent();
            AppStart();
            HelpInitialize();            
        }

        private void HelpInitialize()
        {
            listHelpPages = new List<HelpPage>();
            listHelpPages.Add(new HelpPage("Основное", Application.StartupPath + @"\HelpPages\Main.htm"));
            listHelpPages.Add(new HelpPage("Добавление заказа", Application.StartupPath + @"\HelpPages\Order.htm"));
            listHelpPages.Add(new HelpPage("Справочники", Application.StartupPath + @"\HelpPages\Catalog.htm"));
            listHelpPages.Add(new HelpPage("Работа с отчетами", Application.StartupPath + @"\HelpPages\Report.htm"));
            listHelpPages.Add(new HelpPage("О программе", Application.StartupPath + @"\HelpPages\About.htm"));
            foreach (HelpPage hp in listHelpPages)
            {
                //listBoxInformation.Items.Add(hp.Name);
            }
        }

        private void AppStart()
        {
            //splitter2.Visible = false;
            toolTip.SetToolTip(pictureBoxReport, "Отчеты");
            toolTip.SetToolTip(pictureBoxOrder, "Добавить заказ");
            toolTip.SetToolTip(pictureBoxCatalog, "Справочники");
            toolTip.SetToolTip(pictureBoxHelp, "Помощь");
            toolTip.SetToolTip(pictureBoxMinimize, "Скрыть");
            toolStripStatusLabel.Text = "Готово";
            h1 = this.Size.Height;
            w1 = this.Size.Width;
        }

        # region ButtonOrder

            private void pictureBoxOrder_Click(object sender, EventArgs e)
            {
                this.toolStripStatusLabel.Text = "Загрузка формы...";
                this.Refresh();
                foreach (Form form in this.MdiChildren)
                    form.Close();
                formOrder o = new formOrder();
                o.MdiParent = this;
                o.Show();
            }

            private void pictureBoxOrder_MouseMove(object sender, MouseEventArgs e)
            {
                pictureBoxCatalog.BorderStyle = BorderStyle.None;
                pictureBoxReport.BorderStyle = BorderStyle.None;
                pictureBoxHelp.BorderStyle = BorderStyle.None;
                pictureBoxOrder.BorderStyle = BorderStyle.FixedSingle;
            }

            private void pictureBoxOrder_MouseLeave(object sender, EventArgs e)
            {
                pictureBoxOrder.BorderStyle = BorderStyle.None;
            }

            private void pictureBoxOrder_MouseDown(object sender, MouseEventArgs e)
            {
                pictureBoxOrder.Image = Properties.Resources.zakazClick;
            }

            private void pictureBoxOrder_MouseUp(object sender, MouseEventArgs e)
            {
                pictureBoxOrder.Image = Properties.Resources.zakaz;
            }
        #endregion    

        #region ButtonReport

            private void pictureBoxReport_Click(object sender, EventArgs e)
            {
                this.toolStripStatusLabel.Text = "Загрузка формы...";
                this.Refresh();
                foreach (Form form in this.MdiChildren)
                    form.Close();
                formReport r = new formReport();
                r.MdiParent = this;
                r.Show();
            }

            private void pictureBoxReport_MouseMove(object sender, MouseEventArgs e)
            {
                pictureBoxCatalog.BorderStyle = BorderStyle.None;
                pictureBoxOrder.BorderStyle = BorderStyle.None;
                pictureBoxHelp.BorderStyle = BorderStyle.None;
                pictureBoxReport.BorderStyle = BorderStyle.FixedSingle;
            }

            private void pictureBoxReport_MouseLeave(object sender, EventArgs e)
            {
                pictureBoxReport.BorderStyle = BorderStyle.None;
            }

            private void pictureBoxReport_MouseDown(object sender, MouseEventArgs e)
            {
                pictureBoxReport.Image = Properties.Resources.reportClick;
            }

            private void pictureBoxReport_MouseUp(object sender, MouseEventArgs e)
            {
                pictureBoxReport.Image = Properties.Resources.report;
            }
        #endregion

        #region ButtonHelp
            private void pictureBoxHelp_Click(object sender, EventArgs e)
            {
                this.toolStripStatusLabel.Text = "Загрузка формы...";
                this.Refresh();
                foreach (Form form in this.MdiChildren)
                    form.Close();
                Help h = new Help();
                h.MdiParent = this;
                h.Show();
            }

            private void pictureBoxHelp_MouseMove(object sender, MouseEventArgs e)
            {
                pictureBoxCatalog.BorderStyle = BorderStyle.None;
                pictureBoxReport.BorderStyle = BorderStyle.None;
                pictureBoxOrder.BorderStyle = BorderStyle.None;
                pictureBoxHelp.BorderStyle = BorderStyle.FixedSingle;
            }

            private void pictureBoxHelp_MouseLeave(object sender, EventArgs e)
            {
                pictureBoxHelp.BorderStyle = BorderStyle.None;
            }

            private void pictureBoxHelp_MouseDown(object sender, MouseEventArgs e)
            {
                pictureBoxHelp.Image = Properties.Resources.helpClick;
            }

            private void pictureBoxHelp_MouseUp(object sender, MouseEventArgs e)
            {
                pictureBoxHelp.Image = Properties.Resources.help;
            }

        #endregion

        #region Catalog
            private void pictureBoxCatalog_Click(object sender, EventArgs e)
            {
                this.toolStripStatusLabel.Text = "Загрузка формы...";
                this.Refresh();
                foreach (Form form in this.MdiChildren)
                    form.Close();
                Catalogs c = new Catalogs();
                c.MdiParent = this;
                c.Show();
            }
        
            private void pictureBoxCatalog_MouseMove(object sender, MouseEventArgs e)
            {
                pictureBoxOrder.BorderStyle = BorderStyle.None;
                pictureBoxReport.BorderStyle = BorderStyle.None;
                pictureBoxHelp.BorderStyle = BorderStyle.None;
                pictureBoxCatalog.BorderStyle = BorderStyle.FixedSingle;
            }

            private void pictureBoxCatalog_MouseLeave(object sender, EventArgs e)
            {
                pictureBoxCatalog.BorderStyle = BorderStyle.None;
            }

            private void pictureBoxCatalog_MouseDown(object sender, MouseEventArgs e)
            {
                pictureBoxCatalog.Image = Properties.Resources.catalogueClick;
            }

            private void pictureBoxCatalog_MouseUp(object sender, MouseEventArgs e)
            {
                pictureBoxCatalog.Image = Properties.Resources.catalogue;
            }
        #endregion

        #region Supply
            private void pictureBoxSupply_Click(object sender, EventArgs e)
            {
                this.toolStripStatusLabel.Text = "Загрузка формы...";
                this.Refresh();
                foreach (Form form in this.MdiChildren)
                    form.Close();
                formSupply s = new formSupply();
                s.MdiParent = this;
                s.Show();
            }
        
        #endregion

        #region MinimizePanel
            private void MouseClick1()
            {
                panel1.Visible = false;
                //splitter2.Visible = true;
                //tabControlMain.Location = new Point(7, 0);
                //tabControlMain.Width = w1-22;
                //Information.Width = w1 - 180;
                pictureBoxMinimize.Location = new Point(0, this.Height / 2 - 55);
                pictureBoxMinimize.Image = Properties.Resources.open;
                toolTip.SetToolTip(pictureBoxMinimize, "Отобразить");
            }

            private void MouseClick2()
            {
                panel1.Visible = true;
                //splitter2.Visible = false;
                //tabControlMain.Location = new Point(91, 0);
                //tabControlMain.Width = w1-106;
                //Information.Width = w1 - 264;
                pictureBoxMinimize.Location = new Point(92, this.Height / 2 - 55);
                pictureBoxMinimize.Image = Properties.Resources.close;
                toolTip.SetToolTip(pictureBoxMinimize, "Скрыть");
            }

            private void pictureBoxMin_Click(object sender, EventArgs e)
            {
                if (panel1.Visible) MouseClick1();
                else MouseClick2();
            }

            private void pictureBoxMinimize_MouseDown(object sender, MouseEventArgs e)
            {
                if (panel1.Visible) pictureBoxMinimize.Image = Properties.Resources.closeClick;
                else pictureBoxMinimize.Image = Properties.Resources.openClick;
                
            }

            private void pictureBoxMinimize_MouseUp(object sender, MouseEventArgs e)
            {
                if (panel1.Visible) pictureBoxMinimize.Image = Properties.Resources.close;
                else pictureBoxMinimize.Image = Properties.Resources.open;
            }
        #endregion

        #region WindowSizeChange
            private void Form1_Resize(object sender, EventArgs e)
            {
                //tabControlMain.Height += this.Size.Height - h1;
                //tabControlMain.Width += this.Size.Width - w1;
                panel1.Height += this.Size.Height - h1;
                //splitter2.Height = this.Size.Height;
                pictureBoxMinimize.Location = new Point(pictureBoxMinimize.Location.X, panel1.Height / 2 - 12);
                //listBoxInformation.Height = this.Size.Height-100;
                //Information.Height += this.Size.Height - h1;
                //Information.Width += this.Size.Width - w1;
                h1 = this.Size.Height;
                w1 = this.Size.Width;
            }

            private void Form1_ResizeBegin(object sender, EventArgs e)
            {
                h1 = this.Size.Height;
                w1 = this.Size.Width;
                toolStripStatusLabel.Text = "Изменение размера";
            }

            private void Form1_ResizeEnd(object sender, EventArgs e)
            {
                toolStripStatusLabel.Text = "Готово";
            }
        #endregion

        private void listBoxInformation_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(HelpPage hp in listHelpPages)
            {
               // if (hp.Name == (string)listBoxInformation.SelectedItem) Information.Navigate(hp.Url);
            }

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Home h = new Home();
            h.MdiParent = this;
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
                    form.Close();
            formSupplyEx o = new formSupplyEx();
            o.MdiParent = this;
            o.Show();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
