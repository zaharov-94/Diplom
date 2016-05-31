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
    public partial class formOrder : Form
    {
        decimal sum = 0;
        public formOrder()
        {
            InitializeComponent();
            labelCount.Text = sum.ToString();
        }

        private void formOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.diplomDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.diplomDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.OrderProducts". При необходимости она может быть перемещена или удалена.
            this.orderProductsTableAdapter.Fill(this.diplomDataSet.OrderProducts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.diplomDataSet.Orders);
            this.ShowIcon = false;
            this.WindowState = FormWindowState.Maximized;
            labelUser.Text = Settings.userName;
            ((mainForm)MdiParent).toolStripStatusLabel.Text = "Готово";
        }
        Context db = new Context();
        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            var order = new Order();
            order.clientID = db.clients.Select(x => x).Where(x => x.name == clientIDComboBox.Text).FirstOrDefault().clientID;
            order.date = System.DateTime.Now;
            order.employeeID = Settings.userID;
            db.orders.Add(order);
            db.SaveChanges();
            foreach (DataGridViewRow row in orderProductsDataGridView.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    int pr = Convert.ToInt32(row.Cells[0].Value);

                    var product = new OrderProduct();
                    product.count = Convert.ToInt32(row.Cells[1].Value);
                    product.orderID = order.orderID;
                    product.productID = db.products.FirstOrDefault(x => x.productID == pr).productID;
                    db.orderProducts.Add(product);
                }
            }
            db.SaveChanges();
            MessageBox.Show("Заказ успешно добавлен!");
        }

        private void orderProductsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                sum = 0;
                decimal price;
                int pr;
                foreach (DataGridViewRow row in orderProductsDataGridView.Rows)
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
                int pr = Convert.ToInt32(orderProductsDataGridView.CurrentRow.Cells[0].Value);
                decimal price = db.products.FirstOrDefault(x => x.productID == pr).price;
                orderProductsDataGridView.CurrentRow.Cells[2].Value = price;

                if ((orderProductsDataGridView.CurrentRow.Cells[0].Value != null) && (orderProductsDataGridView.CurrentRow.Cells[1].Value != null))
                {
                    orderProductsDataGridView.CurrentRow.Cells[3].Value = Convert.ToInt32(orderProductsDataGridView.CurrentRow.Cells[1].Value) * price;
                }
            }
            catch { }
            ((mainForm)MdiParent).toolStripStatusLabel.Text = "Готово";
        }

        private void orderProductsDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            ((mainForm)MdiParent).toolStripStatusLabel.Text = "Редактирование...";
        }

        private void clientIDComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            ((mainForm)MdiParent).toolStripStatusLabel.Text = "Редактирование...";
        }

        private void clientIDComboBox_DropDownClosed(object sender, EventArgs e)
        {
            ((mainForm)MdiParent).toolStripStatusLabel.Text = "Готово";
        }

    }
}
