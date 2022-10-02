using LR1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1.Forms
{
    public partial class InsertItemForm : Form
    {
        public InsertItemForm(int orderId)
        {
            InitializeComponent();
            OrderId = orderId;
        }

        private int OrderId { get; }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                (new SqlWorker()).InsertItem(new ItemModel()
                {
                    orderId = OrderId,
                    Name = textBox1.Text
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
