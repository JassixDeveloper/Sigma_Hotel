using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login_form
{
    public partial class signup : Form
    {        
        public signup()
        {
            InitializeComponent();
            txt_Username.ForeColor = SystemColors.GrayText;
            txt_Username.Text = "Username";
            this.txt_Username.Leave += new System.EventHandler(this.txt_Username_Leave);
            this.txt_Username.Enter += new System.EventHandler(this.txt_Username_Enter);
            txt_Password.ForeColor = SystemColors.GrayText;
            txt_Password.Text = "Password";
            this.txt_Password.Leave += new System.EventHandler(this.txt_Password_Leave);
            this.txt_Password.Enter += new System.EventHandler(this.txt_Password_Enter);
            txt_Email.ForeColor = SystemColors.GrayText;
            txt_Email.Text = "Email";
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            this.txt_Email.Enter += new System.EventHandler(this.txt_Email_Enter);            
        }

        private void txt_Username_Leave(object sender, EventArgs e)
        {
            if (txt_Username.Text.Length == 0)
            {
                txt_Username.Text = "Username";
                txt_Username.ForeColor = SystemColors.GrayText;
            }
        }

        private void txt_Username_Enter(object sender, EventArgs e)
        {
            if (txt_Username.Text == "Username")
            {
                txt_Username.Text = "";
                txt_Username.ForeColor = Color.White;
            }
        }
        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text.Length == 0)
            {
                txt_Password.Text = "Password";
                //txt_Password.PasswordChar = '*';
                txt_Password.ForeColor = SystemColors.GrayText;
            }
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if (txt_Password.Text == "Password")
            {
                txt_Password.Text = "";
                txt_Password.PasswordChar = '*';
                txt_Password.ForeColor = Color.White;
            }
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            if (txt_Email.Text.Length == 0)
            {
                txt_Email.Text = "Email";
                txt_Email.ForeColor = SystemColors.GrayText;
            }
        }

        private void txt_Email_Enter(object sender, EventArgs e)
        {
            if (txt_Email.Text == "Email")
            {
                txt_Email.Text = "";
                txt_Email.ForeColor = Color.White;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            if(txt_Username.Text == "Username" && txt_Password.Text == "Password" && txt_Email.Text == "Email")
            {                
                MessageBox.Show("Fill in all entry fields", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);                
            }           
            else
            {
                string connStr = "server=localhost;user=root;port=3306;password=mysql;";
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd;
                string s0;

                try
                {
                    conn.Open();
                    s0 = "CREATE DATABASE IF NOT EXISTS `sigma_hotel`;";
                    cmd = new MySqlCommand(s0, conn);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.ShowDialog();
        }
    }
}
