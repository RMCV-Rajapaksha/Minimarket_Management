using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Minimarket_Management
{
    public partial class SellingForm : Form
    {
        DBConnect bBCon = new DBConnect();
        DGVPrinter printer = new DGVPrinter();
        public SellingForm()
        {
            InitializeComponent();
            getCategory();
            getSellTable();
        }

        private void getTable()
        {
            string selectQuery = "SELECT * FROM Bill";
            SqlCommand command = new SqlCommand(selectQuery, bBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView_sellList.DataSource = dt;
        }

        private void getSellTable()
        {
            string selectQuery = "SELECT ProdName, ProdPrice FROM Product";
            SqlCommand command = new SqlCommand(selectQuery, bBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;

        }



        private void getCategory()
        {
           
            string selectQuery = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuery, bBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboBox_Search.DataSource = dt;
            comboBox_Search.ValueMember = "CatName";
           
        }

        


        private void label3_Click(object sender, EventArgs e)
        {

        }

        int grandTotal = 0 , n=0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "" || textBox_quantity.Text == "")
            {
                MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int Total = Convert.ToInt32(textBox_price.Text) * Convert.ToInt32(textBox_quantity.Text);
                DataGridViewRow addRow = new DataGridViewRow();
                addRow.CreateCells(dataGridView_order);
                addRow.Cells[0].Value = ++n;
                addRow.Cells[1].Value = textBox_Name.Text;
                addRow.Cells[2].Value = textBox_price.Text;
                addRow.Cells[3].Value = textBox_quantity.Text;
                addRow.Cells[4].Value = Total;
                dataGridView_order.Rows.Add(addRow);
                grandTotal += Total;
                label_Amount.Text = "Rs" + grandTotal;
            }

        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            label_date.Text = DateTime.Today.ToShortDateString();
            getTable();
            getCategory();
            getSellTable();
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            textBox_Name.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            textBox_price.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void textBox_quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {

                {
                    string insertQuery = "INSERT INTO Bill VALUES(" + textBox_id.Text + ",'" + textBox_Name.Text + "','" + label_date.Text + "','" + grandTotal.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(insertQuery, bBCon.GetCon());
                    bBCon.openCon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Added Successfully");
                    bBCon.closeCon();
                    getTable();
                    //clean();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_Search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title = "Mdemy MiniMarket Sell Lists";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "foxlearn";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView_sellList);
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
