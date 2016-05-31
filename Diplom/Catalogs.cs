using Diplom.DataAccess;
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
    public partial class Catalogs : Form
    {
        public Catalogs()
        {
            InitializeComponent();
        }
        Context context;
        private void Catalogs_Load(object sender, EventArgs e)
        {
            
            this.ShowIcon = false;
            this.WindowState = FormWindowState.Maximized;
            
            context = new Context();
            providersBindingSource.DataSource = context.providers.Local.ToBindingList();
            context.providers.Load();
            productsBindingSource.DataSource = context.products.Local.ToBindingList();
            context.products.Load();
            clientsBindingSource.DataSource = context.clients.Local.ToBindingList();
            context.clients.Load();
            employeesBindingSource.DataSource = context.employes.Local.ToBindingList();
            context.employes.Load();
            dataGridView3.Columns[0].Visible = false;
            dataGridView1.Columns[0].Visible = false;
            dataGridView4.Columns[0].Visible = false;
            ((mainForm)MdiParent).toolStripStatusLabel.Text = "Готово";
        }

        private void pictureBoxClient_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("tabPageClient");
        }

        private void pictureBoxProvider_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("tabPageProvider");
        }

        private void pictureBoxProduct_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("tabPageProduct");
        }

        private void pictureBoxEmployee_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("tabPageEmployee");
        }

        private void toolStripButtonSave1_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            try
            {
                productsBindingSource.EndEdit();
                context.SaveChanges();
            }
            catch
            {
                var ms = MessageBox.Show("Ошибка сохранения!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void toolStripButtonSave3_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            try
            {
                employeesBindingSource.EndEdit();
                context.SaveChanges();
            }
            catch
            {
                var ms = MessageBox.Show("Ошибка сохранения!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void toolStripButtonSave2_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            try
            {
                providersBindingSource.EndEdit();
                context.SaveChanges();
            }
            catch
            {
                var ms = MessageBox.Show("Ошибка сохранения!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void toolStripButtonSave4_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            try
            {
                clientsBindingSource.EndEdit();
                context.SaveChanges();
            }
            catch
            {
                var ms = MessageBox.Show("Ошибка сохранения!", "Ошибка", MessageBoxButtons.OK);
            }
        }

    }
}
