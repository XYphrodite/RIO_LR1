namespace LR1
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowUsersButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InsertUserButton = new System.Windows.Forms.Button();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.showOrdersButton = new System.Windows.Forms.Button();
            this.showItemsBitton = new System.Windows.Forms.Button();
            this.InsertOrderButton = new System.Windows.Forms.Button();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.inserItemButton = new System.Windows.Forms.Button();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.showDeliveryInfoButton = new System.Windows.Forms.Button();
            this.insertDeliveryInfoButton = new System.Windows.Forms.Button();
            this.deleteDeliveryInfoButton = new System.Windows.Forms.Button();
            this.showCostsButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowUsersButton
            // 
            this.ShowUsersButton.Location = new System.Drawing.Point(13, 170);
            this.ShowUsersButton.Name = "ShowUsersButton";
            this.ShowUsersButton.Size = new System.Drawing.Size(75, 23);
            this.ShowUsersButton.TabIndex = 1;
            this.ShowUsersButton.Text = "Show users";
            this.ShowUsersButton.UseVisualStyleBackColor = true;
            this.ShowUsersButton.Click += new System.EventHandler(this.ShowUsersButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // InsertUserButton
            // 
            this.InsertUserButton.Location = new System.Drawing.Point(13, 200);
            this.InsertUserButton.Name = "InsertUserButton";
            this.InsertUserButton.Size = new System.Drawing.Size(75, 23);
            this.InsertUserButton.TabIndex = 3;
            this.InsertUserButton.Text = "Insert user";
            this.InsertUserButton.UseVisualStyleBackColor = true;
            this.InsertUserButton.Click += new System.EventHandler(this.InsertUserButton_Click);
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(13, 230);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteUserButton.TabIndex = 4;
            this.DeleteUserButton.Text = "Delete user";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // showOrdersButton
            // 
            this.showOrdersButton.Location = new System.Drawing.Point(94, 169);
            this.showOrdersButton.Name = "showOrdersButton";
            this.showOrdersButton.Size = new System.Drawing.Size(75, 23);
            this.showOrdersButton.TabIndex = 5;
            this.showOrdersButton.Text = "Show orders";
            this.showOrdersButton.UseVisualStyleBackColor = true;
            this.showOrdersButton.Click += new System.EventHandler(this.showOrdersButton_Click);
            // 
            // showItemsBitton
            // 
            this.showItemsBitton.Location = new System.Drawing.Point(176, 168);
            this.showItemsBitton.Name = "showItemsBitton";
            this.showItemsBitton.Size = new System.Drawing.Size(75, 23);
            this.showItemsBitton.TabIndex = 6;
            this.showItemsBitton.Text = "Show items";
            this.showItemsBitton.UseVisualStyleBackColor = true;
            this.showItemsBitton.Click += new System.EventHandler(this.showItemsBitton_Click);
            // 
            // InsertOrderButton
            // 
            this.InsertOrderButton.Location = new System.Drawing.Point(95, 199);
            this.InsertOrderButton.Name = "InsertOrderButton";
            this.InsertOrderButton.Size = new System.Drawing.Size(75, 23);
            this.InsertOrderButton.TabIndex = 7;
            this.InsertOrderButton.Text = "Insert order";
            this.InsertOrderButton.UseVisualStyleBackColor = true;
            this.InsertOrderButton.Click += new System.EventHandler(this.InsertOrderButton_Click);
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(95, 229);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(75, 23);
            this.deleteOrderButton.TabIndex = 8;
            this.deleteOrderButton.Text = "Delete order";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // inserItemButton
            // 
            this.inserItemButton.Location = new System.Drawing.Point(176, 198);
            this.inserItemButton.Name = "inserItemButton";
            this.inserItemButton.Size = new System.Drawing.Size(75, 23);
            this.inserItemButton.TabIndex = 9;
            this.inserItemButton.Text = "Insert item";
            this.inserItemButton.UseVisualStyleBackColor = true;
            this.inserItemButton.Click += new System.EventHandler(this.inserItemButton_Click);
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(177, 229);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(75, 23);
            this.deleteItemButton.TabIndex = 10;
            this.deleteItemButton.Text = "Delete item";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // showDeliveryInfoButton
            // 
            this.showDeliveryInfoButton.Location = new System.Drawing.Point(258, 168);
            this.showDeliveryInfoButton.Name = "showDeliveryInfoButton";
            this.showDeliveryInfoButton.Size = new System.Drawing.Size(128, 23);
            this.showDeliveryInfoButton.TabIndex = 11;
            this.showDeliveryInfoButton.Text = "Show Delivery Info";
            this.showDeliveryInfoButton.UseVisualStyleBackColor = true;
            this.showDeliveryInfoButton.Click += new System.EventHandler(this.showDeliveryInfoButton_Click);
            // 
            // insertDeliveryInfoButton
            // 
            this.insertDeliveryInfoButton.Location = new System.Drawing.Point(258, 197);
            this.insertDeliveryInfoButton.Name = "insertDeliveryInfoButton";
            this.insertDeliveryInfoButton.Size = new System.Drawing.Size(128, 23);
            this.insertDeliveryInfoButton.TabIndex = 12;
            this.insertDeliveryInfoButton.Text = "Insert Delivery Info";
            this.insertDeliveryInfoButton.UseVisualStyleBackColor = true;
            this.insertDeliveryInfoButton.Click += new System.EventHandler(this.insertDeliveryInfoButton_Click);
            // 
            // deleteDeliveryInfoButton
            // 
            this.deleteDeliveryInfoButton.Location = new System.Drawing.Point(258, 228);
            this.deleteDeliveryInfoButton.Name = "deleteDeliveryInfoButton";
            this.deleteDeliveryInfoButton.Size = new System.Drawing.Size(128, 23);
            this.deleteDeliveryInfoButton.TabIndex = 13;
            this.deleteDeliveryInfoButton.Text = "Delete Delivery Info";
            this.deleteDeliveryInfoButton.UseVisualStyleBackColor = true;
            this.deleteDeliveryInfoButton.Click += new System.EventHandler(this.deleteDeliveryInfoButton_Click);
            // 
            // showCostsButton
            // 
            this.showCostsButton.Location = new System.Drawing.Point(392, 168);
            this.showCostsButton.Name = "showCostsButton";
            this.showCostsButton.Size = new System.Drawing.Size(75, 23);
            this.showCostsButton.TabIndex = 14;
            this.showCostsButton.Text = "Show costs";
            this.showCostsButton.UseVisualStyleBackColor = true;
            this.showCostsButton.Click += new System.EventHandler(this.showCostsButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(392, 197);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Insert cost";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(392, 228);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Delete costs";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 260);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.showCostsButton);
            this.Controls.Add(this.deleteDeliveryInfoButton);
            this.Controls.Add(this.insertDeliveryInfoButton);
            this.Controls.Add(this.showDeliveryInfoButton);
            this.Controls.Add(this.deleteItemButton);
            this.Controls.Add(this.inserItemButton);
            this.Controls.Add(this.deleteOrderButton);
            this.Controls.Add(this.InsertOrderButton);
            this.Controls.Add(this.showItemsBitton);
            this.Controls.Add(this.showOrdersButton);
            this.Controls.Add(this.DeleteUserButton);
            this.Controls.Add(this.InsertUserButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ShowUsersButton);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ShowUsersButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button InsertUserButton;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Button showOrdersButton;
        private System.Windows.Forms.Button showItemsBitton;
        private System.Windows.Forms.Button InsertOrderButton;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.Button inserItemButton;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button showDeliveryInfoButton;
        private System.Windows.Forms.Button insertDeliveryInfoButton;
        private System.Windows.Forms.Button deleteDeliveryInfoButton;
        private System.Windows.Forms.Button showCostsButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

