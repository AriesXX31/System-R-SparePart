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
    public partial class ControlExpedition : Form
    {
        public ControlExpedition()
        {
            InitializeComponent();
        }

        private void Expedition_Load(object sender, EventArgs e)
        {
            ref_table();
        }

        public void ref_table()
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

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];

                textBox_idjasa.Text = row.Cells["id_jasa_ekspedisi"].Value.ToString();
                textBox_namaeks.Text = row.Cells["nama_ekspedisi"].Value.ToString();
                textBox_jenispengiriman.Text = row.Cells["jenis_pengiriman"].Value.ToString();
                textBox_hargaperkilogram.Text = row.Cells["harga_per_kilogram"].Value.ToString();
                textBox_rute.Text = row.Cells["rute"].Value.ToString();
                textBox_hargarute.Text = row.Cells["harga_per_rute"].Value.ToString();
                textBox_waktupengiriman.Text = row.Cells["waktu_pengiriman"].Value.ToString();
                textBox_kodepengiriman.Text = row.Cells["kode_pengiriman"].Value.ToString();
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
            textBox_idjasa.Clear();
            textBox_namaeks.Clear();
            textBox_jenispengiriman.Clear();
            textBox_hargaperkilogram.Clear();
            textBox_rute.Clear();
            textBox_hargarute.Clear();
            textBox_waktupengiriman.Clear();
            textBox_kodepengiriman.Clear();
        }

        private void button_updtdata_Click(object sender, EventArgs e)
        {
            if (textBox_idjasa.Text != ""
             && textBox_namaeks.Text != ""
             && textBox_jenispengiriman.Text != ""
             && textBox_hargaperkilogram.Text != ""
             && textBox_rute.Text != ""
             && textBox_hargarute.Text != ""
             && textBox_waktupengiriman.Text != ""
             && textBox_kodepengiriman.Text != "")
            {
                //connection 
                string myConnection = "datasource=localhost;port=3306;username=root;password=;SslMode=none";
                string Query = " UPDATE rsparepart.rsp_jasa_ekspedisi SET id_jasa_ekspedisi = '" + this.textBox_idjasa.Text + "', nama_ekspedisi = '" + this.textBox_namaeks.Text + "', jenis_pengiriman = '" + this.textBox_jenispengiriman.Text + "', harga_per_kilogram	= '" + this.textBox_hargaperkilogram.Text + "', rute	= '" + this.textBox_rute.Text + "', harga_per_rute	= '" + this.textBox_hargarute.Text + "', waktu_pengiriman	= '" + this.textBox_waktupengiriman.Text + "', kode_pengiriman	= '" + this.textBox_kodepengiriman.Text + "' WHERE id_jasa_ekspedisi= '" + this.textBox_idjasa.Text + "'; ";


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
                ref_table();
            }
            else
            {
                MessageBox.Show("Have Empty Text Field!");
            }
        }

        private void button_deletedata_Click(object sender, EventArgs e)
        {
            if (textBox_idjasa.Text != ""
             && textBox_namaeks.Text != ""
             && textBox_jenispengiriman.Text != ""
             && textBox_hargaperkilogram.Text != ""
             && textBox_rute.Text != ""
             && textBox_hargarute.Text != ""
             && textBox_waktupengiriman.Text != ""
             && textBox_kodepengiriman.Text != "")
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=;SslMode=none";
                string Query = " DELETE FROM rsparepart.rsp_jasa_ekspedisi  WHERE id_jasa_ekspedisi = '" + textBox_idjasa.Text + "'; ";


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
                ref_table();
            }
            else
            {
                MessageBox.Show("Have Empty Text Field! Check It Again...");
            }
        }

        private void button_insertekspedisi_Click(object sender, EventArgs e)
        {
            if (insertidjasa.Text != "" && insertnamaeks.Text != "" && insertjenispengiriman.Text != "" && inserthargaperkilo.Text != "" && insertrute.Text != "" && inserthargarute.Text != "" && insertwaktupengiriman.Text != "" && insertkodepengiriman.Text != "")
            {
                //connection 
                string myConnection = "datasource=localhost;port=3306;username=root;password=;SslMode=none";
                string Query = "insert into rsparepart.rsp_jasa_ekspedisi () values('','" + this.insertnamaeks.Text + "','" + this.insertjenispengiriman.Text + "','" + this.inserthargaperkilo.Text + "','" + this.insertrute.Text + "','" + this.inserthargarute.Text + "','" + this.insertwaktupengiriman.Text + "','" + this.insertkodepengiriman.Text + "');";
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
                ref_table();
            }
            else
            {
                MessageBox.Show("Have Empty Text Field!");
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            clearforminsert();
        }

        public void clearforminsert()
        {
            insertidjasa.Clear();
            insertnamaeks.Clear();
            insertjenispengiriman.Clear();
            inserthargaperkilo.Clear();
            insertrute.Clear();
            inserthargarute.Clear();
            insertwaktupengiriman.Clear();
            insertkodepengiriman.Clear();
        }

        private void textBox_idjasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_namaeks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
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

        private void textBox_hargaperkilogram_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_hargarute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_waktupengiriman_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
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

        private void insertidjasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void insertnamaeks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void insertjenispengiriman_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void inserthargaperkilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void inserthargarute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void insertwaktupengiriman_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void insertkodepengiriman_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_searchekspedisi_TextChanged(object sender, EventArgs e)
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
                DV.RowFilter = string.Format("nama_ekspedisi LIKE '%{0}%'", textBox_searchekspedisi.Text);
                dataGridView2.DataSource = DV;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
