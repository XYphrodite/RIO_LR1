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
    public partial class InsertDeliveryForm : Form
    {
        public InsertDeliveryForm(int orderId)
        {
            InitializeComponent();
            OrderId = orderId;
        }

        private int OrderId { get; }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((NametextBox.Text != "")&& (CosttextBox.Text != ""))
            {
                (new SqlWorker()).InsertDelivery(new DeliveryModel()
                {
                    orderId = OrderId,
                    companyName = NametextBox.Text,
                    cost = int.Parse(CosttextBox.Text)
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
