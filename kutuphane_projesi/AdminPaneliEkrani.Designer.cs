namespace kutuphane_projesi
{
    partial class AdminPaneliEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPaneliEkrani));
            panel1 = new Panel();
            btnGeriButonu = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnGeriButonu);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 670);
            panel1.TabIndex = 0;
            // 
            // btnGeriButonu
            // 
            btnGeriButonu.BackColor = Color.Transparent;
            btnGeriButonu.FlatAppearance.MouseOverBackColor = Color.DarkSlateBlue;
            btnGeriButonu.FlatStyle = FlatStyle.Flat;
            btnGeriButonu.ForeColor = Color.Gainsboro;
            btnGeriButonu.Location = new Point(988, 623);
            btnGeriButonu.Name = "btnGeriButonu";
            btnGeriButonu.Size = new Size(100, 35);
            btnGeriButonu.TabIndex = 25;
            btnGeriButonu.Text = "Geri";
            btnGeriButonu.UseVisualStyleBackColor = false;
            btnGeriButonu.Click += btnGeriButonu_Click;
            // 
            // AdminPaneliEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1100, 670);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPaneliEkrani";
            Text = "AdminPaneliEkrani";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnGeriButonu;
    }
}