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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text != "" && textBox_password.Text != "" && textBox_fullname.Text != "" && textBox_callnumber.Text != "" && textBox_address.Text != "" && textBox_identity.Text != "")
            {
                //connection 
                string myConnection = "datasource=localhost;port=3306;username=root;password=;SslMode=none";
                string Query = "insert into rsparepart.rsp_customer (id_pelanggan,username_pelanggan,password_pelanggan,nama_lengkap,nomor_telepon,alamat_pelanggan,nomor_ktp) values('','" + this.textBox_username.Text + "','" + this.textBox_password.Text + "','" + this.textBox_fullname.Text + "','" + this.textBox_callnumber.Text + "','" + this.textBox_address.Text + "','" + this.textBox_identity.Text + "');";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
                MySqlDataReader myReader;

                try
                {
                    myConn.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    MessageBox.Show("Registration Success... Thank You !");
                    textBox_username.Clear();
                    textBox_password.Clear();
                    textBox_fullname.Clear();
                    textBox_callnumber.Clear();
                    textBox_address.Clear();
                    textBox_identity.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Required Field!");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_fullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_callnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_address_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_identity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
