using System.Windows.Forms;
using kutuphane_projesi;

namespace BilgiYarismasi
{
    public partial class AnaForm : Form
    {
        //field'lar
        private Form currentChildForm;

        public AnaForm()
        {
            InitializeComponent();
        }

        //form a�arken kullan�lan fonksiyon
        private void OpenMainChildForm(Form childForm)
        {
            btnAdminPaneli.Visible = false;
            btnBasla.Visible = false;
            btnCikis.Visible = false;
            btnSkorTablosu.Visible = false;
            lblOyunAdi.Visible = false;
            
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlAnaPanel.Controls.Add(childForm);
            pnlAnaPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //ba�la butonu t�klama fonksiyonu
        private void btnBasla_Click(object sender, EventArgs e)
        {
            OpenMainChildForm(new OyunEkrani());
        }

        //skor tablosu butonu t�klama fonksiyonu
        private void btnSkorTablosu_Click(object sender, EventArgs e)
        {
            OpenMainChildForm(new SkorTablosuEkrani());
        }

        //admin paneli butonu t�klama fonksiyonu
        private void btnAdminPaneli_Click(object sender, EventArgs e)
        {
            OpenMainChildForm(new AdminPaneliEkrani());
        }

        //��k�� butonu t�klama fonksiyonu
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
