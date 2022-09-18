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

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Email", "Email");
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
            CreateColumns();

            foreach (var l in list)
            {
                dataGridView1.Rows.Add(l.id, l.Name, l.Email);
            }



        }

        private void InsertUserButton_Click(object sender, EventArgs e)
        {
            var inserUserForm = new InsertUserFrom();
            inserUserForm.Show();
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
                new SqlWorker().DeleteUser((int)item.Cells[0].Value);
                
            }
        }
    }
}
