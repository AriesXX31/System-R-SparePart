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
    public partial class AdminControl : Form
    {
        public AdminControl()
        {
            InitializeComponent();
        }

        private void AdminControl_Load(object sender, EventArgs e)
        {
            refproduct_table();
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


        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_idproduk.Text != "" && textBox_kodebrg.Text != "" && textBox_nmrseri.Text !="" && textBox_namabrg.Text !="" && textBox_merkbrg.Text !="" && textBox_hargabrg.Text !="" && textBox_satuan.Text !="" && textBox_warna.Text !="" && textBox_thnpem.Text !="" && textBox_ratapem.Text !="" && textBox_jenismobil.Text !="" && richTextBox_deskripsi.Text !="" && textBox_garansi.Text !="" && textBox_stokbarang.Text !="")
            {
                //connection 
                string myConnection = "datasource=localhost;port=3306;username=root;password=;SslMode=none";
                string Query = "insert into rsparepart.rsp_produk_onderdil () values('','" + this.textBox_kodebrg.Text + "','" + this.textBox_nmrseri.Text + "','" + this.textBox_namabrg.Text + "','" + this.textBox_merkbrg.Text + "','" + this.textBox_hargabrg.Text + "','" + this.textBox_satuan.Text + "','" + this.textBox_warna.Text + "','" + this.textBox_thnpem.Text + "','" + this.textBox_ratapem.Text + "','" + this.textBox_jenismobil.Text + "','" + this.richTextBox_deskripsi.Text + "','" + this.textBox_garansi.Text + "','" + this.textBox_stokbarang.Text + "');";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
                MySqlDataReader myReader;

                try
                {
                    myConn.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    MessageBox.Show("Product Inserted Successfully!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                refproduct_table();
            }
            else
            {
                MessageBox.Show("Have Empty Text Field!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_updatebarang_Click(object sender, EventArgs e)
        {

            if (textBox_updateid.Text != ""
                && textBox_updatekodebarang.Text != ""
                && textBox_updatenomor.Text != ""
                && textBox_updatenamabarang.Text != ""
                && textBox_updatemerekbarang.Text != ""
                && textBox_updatehargabarang.Text != ""
                && textBox_updatesatuan.Text != ""
                && textBox_updatewarna.Text != ""
                && textBox_updatethnpem.Text != ""
                && textBox_updaterata.Text != ""
                && textBox_updatejnsmobil.Text != ""
                && richTextBox_desc.Text != ""
                && textBox_updategaransi.Text != ""
                && textBox_updatestok.Text != "")
            {
                //connection 
                string myConnection = "datasource=localhost;port=3306;username=root;password=;SslMode=none";
                string Query = " UPDATE rsparepart.rsp_produk_onderdil SET kode_barang = '" + this.textBox_updatekodebarang.Text + "', nomor_seri = '" + this.textBox_updatenomor.Text + "', nama_barang	= '" + this.textBox_updatenamabarang.Text + "', merek_barang	= '" + this.textBox_updatemerekbarang.Text + "', harga_barang	= '" + this.textBox_updatehargabarang.Text + "', satuan	= '" + this.textBox_updatesatuan.Text + "', warna	= '" + this.textBox_updatewarna.Text + "', tahun_pembuatan	= '" + this.textBox_updatethnpem.Text + "', rata_pemakaian	= '" + this.textBox_updaterata.Text + "', jenis_mobil	= '" + this.textBox_updatejnsmobil.Text + "', deskripsi_barang	= '" + this.richTextBox_desc.Text + "', garansi	= '" + this.textBox_updategaransi.Text + "', stok_barang	= '" + this.textBox_updatestok.Text + "' WHERE id_produk= '" + this.textBox_updateid.Text + "'; ";


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
                refproduct_table();
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

                textBox_updateid.Text = row.Cells["id_produk"].Value.ToString();
                textBox_updatekodebarang.Text = row.Cells["kode_barang"].Value.ToString();
                textBox_updatenomor.Text = row.Cells["nomor_seri"].Value.ToString();
                textBox_updatenamabarang.Text = row.Cells["nama_barang"].Value.ToString();
                textBox_updatemerekbarang.Text = row.Cells["merek_barang"].Value.ToString();
                textBox_updatehargabarang.Text = row.Cells["harga_barang"].Value.ToString();
                textBox_updatesatuan.Text = row.Cells["satuan"].Value.ToString();
                textBox_updatewarna.Text = row.Cells["warna"].Value.ToString();
                textBox_updatethnpem.Text = row.Cells["tahun_pembuatan"].Value.ToString();
                textBox_updaterata.Text = row.Cells["rata_pemakaian"].Value.ToString();
                textBox_updatejnsmobil.Text = row.Cells["jenis_mobil"].Value.ToString();
                richTextBox_desc.Text = row.Cells["deskripsi_barang"].Value.ToString();
                textBox_updategaransi.Text = row.Cells["garansi"].Value.ToString();
                textBox_updatestok.Text = row.Cells["stok_barang"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_deletebarang_Click(object sender, EventArgs e)
        {
            if (textBox_updateid.Text != ""
               && textBox_updatekodebarang.Text != ""
               && textBox_updatenomor.Text != ""
               && textBox_updatenamabarang.Text != ""
               && textBox_updatemerekbarang.Text != ""
               && textBox_updatehargabarang.Text != ""
               && textBox_updatesatuan.Text != ""
               && textBox_updatewarna.Text != ""
               && textBox_updatethnpem.Text != ""
               && textBox_updaterata.Text != ""
               && textBox_updatejnsmobil.Text != ""
               && richTextBox_desc.Text != ""
               && textBox_updategaransi.Text != ""
               && textBox_updatestok.Text != "")
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=;SslMode=none";
                string Query = " DELETE FROM rsparepart.rsp_produk_onderdil  WHERE nama_barang = '" + textBox_updatenamabarang.Text + "'; ";


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
                refproduct_table();
            }
            else
            {
                MessageBox.Show("Have Empty Text Field! Check It Again...");
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            textBox_updateid.Clear();
            textBox_updatekodebarang.Clear();
            textBox_updatenomor.Clear();
            textBox_updatenamabarang.Clear();
            textBox_updatemerekbarang.Clear();
            textBox_updatehargabarang.Clear();
            textBox_updatesatuan.Clear();
            textBox_updatewarna.Clear();
            textBox_updatethnpem.Clear();
            textBox_updaterata.Clear();
            textBox_updatejnsmobil.Clear();
            richTextBox_desc.Clear();
            textBox_updategaransi.Clear();
            textBox_updatestok.Clear();
        }

        private void textBox_updateid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_idproduk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_kodebrg_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox_namabrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox_nmrseri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_merkbrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_hargabrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_satuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_warna_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_thnpem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_ratapem_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox_jenismobil_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void richTextBox_deskripsi_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox_garansi_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox_stokbarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clearform();
        }

        public void clearform()
        {
            textBox_idproduk.Clear();
            textBox_kodebrg.Clear();
            textBox_nmrseri.Clear();
            textBox_namabrg.Clear();
            textBox_merkbrg.Clear();
            textBox_hargabrg.Clear();
            textBox_satuan.Clear();
            textBox_warna.Clear();
            textBox_thnpem.Clear();
            textBox_ratapem.Clear();
            textBox_jenismobil.Clear();
            richTextBox_deskripsi.Clear();
            textBox_garansi.Clear();
            textBox_stokbarang.Clear();
        }

        private void textBox_updateid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_updatenomor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_updatenamabarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox_updatemerekbarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_updatehargabarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_updatesatuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_updatewarna_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_updatethnpem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_updaterata_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox_updatejnsmobil_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox_updategaransi_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox_updatestok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_updatedata_Click(object sender, EventArgs e)
        {
            ControlTransaction controlTr = new ControlTransaction();
            controlTr.Show();
        }

        private void button_dataekspedisi_Click(object sender, EventArgs e)
        {
            
            ControlExpedition ex = new ControlExpedition();
            ex.Show();
        }

        private void textBox_searchproducts_TextChanged(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_garansi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
