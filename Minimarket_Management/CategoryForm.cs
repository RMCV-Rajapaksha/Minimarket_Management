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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Minimarket_Management
{
    public partial class CategoryForm : Form
    {
        DBConnect bdCon = new DBConnect();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Categoty";
            SqlCommand command = new SqlCommand(selectQuerry, bdCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView_category.DataSource = dt;
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Category VALUES(" + textBox_Id.Text + ",'" + textBox_Name.Text + "','" + textBox_Description.Text + "')";
                SqlCommand cmd = new SqlCommand(insertQuery, bdCon.GetCon());
                bdCon.openCon();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                bdCon.closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getTable();
        }
    }
}
