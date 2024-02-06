namespace Minimarket_Management
{
    partial class SellingForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView_order = new System.Windows.Forms.DataGridView();
            this.button_update = new System.Windows.Forms.Button();
            this.comboBox_Search = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_add_order = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Logout_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_date = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.dataGridView_sellList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label_Amount = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sellList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(1063, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 41);
            this.label7.TabIndex = 22;
            this.label7.Text = "X";
            // 
            // dataGridView_order
            // 
            this.dataGridView_order.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdName,
            this.ProdPrice,
            this.ProdQty,
            this.Total});
            this.dataGridView_order.Location = new System.Drawing.Point(422, 112);
            this.dataGridView_order.Name = "dataGridView_order";
            this.dataGridView_order.RowHeadersWidth = 62;
            this.dataGridView_order.RowTemplate.Height = 28;
            this.dataGridView_order.Size = new System.Drawing.Size(675, 176);
            this.dataGridView_order.TabIndex = 19;
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_update.Location = new System.Drawing.Point(959, 407);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(128, 42);
            this.button_update.TabIndex = 18;
            this.button_update.Text = "Add";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // comboBox_Search
            // 
            this.comboBox_Search.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Italic);
            this.comboBox_Search.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBox_Search.FormattingEnabled = true;
            this.comboBox_Search.Location = new System.Drawing.Point(38, 366);
            this.comboBox_Search.Name = "comboBox_Search";
            this.comboBox_Search.Size = new System.Drawing.Size(199, 29);
            this.comboBox_Search.TabIndex = 17;
            this.comboBox_Search.Text = "Select Category";
            this.comboBox_Search.SelectedIndexChanged += new System.EventHandler(this.comboBox_Search_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(478, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 41);
            this.label6.TabIndex = 16;
            this.label6.Text = "SELLING";
            // 
            // button_refresh
            // 
            this.button_refresh.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_refresh.Location = new System.Drawing.Point(255, 358);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(121, 42);
            this.button_refresh.TabIndex = 15;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            // 
            // button_add_order
            // 
            this.button_add_order.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_order.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_add_order.Location = new System.Drawing.Point(151, 259);
            this.button_add_order.Name = "button_add_order";
            this.button_add_order.Size = new System.Drawing.Size(137, 42);
            this.button_add_order.TabIndex = 14;
            this.button_add_order.Text = "Add Order";
            this.button_add_order.UseVisualStyleBackColor = true;
            this.button_add_order.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(177, 113);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.ReadOnly = true;
            this.textBox_Name.Size = new System.Drawing.Size(199, 26);
            this.textBox_Name.TabIndex = 11;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(177, 161);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.ReadOnly = true;
            this.textBox_price.Size = new System.Drawing.Size(199, 26);
            this.textBox_price.TabIndex = 10;
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Location = new System.Drawing.Point(177, 205);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(199, 26);
            this.textBox_quantity.TabIndex = 9;
            this.textBox_quantity.TextChanged += new System.EventHandler(this.textBox_quantity_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(33, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Logout_button
            // 
            this.Logout_button.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Logout_button.Location = new System.Drawing.Point(6, 640);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(142, 42);
            this.Logout_button.TabIndex = 33;
            this.Logout_button.Text = "Logout";
            this.Logout_button.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(33, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label_Amount);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dataGridView_sellList);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dataGridView_order);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.comboBox_Search);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.button_add_order);
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Controls.Add(this.textBox_price);
            this.panel1.Controls.Add(this.textBox_quantity);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(156, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 703);
            this.panel1.TabIndex = 29;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_date.Location = new System.Drawing.Point(845, 81);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(69, 27);
            this.label_date.TabIndex = 23;
            this.label_date.Text = "Date";
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_delete.Location = new System.Drawing.Point(959, 644);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(128, 42);
            this.button_delete.TabIndex = 25;
            this.button_delete.Text = "Print";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // dataGridView_sellList
            // 
            this.dataGridView_sellList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_sellList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sellList.Location = new System.Drawing.Point(412, 453);
            this.dataGridView_sellList.Name = "dataGridView_sellList";
            this.dataGridView_sellList.RowHeadersWidth = 62;
            this.dataGridView_sellList.RowTemplate.Height = 28;
            this.dataGridView_sellList.Size = new System.Drawing.Size(675, 176);
            this.dataGridView_sellList.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(33, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(417, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 27);
            this.label8.TabIndex = 27;
            this.label8.Text = "Sells List";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(38, 426);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(338, 260);
            this.dataGridView2.TabIndex = 28;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // ProdId
            // 
            this.ProdId.HeaderText = "ProdId";
            this.ProdId.MinimumWidth = 8;
            this.ProdId.Name = "ProdId";
            this.ProdId.Width = 150;
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "ProdName";
            this.ProdName.MinimumWidth = 8;
            this.ProdName.Name = "ProdName";
            this.ProdName.Width = 150;
            // 
            // ProdPrice
            // 
            this.ProdPrice.HeaderText = "ProdPrice";
            this.ProdPrice.MinimumWidth = 8;
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Width = 150;
            // 
            // ProdQty
            // 
            this.ProdQty.HeaderText = "ProdQty";
            this.ProdQty.MinimumWidth = 8;
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.Width = 150;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(503, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 27);
            this.label9.TabIndex = 29;
            this.label9.Text = "Amount";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Amount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Amount.Location = new System.Drawing.Point(818, 338);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(48, 27);
            this.label_Amount.TabIndex = 30;
            this.label_Amount.Text = "Rs ";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(764, 416);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(177, 26);
            this.textBox_id.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(668, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 27);
            this.label10.TabIndex = 31;
            this.label10.Text = "BillIId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 27);
            this.label1.TabIndex = 33;
            this.label1.Text = "Seller Name";
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 694);
            this.Controls.Add(this.Logout_button);
            this.Controls.Add(this.panel1);
            this.Name = "SellingForm";
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sellList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView_order;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.ComboBox comboBox_Search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_add_order;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView_sellList;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_Amount;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
    }
}