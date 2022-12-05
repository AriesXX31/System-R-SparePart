using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace R_SparePart
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel_runLoad.Width += 3;

            if (panel_runLoad.Width >= 740)
            {
                timer1.Stop();
                Login lgn = new Login();
                lgn.Show();
                this.Hide();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }

        private void panel_runLoad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
