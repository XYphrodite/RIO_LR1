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
    public partial class Form1 : Form
    {
        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Email", "Email");
        }

        //myDbContext context;
        SqlWorker context;
        public Form1()
        {
            InitializeComponent();
            context = new SqlWorker();
        }

        private void ShowUsersButton_Click(object sender, EventArgs e)
        {
            List<UserModel> list = context.getListOfMembers();
            CreateColumns();
            DataTable table = ToDataTable<UserModel>(list);

            //foreach (var l in list)
            //{
            //    table.Rows.Add(l.id, l.Name, l.Email);
            //    //dataGridView1.Rows.Add(l.id.ToString(), l.Name.ToString(), l.Email.ToString());
            //}



            //using (var reader = ObjectReader.Create(list))
            //{
            //    table.Load(reader);
            //}

            dataGridView1.DataSource = table;
        }
    }
}
