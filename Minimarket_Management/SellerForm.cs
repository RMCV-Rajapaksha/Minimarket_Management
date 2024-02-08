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
using System.Data.SqlClient;

namespace Minimarket_Management
{
    public partial class SellerForm : Form
    {
        DBConnect dbCon=new DBConnect();    
        public SellerForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void getTable()
        {
            string selectQuery = "SELECT * FROM Seller";
            SqlCommand command = new SqlCommand(selectQuery, dbCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView_product.DataSource = dt;
        }

        private void clear()
        {
            textBox_Id.Clear();
            textBox_Name.Clear();
            textBox_age.Clear();
            textBox_phone.Clear();
            textBox_pass.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {



                {
                    string insertQuery = "INSERT INTO Seller VALUES(" + textBox_Id.Text + ",'" + textBox_Name.Text + "','" + textBox_age.Text + "','" + textBox_phone.Text + "','" + textBox_pass.Text + "')";
                    SqlCommand cmd = new SqlCommand(insertQuery, dbCon.GetCon());
                    dbCon.openCon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Added Successfully");
                    dbCon.closeCon();
                   getTable();
                    clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {

            getTable();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox_Id.Text == "" || textBox_Name.Text == "" || textBox_age.Text == "" || textBox_phone.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Seller SET SellerName=@Name, SellerAge=@Age, SellerPhone=@Phone, SellerPass=@Pass WHERE SellerId=@Id";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, dbCon.GetCon()))
                    {
                        cmd.Parameters.AddWithValue("@Name", textBox_Name.Text);
                        cmd.Parameters.AddWithValue("@Age", textBox_age.Text);
                        cmd.Parameters.AddWithValue("@Phone", textBox_phone.Text);
                        cmd.Parameters.AddWithValue("@Pass", textBox_pass.Text);
                        cmd.Parameters.AddWithValue("@Id", textBox_Id.Text);

                        dbCon.openCon();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Seller Update Successfully");
                        dbCon.closeCon();
                        getTable();
                        clear();
                    }
                }
            }
            catch (Exception ex)
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

                    string deleteQuery = "DELETE FROM Seller WHERE SellerId='" + textBox_Id.Text + "'";
                    SqlCommand cmd = new SqlCommand(deleteQuery, dbCon.GetCon());
                    dbCon.openCon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dbCon.closeCon();
                    getTable();
                    clear();
                }
            }
            catch
            (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button_product_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.ShowDialog();
            this.Hide();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }
    }
}
