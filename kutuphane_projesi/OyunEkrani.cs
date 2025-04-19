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
using MySql.Data.MySqlClient;
using Timer = System.Windows.Forms.Timer;

namespace kutuphane_projesi
{
    public partial class OyunEkrani : Form
    {
        //field'lar
        //sayac
        private int sure = 30; // soru süresi (30 saniye)
        private Timer timer;
        //db kelime harf
        private string kelime = "";  // Veritabanından gelen kelime
        private List<int> acilmamisIndexler = new List<int>(); // Açılmayan harf indeksleri
        private Random rnd = new Random();

        private string connStr = "Server=localhost;Database=kutuphane;Uid=root;Pwd=;";

        public OyunEkrani()
        {
            InitializeComponent();
            TimerOlustur();
            KelimeyiAl();
        }

        private void OyunEkrani_Load(object sender, EventArgs e) //öncki formda başla butonuna basıldığı anda sayaç başlar
        {
            sure = 30;
            lblSayac.Text = "00:30";
            timer.Start();
           
        }

        private void TimerOlustur()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            lblSayac.Text = "00:30"; //sayaçın başlangıçtaki süresi 30 saniye olarak tanımlı
        }
        private void KelimeyiAl()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT soruNo, soruMetni, soruCevap FROM sorular ORDER BY RAND() LIMIT 1;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int soruNo = reader.GetInt32("soruNo");
                        string soruMetni = reader.GetString("soruMetni");
                        kelime = reader.GetString("soruCevap").ToUpper();

                        // Soru metnini göster
                        lblIpucuMetni.Text = soruMetni;
                        lblIpucuMetni.Left = (this.ClientSize.Width - lblIpucuMetni.Width) / 2;

                        // Label ve PictureBox eşleştirmeleri
                        List<Label> labelListesi = new List<Label> { lblHarf1, lblHarf2, lblHarf3, lblHarf4, lblHarf5, lblHarf6, lblHarf7, lblHarf8, lblHarf9, lblHarf10 };
                        List<PictureBox> picListesi = new List<PictureBox> { pboxKutucuk1, pboxKutucuk2, pboxKutucuk3, pboxKutucuk4, pboxKutucuk5, pboxKutucuk6, pboxKutucuk7, pboxKutucuk8, pboxKutucuk9, pboxKutucuk10 };


                        // Kelimenin uzunluğu kadarını aç
                        for (int i = kelime.Length ; i <= 10; i++)
                        {
                            labelListesi[i].Visible = false;
                            picListesi[i].Visible = false;
                        }

                        // Açılmamış harflerin indexlerini hazırla
                        acilmamisIndexler = Enumerable.Range(0, kelime.Length).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Veritabanında soru bulunamadı!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }



        private void Timer_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSayac.Text = "00:" + sure.ToString("D2"); // 2 basamaklı gösterir (00:29, 00:28...)

            if (sure <= 0) //süre bittiğinde uyarı verip yeni soruya geçiyor. (karşı takıma geçmesi lazım aynı zamanda)
            {
                timer.Stop();
                MessageBox.Show(" Süre bitti. Sıra Diğer Takımda. ");
                sonrakiTakimHazirla();
                sonrakiSoruyuHazirla(); // yeni soruya geçiyor
            }
        }

        private void sonrakiSoruyuHazirla() //yeni soruya geçme fonksiyonu. süreyi sıfırlayıp db den ipucu, soru no, doğru cevap çekip puanı güncelleyecek
        {
            sure = 30; // süreyi sıfırlar
            lblSayac.Text = "00:30";
            timer.Start();
        }
        private void sonrakiTakimHazirla()
        {
            
        }

        private void btnGeriButonu_Click(object sender, EventArgs e)
        {
            AnaForm anaForm = new AnaForm();
            anaForm.Show();
            this.Close();
        }

        private void lblOnayla_Click(object sender, EventArgs e)
        {

        }

        private void lblHarfAl_Click(object sender, EventArgs e)
        {
            // Açılacak harf kalmadıysa çık
            if (acilmamisIndexler.Count == 0)
            {
                MessageBox.Show("Açılacak harf kalmadı!");
                return;
            }

            // Rastgele bir index seç
            int rastgeleIndex = rnd.Next(acilmamisIndexler.Count);
            int harfIndex = acilmamisIndexler[rastgeleIndex];

            // Harfi al
            char harf = kelime[harfIndex];

            // Doğru label'ı bul ve yaz
            List<Label> labelListesi = new List<Label> { lblHarf1, lblHarf2, lblHarf3, lblHarf4, lblHarf5, lblHarf6, lblHarf7, lblHarf8, lblHarf9, lblHarf10 };
            labelListesi[harfIndex].Text = harf.ToString();

            // Bu harfi tekrar açmamak için listeden çıkar
            acilmamisIndexler.RemoveAt(rastgeleIndex);
        }

    }

}
