using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_form
{
    public partial class login : Form
    {
        public login()
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
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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
                txt_Password.UseSystemPasswordChar = false;
                txt_Password.ForeColor = SystemColors.GrayText;
            }
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if (txt_Password.Text == "Password")
            {
                txt_Password.Text = "";
                txt_Password.UseSystemPasswordChar = true;
                txt_Password.ForeColor = Color.White;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
