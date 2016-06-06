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
            pictureBoxClient.Image = Properties.Resources.client_cur;
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

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0: { pictureBoxClient.Image = Properties.Resources.client_cur; 
                    pictureBoxProvider.Image = Properties.Resources.delivery_icon_co;
                    pictureBoxProduct.Image = Properties.Resources.tovar;
                    pictureBoxEmployee.Image = Properties.Resources.sotr;
                    break; }
                case 1: { pictureBoxProvider.Image = Properties.Resources.delivery_icon_cur;
                    pictureBoxClient.Image = Properties.Resources.client;
                    pictureBoxProduct.Image = Properties.Resources.tovar;
                    pictureBoxEmployee.Image = Properties.Resources.sotr;
                    break; }
                case 2: { pictureBoxProduct.Image = Properties.Resources.tovar_cur;
                    pictureBoxClient.Image = Properties.Resources.client;
                    pictureBoxProvider.Image = Properties.Resources.delivery_icon_co;
                    pictureBoxEmployee.Image = Properties.Resources.sotr;
                    break; }
                case 3: { pictureBoxEmployee.Image = Properties.Resources.sotr_cur;
                    pictureBoxClient.Image = Properties.Resources.client;
                    pictureBoxProvider.Image = Properties.Resources.delivery_icon_co;
                    pictureBoxProduct.Image = Properties.Resources.tovar;
                    break; }
            }
        }

        private void pictureBoxClient_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxClient.Image = Properties.Resources.clientClick;
        }

        private void pictureBoxClient_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxClient.Image = Properties.Resources.client_cur;
        }

        private void pictureBoxProvider_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxProvider.Image = Properties.Resources.delivery_icon_coClick;
        }

        private void pictureBoxProvider_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxProvider.Image = Properties.Resources.delivery_icon_cur;
        }

        private void pictureBoxProduct_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxProduct.Image = Properties.Resources.tovarClick;
        }

        private void pictureBoxProduct_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxProduct.Image = Properties.Resources.tovar_cur;
        }

        private void pictureBoxEmployee_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxEmployee.Image = Properties.Resources.sotrClick;
        }

        private void pictureBoxEmployee_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxEmployee.Image = Properties.Resources.sotr_cur;
        }


    }
}
