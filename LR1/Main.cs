using LR1.Forms;
using LR1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            dataGridView1.Columns.Add("OrderItemId", "OrderItemId");
            dataGridView1.Columns.Add("amount", "amount");
            dataGridView1.Columns.Add("Price", "Price");
        }
        private void CreateColumnsItems()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Name", "Name");
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
            List<UserModel> list = repo.getListOfMembers();
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
            //var id = dataGridView1.SelectedRows.
            CreateColumnsOrders();
            var orderList = repo.GetOrdersList(list);
            foreach (var l in orderList)
            {
                dataGridView1.Rows.Add(l.id, l.OrderItemId, l.amount, l.Price);
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
            CreateColumnsItems();
            var itemList = repo.GetItemsList(list);
            foreach (var l in itemList)
            {
                dataGridView1.Rows.Add(l.id, l.Name);
            }
        }

        private void InsertOrderButton_Click(object sender, EventArgs e)
        {
            var insertOrderForm = new InsertOrderForm(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            insertOrderForm.Show();
        }
    }
}
