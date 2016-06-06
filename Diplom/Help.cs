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
    public partial class Help : Form
    {
        List<HelpPage> listHelpPages;
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            this.ShowIcon = false;
            this.WindowState = FormWindowState.Maximized;
            listHelpPages = new List<HelpPage>();
            //listHelpPages.Add(new HelpPage("Основное", Application.StartupPath + @"\HelpPages\Main.htm"));
            //listHelpPages.Add(new HelpPage("Добавление заказа", Application.StartupPath + @"\HelpPages\Order.htm"));
            //listHelpPages.Add(new HelpPage("Справочники", Application.StartupPath + @"\HelpPages\Catalog.htm"));
            //listHelpPages.Add(new HelpPage("Работа с отчетами", Application.StartupPath + @"\HelpPages\Report.htm"));
            listHelpPages.Add(new HelpPage("О программе", Application.StartupPath + @"\HelpPages\About.htm"));
            foreach (HelpPage hp in listHelpPages)
            {
                listBox.Items.Add(hp.Name);
            }
            ((mainForm)MdiParent).toolStripStatusLabel.Text = "Готово";
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(HelpPage hp in listHelpPages)
            {
                if (hp.Name == (string)listBox.SelectedItem) webBrowser.Navigate(hp.Url);
            }
        }
    }
}
