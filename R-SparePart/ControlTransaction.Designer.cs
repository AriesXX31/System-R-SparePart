
namespace R_SparePart
{
    partial class ControlTransaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_searchtransaction = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox_jenispengiriman = new System.Windows.Forms.TextBox();
            this.textBox_idjasa = new System.Windows.Forms.TextBox();
            this.textBox_totalharga = new System.Windows.Forms.TextBox();
            this.textBox_jmlhbrg = new System.Windows.Forms.TextBox();
            this.textBox_namabrg = new System.Windows.Forms.TextBox();
            this.textBox_kodebrg = new System.Windows.Forms.TextBox();
            this.textBox_idproduk = new System.Windows.Forms.TextBox();
            this.textBox_alamatpelanggan = new System.Windows.Forms.TextBox();
            this.textBox_idtransaksi = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox_idpelanggan = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox_idpengguna = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_kodepengiriman = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_tglpemesanan = new System.Windows.Forms.TextBox();
            this.button_deletedata = new System.Windows.Forms.Button();
            this.button_updtdata = new System.Windows.Forms.Button();
            this.button_clearform = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 1050);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 43);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox_searchtransaction
            // 
            this.textBox_searchtransaction.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_searchtransaction.Location = new System.Drawing.Point(834, 20);
            this.textBox_searchtransaction.Name = "textBox_searchtransaction";
            this.textBox_searchtransaction.Size = new System.Drawing.Size(544, 30);
            this.textBox_searchtransaction.TabIndex = 4;
            this.textBox_searchtransaction.TextChanged += new System.EventHandler(this.textBox_searchtransaction_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(585, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search Kode Pengiriman";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(239, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1651, 179);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(767, 775);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(158, 23);
            this.label18.TabIndex = 85;
            this.label18.Text = "Jenis Pengiriman";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(771, 733);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(165, 23);
            this.label19.TabIndex = 84;
            this.label19.Text = "Id Jasa Ekspedisi";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(812, 691);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 23);
            this.label20.TabIndex = 83;
            this.label20.Text = "Total Harga";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(783, 649);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(140, 23);
            this.label21.TabIndex = 82;
            this.label21.Text = "Jumlah Barang";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(796, 607);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(130, 23);
            this.label22.TabIndex = 81;
            this.label22.Text = "Nama Barang";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(803, 568);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(125, 23);
            this.label23.TabIndex = 80;
            this.label23.Text = "Kode Barang";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(795, 523);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(95, 23);
            this.label24.TabIndex = 79;
            this.label24.Text = "Id Produk";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(761, 386);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(169, 23);
            this.label25.TabIndex = 78;
            this.label25.Text = "Alamat Pelanggan";
            // 
            // textBox_jenispengiriman
            // 
            this.textBox_jenispengiriman.BackColor = System.Drawing.Color.Black;
            this.textBox_jenispengiriman.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_jenispengiriman.ForeColor = System.Drawing.Color.White;
            this.textBox_jenispengiriman.Location = new System.Drawing.Point(952, 772);
            this.textBox_jenispengiriman.Name = "textBox_jenispengiriman";
            this.textBox_jenispengiriman.Size = new System.Drawing.Size(341, 30);
            this.textBox_jenispengiriman.TabIndex = 77;
            this.textBox_jenispengiriman.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_jenispengiriman_KeyPress);
            // 
            // textBox_idjasa
            // 
            this.textBox_idjasa.BackColor = System.Drawing.Color.Black;
            this.textBox_idjasa.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_idjasa.ForeColor = System.Drawing.Color.White;
            this.textBox_idjasa.Location = new System.Drawing.Point(952, 730);
            this.textBox_idjasa.Name = "textBox_idjasa";
            this.textBox_idjasa.Size = new System.Drawing.Size(123, 30);
            this.textBox_idjasa.TabIndex = 76;
            this.textBox_idjasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_idjasa_KeyPress);
            // 
            // textBox_totalharga
            // 
            this.textBox_totalharga.BackColor = System.Drawing.Color.Black;
            this.textBox_totalharga.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_totalharga.ForeColor = System.Drawing.Color.White;
            this.textBox_totalharga.Location = new System.Drawing.Point(952, 688);
            this.textBox_totalharga.Name = "textBox_totalharga";
            this.textBox_totalharga.Size = new System.Drawing.Size(341, 30);
            this.textBox_totalharga.TabIndex = 75;
            this.textBox_totalharga.TextChanged += new System.EventHandler(this.textBox_updatethnpem_TextChanged);
            this.textBox_totalharga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_totalharga_KeyPress);
            // 
            // textBox_jmlhbrg
            // 
            this.textBox_jmlhbrg.BackColor = System.Drawing.Color.Black;
            this.textBox_jmlhbrg.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_jmlhbrg.ForeColor = System.Drawing.Color.White;
            this.textBox_jmlhbrg.Location = new System.Drawing.Point(952, 646);
            this.textBox_jmlhbrg.Name = "textBox_jmlhbrg";
            this.textBox_jmlhbrg.Size = new System.Drawing.Size(341, 30);
            this.textBox_jmlhbrg.TabIndex = 74;
            this.textBox_jmlhbrg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_jmlhbrg_KeyPress);
            // 
            // textBox_namabrg
            // 
            this.textBox_namabrg.BackColor = System.Drawing.Color.Black;
            this.textBox_namabrg.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_namabrg.ForeColor = System.Drawing.Color.White;
            this.textBox_namabrg.Location = new System.Drawing.Point(952, 604);
            this.textBox_namabrg.Name = "textBox_namabrg";
            this.textBox_namabrg.Size = new System.Drawing.Size(341, 30);
            this.textBox_namabrg.TabIndex = 73;
            this.textBox_namabrg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_namabrg_KeyPress);
            // 
            // textBox_kodebrg
            // 
            this.textBox_kodebrg.BackColor = System.Drawing.Color.Black;
            this.textBox_kodebrg.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_kodebrg.ForeColor = System.Drawing.Color.White;
            this.textBox_kodebrg.Location = new System.Drawing.Point(952, 565);
            this.textBox_kodebrg.Name = "textBox_kodebrg";
            this.textBox_kodebrg.Size = new System.Drawing.Size(341, 30);
            this.textBox_kodebrg.TabIndex = 72;
            // 
            // textBox_idproduk
            // 
            this.textBox_idproduk.BackColor = System.Drawing.Color.Black;
            this.textBox_idproduk.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_idproduk.ForeColor = System.Drawing.Color.White;
            this.textBox_idproduk.Location = new System.Drawing.Point(952, 520);
            this.textBox_idproduk.Name = "textBox_idproduk";
            this.textBox_idproduk.Size = new System.Drawing.Size(123, 30);
            this.textBox_idproduk.TabIndex = 71;
            this.textBox_idproduk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_idproduk_KeyPress);
            // 
            // textBox_alamatpelanggan
            // 
            this.textBox_alamatpelanggan.BackColor = System.Drawing.Color.Black;
            this.textBox_alamatpelanggan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_alamatpelanggan.ForeColor = System.Drawing.Color.White;
            this.textBox_alamatpelanggan.Location = new System.Drawing.Point(952, 383);
            this.textBox_alamatpelanggan.Multiline = true;
            this.textBox_alamatpelanggan.Name = "textBox_alamatpelanggan";
            this.textBox_alamatpelanggan.Size = new System.Drawing.Size(341, 106);
            this.textBox_alamatpelanggan.TabIndex = 70;
            // 
            // textBox_idtransaksi
            // 
            this.textBox_idtransaksi.BackColor = System.Drawing.Color.Black;
            this.textBox_idtransaksi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_idtransaksi.ForeColor = System.Drawing.Color.White;
            this.textBox_idtransaksi.Location = new System.Drawing.Point(952, 254);
            this.textBox_idtransaksi.Name = "textBox_idtransaksi";
            this.textBox_idtransaksi.Size = new System.Drawing.Size(123, 30);
            this.textBox_idtransaksi.TabIndex = 69;
            this.textBox_idtransaksi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_idtransaksi_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(809, 257);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(117, 23);
            this.label26.TabIndex = 68;
            this.label26.Text = "Id Transaksi";
            // 
            // textBox_idpelanggan
            // 
            this.textBox_idpelanggan.BackColor = System.Drawing.Color.Black;
            this.textBox_idpelanggan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_idpelanggan.ForeColor = System.Drawing.Color.White;
            this.textBox_idpelanggan.Location = new System.Drawing.Point(952, 338);
            this.textBox_idpelanggan.Name = "textBox_idpelanggan";
            this.textBox_idpelanggan.Size = new System.Drawing.Size(123, 30);
            this.textBox_idpelanggan.TabIndex = 67;
            this.textBox_idpelanggan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_idpelanggan_KeyPress);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(803, 341);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(125, 23);
            this.label27.TabIndex = 66;
            this.label27.Text = "Id Pelanggan";
            // 
            // textBox_idpengguna
            // 
            this.textBox_idpengguna.BackColor = System.Drawing.Color.Black;
            this.textBox_idpengguna.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_idpengguna.ForeColor = System.Drawing.Color.White;
            this.textBox_idpengguna.Location = new System.Drawing.Point(952, 296);
            this.textBox_idpengguna.Name = "textBox_idpengguna";
            this.textBox_idpengguna.Size = new System.Drawing.Size(123, 30);
            this.textBox_idpengguna.TabIndex = 65;
            this.textBox_idpengguna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_idpengguna_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(807, 299);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(120, 23);
            this.label28.TabIndex = 64;
            this.label28.Text = "Id Pengguna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(768, 842);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 87;
            this.label2.Text = "Kode Pengiriman";
            // 
            // textBox_kodepengiriman
            // 
            this.textBox_kodepengiriman.BackColor = System.Drawing.Color.Black;
            this.textBox_kodepengiriman.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_kodepengiriman.ForeColor = System.Drawing.Color.White;
            this.textBox_kodepengiriman.Location = new System.Drawing.Point(952, 839);
            this.textBox_kodepengiriman.Name = "textBox_kodepengiriman";
            this.textBox_kodepengiriman.Size = new System.Drawing.Size(341, 30);
            this.textBox_kodepengiriman.TabIndex = 86;
            this.textBox_kodepengiriman.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_kodepengiriman_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(742, 884);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 23);
            this.label3.TabIndex = 89;
            this.label3.Text = "Tanggal Pemesanan ";
            // 
            // textBox_tglpemesanan
            // 
            this.textBox_tglpemesanan.BackColor = System.Drawing.Color.Black;
            this.textBox_tglpemesanan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tglpemesanan.ForeColor = System.Drawing.Color.White;
            this.textBox_tglpemesanan.Location = new System.Drawing.Point(952, 881);
            this.textBox_tglpemesanan.Name = "textBox_tglpemesanan";
            this.textBox_tglpemesanan.Size = new System.Drawing.Size(341, 30);
            this.textBox_tglpemesanan.TabIndex = 88;
            // 
            // button_deletedata
            // 
            this.button_deletedata.BackColor = System.Drawing.Color.Black;
            this.button_deletedata.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deletedata.ForeColor = System.Drawing.Color.White;
            this.button_deletedata.Location = new System.Drawing.Point(1173, 931);
            this.button_deletedata.Name = "button_deletedata";
            this.button_deletedata.Size = new System.Drawing.Size(217, 55);
            this.button_deletedata.TabIndex = 91;
            this.button_deletedata.Text = "Delete";
            this.button_deletedata.UseVisualStyleBackColor = false;
            this.button_deletedata.Click += new System.EventHandler(this.button_deletedata_Click);
            // 
            // button_updtdata
            // 
            this.button_updtdata.BackColor = System.Drawing.Color.Black;
            this.button_updtdata.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updtdata.ForeColor = System.Drawing.Color.White;
            this.button_updtdata.Location = new System.Drawing.Point(952, 931);
            this.button_updtdata.Name = "button_updtdata";
            this.button_updtdata.Size = new System.Drawing.Size(217, 55);
            this.button_updtdata.TabIndex = 90;
            this.button_updtdata.Text = "Update";
            this.button_updtdata.UseVisualStyleBackColor = false;
            this.button_updtdata.Click += new System.EventHandler(this.button_updatebarang_Click);
            // 
            // button_clearform
            // 
            this.button_clearform.BackColor = System.Drawing.Color.Black;
            this.button_clearform.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clearform.ForeColor = System.Drawing.Color.White;
            this.button_clearform.Location = new System.Drawing.Point(727, 931);
            this.button_clearform.Name = "button_clearform";
            this.button_clearform.Size = new System.Drawing.Size(217, 55);
            this.button_clearform.TabIndex = 92;
            this.button_clearform.Text = "Clear";
            this.button_clearform.UseVisualStyleBackColor = false;
            this.button_clearform.Click += new System.EventHandler(this.button_clearform_Click);
            // 
            // ControlTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.button_clearform);
            this.Controls.Add(this.button_deletedata);
            this.Controls.Add(this.button_updtdata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_tglpemesanan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_kodepengiriman);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.textBox_jenispengiriman);
            this.Controls.Add(this.textBox_idjasa);
            this.Controls.Add(this.textBox_totalharga);
            this.Controls.Add(this.textBox_jmlhbrg);
            this.Controls.Add(this.textBox_namabrg);
            this.Controls.Add(this.textBox_kodebrg);
            this.Controls.Add(this.textBox_idproduk);
            this.Controls.Add(this.textBox_alamatpelanggan);
            this.Controls.Add(this.textBox_idtransaksi);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.textBox_idpelanggan);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.textBox_idpengguna);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_searchtransaction);
            this.Controls.Add(this.panel1);
            this.Name = "ControlTransaction";
            this.Text = "ControlTransaction";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_searchtransaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox_jenispengiriman;
        private System.Windows.Forms.TextBox textBox_idjasa;
        private System.Windows.Forms.TextBox textBox_totalharga;
        private System.Windows.Forms.TextBox textBox_jmlhbrg;
        private System.Windows.Forms.TextBox textBox_namabrg;
        private System.Windows.Forms.TextBox textBox_kodebrg;
        private System.Windows.Forms.TextBox textBox_idproduk;
        private System.Windows.Forms.TextBox textBox_alamatpelanggan;
        private System.Windows.Forms.TextBox textBox_idtransaksi;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox_idpelanggan;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox_idpengguna;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_kodepengiriman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_tglpemesanan;
        private System.Windows.Forms.Button button_deletedata;
        private System.Windows.Forms.Button button_updtdata;
        private System.Windows.Forms.Button button_clearform;
    }
}