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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToLongTimeString();

            mainpanel.Controls.Clear();
            home h = new home();
            h.TopLevel = false;
            mainpanel.Controls.Add(h);
            h.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            home h = new home();
            h.TopLevel = false;
            mainpanel.Controls.Add(h);
            h.Show();
            top.Text = "Home";
            selectHome.BackColor = Color.White;
            selectClient.BackColor = Color.Transparent;
            selectRoom.BackColor = Color.Transparent;
            selectRsrv.BackColor = Color.Transparent;
            selectSetting.BackColor = Color.Transparent;
            selectLog.BackColor = Color.Transparent;
            selectExit.BackColor = Color.Transparent;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Client c = new Client();
            c.TopLevel = false;
            mainpanel.Controls.Add(c);
            c.Show();
            top.Text = "Client";
            selectHome.BackColor = Color.Transparent;
            selectClient.BackColor = Color.White;
            selectRoom.BackColor = Color.Transparent;
            selectRsrv.BackColor = Color.Transparent;
            selectSetting.BackColor = Color.Transparent;
            selectLog.BackColor = Color.Transparent;
            selectExit.BackColor = Color.Transparent;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Room r = new Room();
            r.TopLevel = false;
            mainpanel.Controls.Add(r);
            r.Show();
            top.Text = "Room";
            selectHome.BackColor = Color.Transparent;
            selectClient.BackColor = Color.Transparent;
            selectRoom.BackColor = Color.White;
            selectRsrv.BackColor = Color.Transparent;
            selectSetting.BackColor = Color.Transparent;
            selectLog.BackColor = Color.Transparent;
            selectExit.BackColor = Color.Transparent;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Reservation rs = new Reservation();
            rs.TopLevel = false;
            mainpanel.Controls.Add(rs);
            rs.Show();
            top.Text = "Reservation";
            top.Location = new Point(230, 17);
            selectHome.BackColor = Color.Transparent;
            selectClient.BackColor = Color.Transparent;
            selectRoom.BackColor = Color.Transparent;
            selectRsrv.BackColor = Color.White;
            selectSetting.BackColor = Color.Transparent;
            selectLog.BackColor = Color.Transparent;
            selectExit.BackColor = Color.Transparent;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            setting s = new setting();
            s.TopLevel = false;
            mainpanel.Controls.Add(s);
            s.Show();
            top.Text = "Setting";
            top.Location = new Point(260, 16);
            selectHome.BackColor = Color.Transparent;
            selectClient.BackColor = Color.Transparent;
            selectRoom.BackColor = Color.Transparent;
            selectRsrv.BackColor = Color.Transparent;
            selectSetting.BackColor = Color.White;
            selectLog.BackColor = Color.Transparent;
            selectExit.BackColor = Color.Transparent;            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
            selectHome.BackColor = Color.Transparent;
            selectClient.BackColor = Color.Transparent;
            selectRoom.BackColor = Color.Transparent;
            selectRsrv.BackColor = Color.Transparent;
            selectSetting.BackColor = Color.Transparent;
            selectLog.BackColor = Color.Transparent;
            selectExit.BackColor = Color.White;
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            selectHome.BackColor = Color.Transparent;
            selectClient.BackColor = Color.Transparent;
            selectRoom.BackColor = Color.Transparent;
            selectRsrv.BackColor = Color.Transparent;
            selectSetting.BackColor = Color.Transparent;
            selectLog.BackColor = Color.White;
            selectExit.BackColor = Color.Transparent;
        }
    }
}
