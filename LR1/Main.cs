using LR1.Forms;
using LR1.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1
{
    public partial class Main : Form
    {

        private void CreateColumnsUsers()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Email", "Email");
        }
        private void CreateColumnsOrders()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("userId", "userId");
            dataGridView1.Columns.Add("amount", "amount");
            dataGridView1.Columns.Add("cost", "cost");
        }
        private void CreateColumnsItems()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("orderId", "orderId");
            dataGridView1.Columns.Add("Name", "Name");
        }
        private void CreateColumnsDeliveries()
        {
            dataGridView1.Columns.Add("orderId", "orderId");
            dataGridView1.Columns.Add("companyName", "companyName");
            dataGridView1.Columns.Add("cost", "cost");
        }
        private void CreateColumnsMonthlyCosts()
        {
            dataGridView1.Columns.Add("itemId", "itemId");
            dataGridView1.Columns.Add("monthName", "monthName");
            dataGridView1.Columns.Add("cost", "cost");
        }

        SqlWorker repo;
        public Main()
        {
            InitializeComponent();
            repo = new SqlWorker();
        }

        private void ShowUsersButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            List<UserModel> list = repo.getListOfUsers();
            CreateColumnsUsers();

            foreach (var l in list)
            {
                dataGridView1.Rows.Add(l.id, l.Name, l.Email);
            }
            dataGridView1.Select();
        }

        private void InsertUserButton_Click(object sender, EventArgs e)
        {
            var insertUserForm = new InsertUserFrom();
            insertUserForm.Show();
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
                new SqlWorker().DeleteUser((int)item.Cells[0].Value);
            }
        }

        private void showOrdersButton_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                list.Add((int)dataGridView1.SelectedRows[i].Cells[0].Value);
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            CreateColumnsOrders();
            List<OrderModel> orderList;
            if (list.Count != 0)
            {
                orderList = repo.GetOrdersList(list);
            }
            else
            {
                orderList = repo.GetOrdersList();
            }
            foreach (var l in orderList)
            {
                dataGridView1.Rows.Add(l.id, l.userId, l.amount, l.cost);
            }

        }
        private void InsertOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                var insertOrderForm = new InsertOrderForm(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                insertOrderForm.Show();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
                new SqlWorker().DeleteOrder((int)item.Cells[0].Value);
            }
        }

        private void showItemsBitton_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                list.Add((int)dataGridView1.SelectedRows[i].Cells[0].Value);
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            List<ItemModel> itemList;
            CreateColumnsItems();
            if (list.Count != 0)
            {
                itemList = repo.GetItemsList(list);
            }
            else
            {
                itemList = repo.GetItemsList();
            }
            foreach (var l in itemList)
            {
                dataGridView1.Rows.Add(l.id, l.orderId, l.Name);
            }
        }

        private void inserItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                var insertOrderForm = new InsertItemForm(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                insertOrderForm.Show();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
                new SqlWorker().DeleteItem((int)item.Cells[0].Value);
            }
        }

        private void showDeliveryInfoButton_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                list.Add((int)dataGridView1.SelectedRows[i].Cells[0].Value);
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            CreateColumnsDeliveries();
            List<DeliveryModel> deliveryList;
            if (list.Count != 0)
            {
                deliveryList = repo.GetDeliveryList(list);
            }
            else
            {
                deliveryList = repo.GetDeliveryList();
            }
            foreach (var l in deliveryList)
            {
                dataGridView1.Rows.Add(l.orderId, l.companyName, l.cost);
            }
        }

        private void insertDeliveryInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                var insertOrderForm = new InsertDeliveryForm(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                insertOrderForm.Show();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void deleteDeliveryInfoButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
                new SqlWorker().DeleteDelivery((int)item.Cells[0].Value);
            }
        }

        private void showCostsButton_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                list.Add((int)dataGridView1.SelectedRows[i].Cells[0].Value);
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            CreateColumnsMonthlyCosts();
            List<monthlyCostModel> deliveryList;
            if (list.Count != 0)
            {
                deliveryList = repo.GetCostsList(list);
            }
            else
            {
                deliveryList = repo.GetCostsList();
            }
            foreach (var l in deliveryList)
            {
                dataGridView1.Rows.Add(l.itemId, l.monthName, l.cost);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var insertOrderForm = new InsertCostForm(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                insertOrderForm.Show();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
                new SqlWorker().DeleteCost((int)item.Cells[0].Value);
            }
        }

        private void SendToBd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            try
            {
                dataGridView1.DataSource = repo.Query(richTextBox1.Text);
                
            }
            catch
            {

            }
            richTextBox1.Text = "";
        }
    }
}
