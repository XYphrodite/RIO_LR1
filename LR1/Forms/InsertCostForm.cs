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
    public partial class InsertCostForm : Form
    {
        public InsertCostForm(int itemId)
        {
            InitializeComponent();
            ItemId = itemId;
        }

        private int ItemId { get; }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((NameTextBox.Text != "") && (CostTextBox.Text != ""))
            {
                (new SqlWorker()).InsertCost(new monthlyCostModel()
                {
                    itemId = ItemId,
                    monthName = NameTextBox.Text,
                    cost = int.Parse(CostTextBox.Text)
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
