using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilgiYarismasi;

namespace kutuphane_projesi
{
    public partial class SkorTablosuEkrani : Form
    {
        public SkorTablosuEkrani()
        {
            InitializeComponent();
        }

        private void SkorTablosuEkrani_Load(object sender, EventArgs e) //form yüklendiğinde skor tablosunu güncelleyecek.
        {

            //dbden takım adı, bilinen kelimeleri(admin doğru bastıkça kelime++) ve toplam puanı çekip labelların textini güncelleyecek.

        }

        private void btnGeriButonu_Click(object sender, EventArgs e)
        {
            AnaForm anaForm = new AnaForm();
            anaForm.Show();
            this.Close();
        }
    }
}
