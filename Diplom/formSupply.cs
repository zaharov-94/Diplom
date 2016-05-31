using Diplom.DataAccess;
using Diplom.Models;
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
    public partial class formSupply : Form
    {
        decimal sum = 0;
        public formSupply()
        {
            InitializeComponent();
            labelCount.Text = sum.ToString();
        }

        private void formSupply_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Providers". При необходимости она может быть перемещена или удалена.
            this.providersTableAdapter.Fill(this.diplomDataSet.Providers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.diplomDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.diplomDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.OrderProducts". При необходимости она может быть перемещена или удалена.
            this.supplyProductsTableAdapter1.Fill(this.diplomDataSet.SupplyProducts);

            this.ShowIcon = false;
            this.WindowState = FormWindowState.Maximized;
            ((mainForm)MdiParent).toolStripStatusLabel.Text = "Готово";
        }
        Context db = new Context();
        private void buttonAddSupply_Click(object sender, EventArgs e)
        {
            var Supply = new Supply();
            Supply.providerID = db.providers.Select(x => x).Where(x => x.name == providerIDComboBox.Text).FirstOrDefault().providerID;
            Supply.date = System.DateTime.Now;
            Supply.employeeID = Settings.userID;
            db.supplies.Add(Supply);
            db.SaveChanges();
            foreach (DataGridViewRow row in SupplyProductsDataGridView.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    int pr = Convert.ToInt32(row.Cells[0].Value);

                    var product = new SupplyProduct();
                    product.count = Convert.ToInt32(row.Cells[1].Value);
                    product.supplyID = Supply.supplyID;
                    product.productID = db.products.FirstOrDefault(x => x.productID == pr).productID;
                    db.supplyProducts.Add(product);
                }
            }
            db.SaveChanges();
            MessageBox.Show("Заказ на поставку оформлен!");
        }

        private void SupplyProductsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                sum = 0;
                decimal price;
                int pr;
                foreach (DataGridViewRow row in SupplyProductsDataGridView.Rows)
                {
                    if ((row.Cells[0].Value != null)&&(row.Cells[1].Value != null))
                    {
                        pr = Convert.ToInt32(row.Cells[0].Value);
                        price = db.products.FirstOrDefault(x => x.productID == pr).price;
                        sum += Convert.ToInt32(row.Cells[1].Value) * price;
                    }
                }
                labelCount.Text = sum.ToString();
            }
            catch { }
            try
            {
                int pr = Convert.ToInt32(SupplyProductsDataGridView.CurrentRow.Cells[0].Value);
                decimal price = db.products.FirstOrDefault(x => x.productID == pr).price;
                SupplyProductsDataGridView.CurrentRow.Cells[2].Value = price;

                if ((SupplyProductsDataGridView.CurrentRow.Cells[0].Value != null) && (SupplyProductsDataGridView.CurrentRow.Cells[1].Value != null))
                {
                    SupplyProductsDataGridView.CurrentRow.Cells[3].Value = Convert.ToDecimal(SupplyProductsDataGridView.CurrentRow.Cells[1].Value) * price;
                }
            }
            catch { }
            ((mainForm)MdiParent).toolStripStatusLabel.Text = "Готово";
        }

        private void SupplyProductsDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            ((mainForm)MdiParent).toolStripStatusLabel.Text = "Редактирование...";
        }


        private void providerIDComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            ((mainForm)MdiParent).toolStripStatusLabel.Text = "Редактирование...";
            
        }

        private void providerIDComboBox_DropDownClosed(object sender, EventArgs e)
        {
            ((mainForm)MdiParent).toolStripStatusLabel.Text = "Готово";
        }

    }
}
