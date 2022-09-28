namespace LR1.Forms
{
    partial class InsertOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrderItemIdLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.OrderItemIdTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OrderItemIdLabel
            // 
            this.OrderItemIdLabel.AutoSize = true;
            this.OrderItemIdLabel.Location = new System.Drawing.Point(12, 9);
            this.OrderItemIdLabel.Name = "OrderItemIdLabel";
            this.OrderItemIdLabel.Size = new System.Drawing.Size(65, 13);
            this.OrderItemIdLabel.TabIndex = 1;
            this.OrderItemIdLabel.Text = "OrderItemId:";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(12, 35);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(46, 13);
            this.AmountLabel.TabIndex = 2;
            this.AmountLabel.Text = "Amount:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(12, 61);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(34, 13);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Price:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(15, 84);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(265, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(87, 58);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(193, 20);
            this.PriceTextBox.TabIndex = 6;
            // 
            // OrderItemIdTextBox
            // 
            this.OrderItemIdTextBox.Location = new System.Drawing.Point(87, 6);
            this.OrderItemIdTextBox.Name = "OrderItemIdTextBox";
            this.OrderItemIdTextBox.Size = new System.Drawing.Size(193, 20);
            this.OrderItemIdTextBox.TabIndex = 6;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(87, 32);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(193, 20);
            this.AmountTextBox.TabIndex = 7;
            // 
            // InsertOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 112);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.OrderItemIdTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.OrderItemIdLabel);
            this.Name = "InsertOrderForm";
            this.Text = "InsertOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderItemIdLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox OrderItemIdTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
    }
}