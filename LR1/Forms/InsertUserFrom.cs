using LR1.Models;
using System;
using System.Windows.Forms;

namespace LR1
{
    public partial class InsertUserFrom : Form
    {
        public InsertUserFrom()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "")&&(textBox2.Text != ""))
            {
                (new SqlWorker()).InsertUser(new UserModel()
                {
                    Name = textBox1.Text,
                    Email = textBox2.Text
                });
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
                this.Close();
            }
        }
    }
}
