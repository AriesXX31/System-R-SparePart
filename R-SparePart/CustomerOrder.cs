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
    public partial class CustomerOrder : Form
    {
        public CustomerOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            refcus_table();
            refjasa_table();
            refproduct_table();
            refadmin_table();
        }

        public void refcus_table()
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root; convert zero datetime=True ;password= ;SslMode=none";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT rsp_customer.id_pelanggan, rsp_customer.username_pelanggan, rsp_customer.nama_lengkap, rsp_customer.alamat_pelanggan FROM rsparepart.rsp_customer;", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView3.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void refjasa_table()
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root; convert zero datetime=True ;password= ;SslMode=none";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM rsparepart.rsp_jasa_ekspedisi;", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView2.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void refproduct_table()
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=;SslMode=none";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("select * from rsparepart.rsp_produk_onderdil;", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void refadmin_table()
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=;SslMode=none";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("select rsp_admin.id_pengguna, rsp_admin.username_pengguna, rsp_admin.level_pengguna, rsp_admin.email_pengguna FROM rsparepart.rsp_admin;", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView4.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView3.Rows[e.RowIndex];
                label_idpelanggan.Text = row.Cells["id_pelanggan"].Value.ToString();
                label_alamatpelanggan.Text = row.Cells["alamat_pelanggan"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=;SslMode=none";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM rsparepart.rsp_customer;", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView3.DataSource = bSource;
                sda.Update(dbdataset);

                DataView DV = new DataView(dbdataset);
                DV.RowFilter = string.Format("nama_lengkap LIKE '%{0}%'", textBox_searchcustomers.Text);
                dataGridView3.DataSource = DV;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=;SslMode=none";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM rsparepart.rsp_produk_onderdil;", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

                DataView DV = new DataView(dbdataset);
                DV.RowFilter = string.Format("nama_barang LIKE '%{0}%'", textBox_searchproducts.Text);
                dataGridView1.DataSource = DV;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_searchexpedition_TextChanged(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=;SslMode=none";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM rsparepart.rsp_jasa_ekspedisi;", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView2.DataSource = bSource;
                sda.Update(dbdataset);

                DataView DV = new DataView(dbdataset);
                DV.RowFilter = string.Format("nama_ekspedisi LIKE '%{0}%'", textBox_searchexpedition.Text);
                dataGridView2.DataSource = DV;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                label_idproduk.Text = row.Cells["id_produk"].Value.ToString();
                label_kodebarang.Text = row.Cells["kode_barang"].Value.ToString();
                label_namabarang.Text = row.Cells["nama_barang"].Value.ToString();
                label_hargabarang.Text = row.Cells["harga_barang"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int total = 0;

                //count total
                total = Convert.ToInt32(numericUpDown_jumlahbarang.Value) * Convert.ToInt32(label_hargabarang.Text) + (Convert.ToInt32(label_hargaperkilo.Text) + Convert.ToInt32(label_hargarute.Text));
                label_totalharga.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                label_idjasaekspedisi.Text = row.Cells["id_jasa_ekspedisi"].Value.ToString();
                label_jenispengiriman.Text = row.Cells["jenis_pengiriman"].Value.ToString();
                label_kodepengiriman.Text = row.Cells["kode_pengiriman"].Value.ToString();
                label_hargaperkilo.Text = row.Cells["harga_per_kilogram"].Value.ToString();
                label_hargarute.Text = row.Cells["harga_per_rute"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;convert zero datetime=True;password=;SslMode=none";

            string Query = "INSERT INTO rsparepart.rsp_data_transaksi (id_transaksi, id_pengguna,  id_pelanggan, alamat_pelanggan, id_produk, kode_barang, nama_barang, jumlah_barang, total_harga, id_jasa_ekspedisi, jenis_pengiriman, kode_pengiriman)  VALUES(NULL, '" + label_idpengguna.Text + "','" + label_idpelanggan.Text + "','" + label_alamatpelanggan.Text + "', '" + label_idproduk.Text + "', '" + label_kodebarang.Text + "', '" + label_namabarang.Text + "', '" + numericUpDown_jumlahbarang.Value + "', '" + label_totalharga.Text + "', '" + label_idjasaekspedisi.Text + "', '" + label_jenispengiriman.Text + "', '" + label_kodepengiriman.Text + "');";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Thank You For Ordering!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView4.Rows[e.RowIndex];
                label_idpengguna.Text = row.Cells["id_pengguna"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_searchadmin_TextChanged(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=;SslMode=none";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM rsparepart.rsp_admin;", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView4.DataSource = bSource;
                sda.Update(dbdataset);

                DataView DV = new DataView(dbdataset);
                DV.RowFilter = string.Format("username_pengguna LIKE '%{0}%'", textBox_searchadmin.Text);
                dataGridView4.DataSource = DV;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
