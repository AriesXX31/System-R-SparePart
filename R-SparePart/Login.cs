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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text != "" && textBox_password.Text != "")
            {
                try
                {
                    //connection 
                    string myConnection = "datasource=localhost;port=3306;username=root;password=;SslMode=none";
                    MySqlConnection myConn = new MySqlConnection(myConnection);

                    MySqlCommand SelectCommand = new MySqlCommand("select * from rsparepart.rsp_admin where username_pengguna= '" + this.textBox_username.Text + "' and password_pengguna='" + this.textBox_password.Text + "' ;", myConn);
                    MySqlDataReader myReader;
                    myConn.Open();

                    myReader = SelectCommand.ExecuteReader();
                    int count = 0;
                    while (myReader.Read())
                    {
                        count = count + 1;
                    }
                    if (count == 1)
                    {
                        // MessageBox.Show("WELCOME");
                        AdminControl adm = new AdminControl();
                        adm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password...only for admin!");
                    }
                    myConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Required Username or Password!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //connection 
                string myConnection = "datasource=localhost;port=3306;username=root;password=;SslMode=none";    //initial database
                MySqlConnection myConn = new MySqlConnection(myConnection); //load mysqllibrary conection
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();    //create data adapter
                myDataAdapter.SelectCommand = new MySqlCommand("select * rsparepart.rsp_customer;", myConn);// sql syntax
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter); //build data adapter

                myConn.Open();// start connection
                DataSet ds = new DataSet();
                MessageBox.Show("Connected");
                myConn.Close();// end connection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text != "" && textBox_password.Text != "")
            {
                try
                {
                    //connection 
                    string myConnection = "datasource=localhost;port=3306;username=root;password=;SslMode=none";
                    MySqlConnection myConn = new MySqlConnection(myConnection);

                    MySqlCommand SelectCommand = new MySqlCommand("select * from rsparepart.rsp_customer where username_pelanggan= '" + this.textBox_username.Text + "' and password_pelanggan='" + this.textBox_password.Text + "' ;", myConn);
                    MySqlDataReader myReader;
                    myConn.Open();

                    myReader = SelectCommand.ExecuteReader();
                    int count = 0;
                    while (myReader.Read())
                    {
                        count = count + 1;
                    }
                    if (count == 1)
                    {
                        // MessageBox.Show("WELCOME");
                        this.Close();
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password...Only For Customer!");
                    }
                    myConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Required Username or Password!");
            }
        }

        private void button_regis_Click(object sender, EventArgs e)
        {
            Registration rgs = new Registration();
            rgs.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox_username_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
