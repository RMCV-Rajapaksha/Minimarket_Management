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

namespace Minimarket_Management
{
    public partial class ProductForm : Form
    {
        DBConnect bdCon = new DBConnect();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void getCategory()
        {
            string selectQuery = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuery, bdCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboBox_Category.DataSource = dt;
            comboBox_Category.ValueMember = "CatName";
            comboBox_Search.DataSource = dt;
            comboBox_Search.ValueMember = "CatName";
        }

        private void comboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();
        }

        private void getTable()
        {
            string selectQuery = "SELECT * FROM Product";
            SqlCommand command = new SqlCommand(selectQuery, bdCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView_product.DataSource = dt;
        }

        private void clean()
        {
            textBox_Id.Clear();
            textBox_Name.Clear();
            textBox_Price.Clear();
            textBox_Quantity.Clear();
            comboBox_Category.SelectedIndex=0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {



                {
                    string insertQuery = "INSERT INTO Product VALUES(" + textBox_Id.Text + ",'" + textBox_Name.Text + "','" + textBox_Price.Text + "','" + textBox_Quantity.Text + "','" + comboBox_Category.Text + "')";
                    SqlCommand cmd = new SqlCommand(insertQuery, bdCon.GetCon());
                    bdCon.openCon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("product Added Successfully");
                    bdCon.closeCon();
                    getTable();
                    clean();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Id.Text == "" || textBox_Name.Text == "" || textBox_Price.Text == "" || textBox_Quantity.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    string updateQuery = "UPDATE Product SET ProdName='" + textBox_Name.Text + "',ProdPrice='" + textBox_Price.Text + "', ProdQty='" + textBox_Quantity.Text + "', ProdCat='" + comboBox_Category.Text + "' WHERE ProdId=" + textBox_Id.Text + " ";
                    SqlCommand cmd = new SqlCommand(updateQuery, bdCon.GetCon());
                    bdCon.openCon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("product Update Successfully");
                    bdCon.closeCon();
                    getTable();
                    clean();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox_Id.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                { 
                string deleteQuery = "DELETE FROM Product WHERE ProdId='" + textBox_Id.Text + "'";
                SqlCommand cmd = new SqlCommand(deleteQuery, bdCon.GetCon());
                bdCon.openCon();
                cmd.ExecuteNonQuery();
                MessageBox.Show("product Deleted Successfully", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bdCon.closeCon();
                getTable();
                clean();
            }
            }
            catch
            (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void comboBox_Search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM Product WHERE ProdCat='"+comboBox_Search.SelectedValue.ToString()+"'";
            SqlCommand command = new SqlCommand(selectQuery, bdCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView_product.DataSource = dt;
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            Login  login = new Login();
            login.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }
    }
}
