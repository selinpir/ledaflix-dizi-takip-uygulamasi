namespace eheh
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Label3 = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Girisbtn = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LinkLabel1.Location = new System.Drawing.Point(530, 432);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(73, 23);
            this.LinkLabel1.TabIndex = 16;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Kayıt Ol";
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label3.Location = new System.Drawing.Point(360, 432);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(148, 23);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Hesabın yok mu ?";
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(12, 128);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(299, 378);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 14;
            this.PictureBox2.TabStop = false;
            // 
            // TextBox2
            // 
            this.TextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.TextBox2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBox2.Location = new System.Drawing.Point(477, 238);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(160, 31);
            this.TextBox2.TabIndex = 2;
            this.TextBox2.UseSystemPasswordChar = true;
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.TextBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBox1.Location = new System.Drawing.Point(477, 168);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(160, 31);
            this.TextBox1.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label1.Location = new System.Drawing.Point(317, 173);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(142, 26);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Kullanıcı Adı :";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(650, 96);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 10;
            this.PictureBox1.TabStop = false;
            // 
            // Girisbtn
            // 
            this.Girisbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.Girisbtn.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Girisbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Girisbtn.Location = new System.Drawing.Point(364, 320);
            this.Girisbtn.Name = "Girisbtn";
            this.Girisbtn.Size = new System.Drawing.Size(238, 79);
            this.Girisbtn.TabIndex = 9;
            this.Girisbtn.Text = "Giriş Yap";
            this.Girisbtn.UseVisualStyleBackColor = false;
            this.Girisbtn.Click += new System.EventHandler(this.Girisbtn_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label2.Location = new System.Drawing.Point(390, 243);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(69, 26);
            this.Label2.TabIndex = 17;
            this.Label2.Text = "Şifre :";
            // 
            // Giris
            // 
            this.AcceptButton = this.Girisbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(668, 518);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.LinkLabel1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Girisbtn);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LinkLabel1;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button Girisbtn;
        private System.Windows.Forms.Label Label2;
    }
}