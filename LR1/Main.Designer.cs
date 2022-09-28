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
            this.dataGridView1.Size = new System.Drawing.Size(399, 150);
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
            this.DeleteUserButton.Text = "Delete User";
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 260);
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
    }
}

