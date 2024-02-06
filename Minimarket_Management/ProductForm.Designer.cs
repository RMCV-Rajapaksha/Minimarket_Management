namespace Minimarket_Management
{
    partial class ProductForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_product = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox_Search = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Logout_button = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.dataGridView_product);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.comboBox_Search);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox_Category);
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Controls.Add(this.textBox_Price);
            this.panel1.Controls.Add(this.textBox_Quantity);
            this.panel1.Controls.Add(this.textBox_Id);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(160, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 603);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView_product
            // 
            this.dataGridView_product.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_product.Location = new System.Drawing.Point(420, 132);
            this.dataGridView_product.Name = "dataGridView_product";
            this.dataGridView_product.RowHeadersWidth = 62;
            this.dataGridView_product.RowTemplate.Height = 28;
            this.dataGridView_product.Size = new System.Drawing.Size(486, 454);
            this.dataGridView_product.TabIndex = 19;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(759, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 42);
            this.button4.TabIndex = 18;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox_Search
            // 
            this.comboBox_Search.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Italic);
            this.comboBox_Search.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBox_Search.FormattingEnabled = true;
            this.comboBox_Search.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.comboBox_Search.Location = new System.Drawing.Point(516, 66);
            this.comboBox_Search.Name = "comboBox_Search";
            this.comboBox_Search.Size = new System.Drawing.Size(199, 29);
            this.comboBox_Search.TabIndex = 17;
            this.comboBox_Search.Text = "Select Category";
            this.comboBox_Search.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Search_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(276, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(426, 41);
            this.label6.TabIndex = 16;
            this.label6.Text = "MANAGE PRODUCTS ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(38, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Category.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.comboBox_Category.Location = new System.Drawing.Point(177, 246);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(199, 29);
            this.comboBox_Category.TabIndex = 12;
            this.comboBox_Category.Text = "Select Category";
            this.comboBox_Category.SelectedIndexChanged += new System.EventHandler(this.comboBox_Category_SelectedIndexChanged);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(177, 112);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(199, 26);
            this.textBox_Name.TabIndex = 11;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(177, 157);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(199, 26);
            this.textBox_Price.TabIndex = 10;
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Location = new System.Drawing.Point(177, 201);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(199, 26);
            this.textBox_Quantity.TabIndex = 9;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(177, 69);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(199, 26);
            this.textBox_Id.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(33, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Category";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(33, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(33, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(33, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // Logout_button
            // 
            this.Logout_button.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Logout_button.Location = new System.Drawing.Point(10, 540);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(142, 42);
            this.Logout_button.TabIndex = 22;
            this.Logout_button.Text = "Logout";
            this.Logout_button.UseVisualStyleBackColor = true;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Location = new System.Drawing.Point(10, 102);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 42);
            this.button5.TabIndex = 19;
            this.button5.Text = "Seller";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button6.Location = new System.Drawing.Point(10, 169);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 42);
            this.button6.TabIndex = 20;
            this.button6.Text = "Category";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button7.Location = new System.Drawing.Point(10, 239);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(142, 42);
            this.button7.TabIndex = 21;
            this.button7.Text = "Selling";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(161, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 42);
            this.button2.TabIndex = 14;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(283, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 42);
            this.button3.TabIndex = 15;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 594);
            this.Controls.Add(this.Logout_button);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox_Search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_product;
        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}