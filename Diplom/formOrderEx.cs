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
    public partial class formOrderEx : Form
    {
        Context db = new Context();
        decimal sum;
        public formOrderEx()
        {
            InitializeComponent();
        }

        private void formOrderEx_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.diplomDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.diplomDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.diplomDataSet.Products);
            this.ShowIcon = false;
            this.WindowState = FormWindowState.Maximized;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.OrderProducts". При необходимости она может быть перемещена или удалена.
            this.orderProductsTableAdapter.Fill(this.diplomDataSet.OrderProducts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.diplomDataSet.Orders);

            ((mainForm)MdiParent).toolStripStatusLabel.Text = "Готово";

        }

        private void DataGridReload()
        {
            var ord = int.Parse(orderIDTextBox.Text);
            var query = from orderProducts in db.orderProducts
                        where orderProducts.orderID == ord
                        select new
                        {
                            orderProductID = orderProducts.orderProductID,
                            orderID = orderProducts.orderID,
                            productID = orderProducts.productID,
                            count = orderProducts.count
                        };
            orderProductsBindingSource.DataSource = query.ToList();

        }
        private void DataGridPrice()
        {
            try
            {
                foreach (DataGridViewRow row in orderProductsDataGridView.Rows)
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
                foreach (DataGridViewRow row in orderProductsDataGridView.Rows)
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

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diplomDataSet);

        }

        private void orderIDTextBox_TextChanged(object sender, EventArgs e)
        {
            
            DataGridReload();
            DataGridPrice();
        }

        private void orderProductsDataGridView_BindingContextChanged(object sender, EventArgs e)
        {
            DataGridPrice();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
            ((mainForm)MdiParent).toolStripStatusLabel.Text = "Загрузка формы...";
            ((mainForm)MdiParent).Refresh();
            formOrder o = new formOrder();
            o.MdiParent =  this.MdiParent;
            o.Show();
        }

    }
}
