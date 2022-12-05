
namespace R_SparePart
{
    partial class Transaction
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
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button_transactionsuccess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_searchtransaction = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(41, 61);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.RowTemplate.Height = 28;
            this.dataGridView4.Size = new System.Drawing.Size(1522, 551);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // button_transactionsuccess
            // 
            this.button_transactionsuccess.BackColor = System.Drawing.Color.MediumBlue;
            this.button_transactionsuccess.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_transactionsuccess.ForeColor = System.Drawing.Color.White;
            this.button_transactionsuccess.Location = new System.Drawing.Point(1202, 672);
            this.button_transactionsuccess.Name = "button_transactionsuccess";
            this.button_transactionsuccess.Size = new System.Drawing.Size(361, 91);
            this.button_transactionsuccess.TabIndex = 1;
            this.button_transactionsuccess.Text = "Transaction Success";
            this.button_transactionsuccess.UseVisualStyleBackColor = false;
            this.button_transactionsuccess.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search Kode Pengiriman";
            // 
            // textBox_searchtransaction
            // 
            this.textBox_searchtransaction.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_searchtransaction.Location = new System.Drawing.Point(296, 12);
            this.textBox_searchtransaction.Name = "textBox_searchtransaction";
            this.textBox_searchtransaction.Size = new System.Drawing.Size(544, 30);
            this.textBox_searchtransaction.TabIndex = 9;
            this.textBox_searchtransaction.TextChanged += new System.EventHandler(this.textBox_searchtransaction_TextChanged);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(1607, 827);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_searchtransaction);
            this.Controls.Add(this.button_transactionsuccess);
            this.Controls.Add(this.dataGridView4);
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button_transactionsuccess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_searchtransaction;
    }
}