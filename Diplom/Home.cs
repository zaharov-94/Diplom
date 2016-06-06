using Diplom.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetReports.Ostatok". При необходимости она может быть перемещена или удалена.
            this.ostatokTableAdapter.Fill(this.dataSetReports.Ostatok);
            this.ShowIcon = false;
            this.WindowState = FormWindowState.Maximized;
            ((mainForm)MdiParent).toolStripStatusLabel.Text = "Готово";
        }


    }
}
