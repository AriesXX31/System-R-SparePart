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

namespace R_SparePart
{
    public partial class SubMenu : Form
    {
        public SubMenu()
        {
            InitializeComponent();
        }

        private void panel_content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SubMenu_Load(object sender, EventArgs e)
        {

        }

        private void button_products_Click(object sender, EventArgs e)
        {
            
        }

        private void button_customer_Click(object sender, EventArgs e)
        {
            panel_content.Controls.Clear();
            CustomerOrder csm = new CustomerOrder();
            csm.TopLevel = false;
            panel_content.Controls.Add(csm);
            csm.BringToFront();
            csm.Show();
        }

        private void button_expedition_Click(object sender, EventArgs e)
        {
            
        }

        private void button_transaction_Click(object sender, EventArgs e)
        {
            panel_content.Controls.Clear();
            Transaction trc = new Transaction();
            trc.TopLevel = false;
            panel_content.Controls.Add(trc);
            trc.BringToFront();
            trc.Show();
        }

        private void button_backmenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mm = new MainMenu();
            mm.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
