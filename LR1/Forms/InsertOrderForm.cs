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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LR1.Forms
{
    public partial class InsertOrderForm : Form
    {
        public InsertOrderForm(string userId)
        {
            InitializeComponent();
            UserId = userId;
        }

        private string UserId { get; }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((OrderItemIdTextBox.Text != "") && (AmountTextBox.Text != "") && (PriceTextBox.Text != ""))
            {
                (new SqlWorker()).InsertOrder(new OrderModel()
                {
                    OrderItemId = OrderItemIdTextBox.Text,
                    amount= int.Parse(AmountTextBox.Text),
                    Price=int.Parse(PriceTextBox.Text)
                }, UserId);
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
