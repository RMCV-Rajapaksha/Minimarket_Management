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
            string selectQuery = "SELECT * FROM Category";
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
                if (textBox_Id.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    string updateQuery = "UPDATE Seller SET SellerName='" + textBox_Name.Text + "',SellerAge='" + textBox_age.Text + "',SellerPhone='" + textBox_phone.Text + "'SellerPass='" + textBox_pass.Text + "' WHERE SellerId=" + textBox_Id.Text;
                    SqlCommand cmd = new SqlCommand(updateQuery, dbCon.GetCon());
                    dbCon.openCon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Update Successfully");
                    dbCon.closeCon();
                    getTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
