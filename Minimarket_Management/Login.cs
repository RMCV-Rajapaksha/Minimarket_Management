using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimarket_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(comboBox_role.SelectedIndex.ToString()=="admin")
            {
                string selectQuery = "SELECT * FROM Seller WHERE SellerName='" + textBox_username.Text + "' AND SellerPass='" + textBox_password.Text + "'";
                DataTable dt = new DataTable(); 
                sqlda
            }
           else
            {

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
