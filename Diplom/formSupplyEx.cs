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

namespace Diplom
{
    public partial class formSupplyEx : Form
    {
        Context db = new Context();
        decimal sum;
        public formSupplyEx()
        {
            InitializeComponent();
        }

        private void formSupplyEx_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.SupplyProducts". При необходимости она может быть перемещена или удалена.
            this.supplyProductsTableAdapter.Fill(this.diplomDataSet.SupplyProducts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.diplomDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Providers". При необходимости она может быть перемещена или удалена.
            this.providersTableAdapter.Fill(this.diplomDataSet.Providers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Supplies". При необходимости она может быть перемещена или удалена.
            this.suppliesTableAdapter.Fill(this.diplomDataSet.Supplies);

            this.ShowIcon = false;
            this.WindowState = FormWindowState.Maximized;

            ((mainForm)MdiParent).toolStripStatusLabel.Text = "Готово";

        }

        private void DataGridReload()
        {
            var ord = int.Parse(supplyIDTextBox.Text);
            var query = from SupplyProducts in db.supplyProducts
                        where SupplyProducts.supplyID == ord
                        select new
                        {
                            SupplyProductID = SupplyProducts.supplyProductID,
                            SupplyID = SupplyProducts.supplyID,
                            productID = SupplyProducts.productID,
                            count = SupplyProducts.count
                        };
            supplyProductsBindingSource.DataSource = query.ToList();

        }
        private void DataGridPrice()
        {
            try
            {
                foreach (DataGridViewRow row in supplyProductsDataGridView.Rows)
                {
                    int pr = Convert.ToInt32(row.Cells[0].Value);
                    decimal price = db.products.FirstOrDefault(x => x.productID == pr).price;
                    row.Cells[1].Value = price;
                    row.Cells[3].Value = Convert.ToInt32(row.Cells[2].Value) * price;
                }
                
            }
            catch { }
            try
            {
                sum = 0;
                decimal price;
                int pr;
                foreach (DataGridViewRow row in supplyProductsDataGridView.Rows)
                {
                    if ((row.Cells[0].Value != null) && (row.Cells[2].Value != null))
                    {
                        pr = Convert.ToInt32(row.Cells[0].Value);
                        price = db.products.FirstOrDefault(x => x.productID == pr).price;
                        sum += Convert.ToInt32(row.Cells[2].Value) * price;
                    }
                }
                labelTotalPrice.Text = sum.ToString();
            }
            catch { }
        }

        private void SupplyIDTextBox_TextChanged(object sender, EventArgs e)
        {
            DataGridReload();
            DataGridPrice();
        }

        private void SupplyProductsDataGridView_BindingContextChanged(object sender, EventArgs e)
        {
            DataGridPrice();
        }

        private void suppliesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diplomDataSet);

        }

    }
}
