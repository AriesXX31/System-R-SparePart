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
    public partial class ControlTransaction : Form
    {
        public ControlTransaction()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            refresh_table();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        public void refresh_table()
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root; convert zero datetime=True ;password=;SslMode=none";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM rsparepart.rsp_data_transaksi;", myConn);
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox_updatethnpem_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_updatebarang_Click(object sender, EventArgs e)
        {
            if (textBox_idtransaksi.Text != ""
              && textBox_idpengguna.Text != ""
              && textBox_idpelanggan.Text != ""
              && textBox_alamatpelanggan.Text != ""
              && textBox_idproduk.Text != ""
              && textBox_kodebrg.Text != ""
              && textBox_namabrg.Text != ""
              && textBox_jmlhbrg.Text != ""
              && textBox_totalharga.Text != ""
              && textBox_idjasa.Text != ""
              && textBox_jenispengiriman.Text != ""
              && textBox_kodepengiriman.Text != ""
              && textBox_tglpemesanan.Text != "")
            {
                //connection 
                string myConnection = "datasource=localhost;port=3306;username=root;password=;SslMode=none";
                string Query = " UPDATE rsparepart.rsp_data_transaksi SET id_transaksi = '" + this.textBox_idtransaksi.Text + "', id_pengguna = '" + this.textBox_idpengguna.Text + "', id_pelanggan = '" + this.textBox_idpelanggan.Text + "', alamat_pelanggan	= '" + this.textBox_alamatpelanggan.Text + "', id_produk	= '" + this.textBox_idproduk.Text + "', kode_barang	= '" + this.textBox_kodebrg.Text + "', nama_barang	= '" + this.textBox_namabrg.Text + "', jumlah_barang	= '" + this.textBox_jmlhbrg.Text + "', total_harga	= '" + this.textBox_totalharga.Text + "', id_jasa_ekspedisi	= '" + this.textBox_idjasa.Text + "', jenis_pengiriman	= '" + this.textBox_jenispengiriman.Text + "', kode_pengiriman	= '" + this.textBox_kodepengiriman.Text + "', tgl_pemesanan	= '" + this.textBox_tglpemesanan.Text + "' WHERE id_transaksi= '" + this.textBox_idtransaksi.Text + "'; ";


                //string Query = "insert into phonebook.customer (customer_ID, customer_name,customer_phone) values('','" + this.textBox_name.Text + " ',' " + this.textBox_phone.Text + "');";

                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
                MySqlDataReader myReader;

                try
                {
                    myConn.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    MessageBox.Show("Product Updated Successfuly!");
                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                refresh_table();
            }
            else
            {
                MessageBox.Show("Have Empty Text Field!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                textBox_idtransaksi.Text = row.Cells["id_transaksi"].Value.ToString();
                textBox_idpengguna.Text = row.Cells["id_pengguna"].Value.ToString();
                textBox_idpelanggan.Text = row.Cells["id_pelanggan"].Value.ToString();
                textBox_alamatpelanggan.Text = row.Cells["alamat_pelanggan"].Value.ToString();
                textBox_idproduk.Text = row.Cells["id_produk"].Value.ToString();
                textBox_kodebrg.Text = row.Cells["kode_barang"].Value.ToString();
                textBox_namabrg.Text = row.Cells["nama_barang"].Value.ToString();
                textBox_jmlhbrg.Text = row.Cells["jumlah_barang"].Value.ToString();
                textBox_totalharga.Text = row.Cells["total_harga"].Value.ToString();
                textBox_idjasa.Text = row.Cells["id_jasa_ekspedisi"].Value.ToString();
                textBox_jenispengiriman.Text = row.Cells["jenis_pengiriman"].Value.ToString();
                textBox_kodepengiriman.Text = row.Cells["kode_pengiriman"].Value.ToString();
                textBox_tglpemesanan.Text = row.Cells["tgl_pemesanan"].Value.ToString();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_clearform_Click(object sender, EventArgs e)
        {
            clearform();
        }

        public void clearform()
        {
            textBox_idtransaksi.Clear();
            textBox_idpengguna.Clear();
            textBox_idpelanggan.Clear();
            textBox_alamatpelanggan.Clear();
            textBox_idproduk.Clear();
            textBox_kodebrg.Clear();
            textBox_namabrg.Clear();
            textBox_jmlhbrg.Clear();
            textBox_totalharga.Clear();
            textBox_idjasa.Clear();
            textBox_jenispengiriman.Clear();
            textBox_kodepengiriman.Clear();
            textBox_tglpemesanan.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_deletedata_Click(object sender, EventArgs e)
        {
            if (textBox_idtransaksi.Text != ""
              && textBox_idpengguna.Text != ""
              && textBox_idpelanggan.Text != ""
              && textBox_alamatpelanggan.Text != ""
              && textBox_idproduk.Text != ""
              && textBox_kodebrg.Text != ""
              && textBox_namabrg.Text != ""
              && textBox_jmlhbrg.Text != ""
              && textBox_totalharga.Text != ""
              && textBox_idjasa.Text != ""
              && textBox_jenispengiriman.Text != ""
              && textBox_kodepengiriman.Text != ""
              && textBox_tglpemesanan.Text != "")
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=;SslMode=none";
                string Query = " DELETE FROM rsparepart.rsp_data_transaksi  WHERE id_pelanggan = '" + textBox_idpelanggan.Text + "'; ";


                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
                MySqlDataReader myReader;

                try
                {
                    myConn.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    MessageBox.Show("Product Deleted Successfully!");
                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                refresh_table();
            }
            else
            {
                MessageBox.Show("Have Empty Text Field! Check It Again...");
            }
        }

        private void textBox_idtransaksi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_idpengguna_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_idpelanggan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_idproduk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_namabrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_jmlhbrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_totalharga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_idjasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_jenispengiriman_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_kodepengiriman_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_searchtransaction_TextChanged(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;convert zero datetime=True;password=;SslMode=none";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM rsparepart.rsp_data_transaksi;", myConn);
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
                DV.RowFilter = string.Format("kode_pengiriman LIKE '%{0}%'", textBox_searchtransaction.Text);
                dataGridView1.DataSource = DV;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
