namespace BilgiYarismasi
{
    partial class AnaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            lblOyunAdi = new Label();
            btnBasla = new Button();
            btnSkorTablosu = new Button();
            btnAdminPaneli = new Button();
            btnCikis = new Button();
            pnlAnaPanel = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pnlAnaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblOyunAdi
            // 
            lblOyunAdi.AutoSize = true;
            lblOyunAdi.BackColor = Color.Transparent;
            lblOyunAdi.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOyunAdi.ForeColor = Color.Black;
            lblOyunAdi.Location = new Point(308, 72);
            lblOyunAdi.Name = "lblOyunAdi";
            lblOyunAdi.Size = new Size(485, 46);
            lblOyunAdi.TabIndex = 0;
            lblOyunAdi.Text = "KELİME TAHMİN OYUNU";
            // 
            // btnBasla
            // 
            btnBasla.BackColor = Color.WhiteSmoke;
            btnBasla.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            btnBasla.FlatAppearance.BorderSize = 2;
            btnBasla.FlatStyle = FlatStyle.Flat;
            btnBasla.Font = new Font("Arial", 12F);
            btnBasla.Location = new Point(425, 167);
            btnBasla.Margin = new Padding(3, 4, 3, 4);
            btnBasla.Name = "btnBasla";
            btnBasla.Size = new Size(250, 75);
            btnBasla.TabIndex = 1;
            btnBasla.Text = "Yarışmaya Başla";
            btnBasla.UseVisualStyleBackColor = false;
            btnBasla.Click += btnBasla_Click;
            // 
            // btnSkorTablosu
            // 
            btnSkorTablosu.BackColor = Color.WhiteSmoke;
            btnSkorTablosu.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            btnSkorTablosu.FlatAppearance.BorderSize = 2;
            btnSkorTablosu.FlatStyle = FlatStyle.Flat;
            btnSkorTablosu.Font = new Font("Arial", 12F);
            btnSkorTablosu.Location = new Point(425, 254);
            btnSkorTablosu.Margin = new Padding(3, 4, 3, 4);
            btnSkorTablosu.Name = "btnSkorTablosu";
            btnSkorTablosu.Size = new Size(250, 75);
            btnSkorTablosu.TabIndex = 2;
            btnSkorTablosu.Text = "Skor Tablosu";
            btnSkorTablosu.UseVisualStyleBackColor = false;
            btnSkorTablosu.Click += btnSkorTablosu_Click;
            // 
            // btnAdminPaneli
            // 
            btnAdminPaneli.BackColor = Color.WhiteSmoke;
            btnAdminPaneli.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            btnAdminPaneli.FlatAppearance.BorderSize = 2;
            btnAdminPaneli.FlatStyle = FlatStyle.Flat;
            btnAdminPaneli.Font = new Font("Arial", 12F);
            btnAdminPaneli.Location = new Point(425, 342);
            btnAdminPaneli.Margin = new Padding(3, 4, 3, 4);
            btnAdminPaneli.Name = "btnAdminPaneli";
            btnAdminPaneli.Size = new Size(250, 75);
            btnAdminPaneli.TabIndex = 3;
            btnAdminPaneli.Text = "Admin Paneli";
            btnAdminPaneli.UseVisualStyleBackColor = false;
            btnAdminPaneli.Click += btnAdminPaneli_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.WhiteSmoke;
            btnCikis.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            btnCikis.FlatAppearance.BorderSize = 2;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Arial", 12F);
            btnCikis.Location = new Point(425, 429);
            btnCikis.Margin = new Padding(3, 4, 3, 4);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(250, 75);
            btnCikis.TabIndex = 4;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // pnlAnaPanel
            // 
            pnlAnaPanel.BackColor = Color.White;
            pnlAnaPanel.BackgroundImage = (Image)resources.GetObject("pnlAnaPanel.BackgroundImage");
            pnlAnaPanel.BackgroundImageLayout = ImageLayout.Stretch;
            pnlAnaPanel.Controls.Add(pictureBox1);
            pnlAnaPanel.Controls.Add(pictureBox2);
            pnlAnaPanel.Controls.Add(btnCikis);
            pnlAnaPanel.Controls.Add(lblOyunAdi);
            pnlAnaPanel.Controls.Add(btnAdminPaneli);
            pnlAnaPanel.Controls.Add(btnBasla);
            pnlAnaPanel.Controls.Add(btnSkorTablosu);
            pnlAnaPanel.Dock = DockStyle.Fill;
            pnlAnaPanel.Location = new Point(0, 0);
            pnlAnaPanel.Name = "pnlAnaPanel";
            pnlAnaPanel.Size = new Size(1100, 670);
            pnlAnaPanel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(952, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(136, 144);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1100, 670);
            Controls.Add(pnlAnaPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AnaForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bilgi Yarışması";
            pnlAnaPanel.ResumeLayout(false);
            pnlAnaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblOyunAdi;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnSkorTablosu;
        private System.Windows.Forms.Button btnAdminPaneli;
        private System.Windows.Forms.Button btnCikis;
        private Panel pnlAnaPanel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
