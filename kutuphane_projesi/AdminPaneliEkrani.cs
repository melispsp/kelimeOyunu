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
    public partial class AdminPaneliEkrani : Form
    {
        public AdminPaneliEkrani()
        {
            InitializeComponent();
        }

        private void btnGeriButonu_Click(object sender, EventArgs e)
        {
            AnaForm anaForm = new AnaForm();
            anaForm.Show();
            this.Close();
        }
    }
}
