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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.diplomDataSet.Orders);
                        this.ShowIcon = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
            var context = new Context();
            context.clients.Load();
            context.SaveChanges();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form form in ((mainForm)MdiParent).MdiChildren)
            {
                if(form != this)
                form.Close();
            }
            formOrderEx o = new formOrderEx();
            o.MdiParent = (mainForm)MdiParent;
            o.Show();
        }
    }
}
