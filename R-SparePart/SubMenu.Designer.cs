
namespace R_SparePart
{
    partial class SubMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_customer = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button_backmenu = new System.Windows.Forms.Button();
            this.button_transaction = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_content = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.button_customer);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button_backmenu);
            this.panel1.Controls.Add(this.button_transaction);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 1050);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button_customer
            // 
            this.button_customer.BackColor = System.Drawing.Color.Lime;
            this.button_customer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_customer.ForeColor = System.Drawing.Color.Black;
            this.button_customer.Location = new System.Drawing.Point(0, 81);
            this.button_customer.Name = "button_customer";
            this.button_customer.Size = new System.Drawing.Size(201, 71);
            this.button_customer.TabIndex = 2;
            this.button_customer.Text = "Customer Order";
            this.button_customer.UseVisualStyleBackColor = false;
            this.button_customer.Click += new System.EventHandler(this.button_customer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 654);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 585);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(12, 645);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 48);
            this.button6.TabIndex = 6;
            this.button6.Text = "Log Out";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_backmenu
            // 
            this.button_backmenu.BackColor = System.Drawing.Color.Silver;
            this.button_backmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_backmenu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_backmenu.ForeColor = System.Drawing.Color.Black;
            this.button_backmenu.Location = new System.Drawing.Point(12, 576);
            this.button_backmenu.Name = "button_backmenu";
            this.button_backmenu.Size = new System.Drawing.Size(172, 48);
            this.button_backmenu.TabIndex = 5;
            this.button_backmenu.Text = "Menu";
            this.button_backmenu.UseVisualStyleBackColor = false;
            this.button_backmenu.Click += new System.EventHandler(this.button_backmenu_Click);
            // 
            // button_transaction
            // 
            this.button_transaction.BackColor = System.Drawing.Color.Yellow;
            this.button_transaction.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_transaction.ForeColor = System.Drawing.Color.Black;
            this.button_transaction.Location = new System.Drawing.Point(0, 168);
            this.button_transaction.Name = "button_transaction";
            this.button_transaction.Size = new System.Drawing.Size(201, 71);
            this.button_transaction.TabIndex = 4;
            this.button_transaction.Text = "Transaction";
            this.button_transaction.UseVisualStyleBackColor = false;
            this.button_transaction.Click += new System.EventHandler(this.button_transaction_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 43);
            this.panel2.TabIndex = 0;
            // 
            // panel_content
            // 
            this.panel_content.BackColor = System.Drawing.Color.Silver;
            this.panel_content.Location = new System.Drawing.Point(249, 41);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(1629, 883);
            this.panel_content.TabIndex = 1;
            this.panel_content.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_content_Paint);
            // 
            // SubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.panel1);
            this.Name = "SubMenu";
            this.Text = "SubMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SubMenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_transaction;
        private System.Windows.Forms.Button button_customer;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button_backmenu;
        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}