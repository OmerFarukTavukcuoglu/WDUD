using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WDUD
{
    public partial class KullaniciGirisForm : Form
    {
        public KullaniciGirisForm()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        AnasayfaForm AF = new AnasayfaForm();
       
        SqlBaglanti baglanti = new SqlBaglanti();
        public int id;

        int delay = 0;
        public void giris()
        {
            delay = 0;
            baglanti.Baglan();

            SqlCommand komut = new SqlCommand("select * from Kullanici_Tablo where Kullanici_Adi ='" + KullaniciAdTextBox.Text + "' and Sifre='" + SifreTextBox.Text + "'", baglanti.Baglan());

            SqlDataReader dataReader = komut.ExecuteReader();

            if (dataReader.Read())
            {
                id = Convert.ToInt32(dataReader[0]);
                AF.get_id = id;
                AF.KullaniciAdiLabel.Text = KullaniciAdTextBox.Text;
                this.Hide();
                AF.Show();
             }
            else
            {
                if (KullaniciAdTextBox.Text == "" || SifreTextBox.Text == "")
                {
                    //MessageBox.Show("Lütfen Alanları Doldurun!");
                    GirisLabel.Visible = true;
                    GirisLabel.Text = "Kullanıcı Adı Yada Şifre Hatalı! \nTekrar Deneyin.";
                    timer.Start();


                }
                else
                {
                    GirisLabel.Visible = true;
                    GirisLabel.Text = "Kullanıcı Adı Yada Şifre Hatalı! \nTekrar Deneyin.";
                    timer.Start();
                }
               // MessageBox.Show("Kullanıcı Adı Yada Şifre Hatalı! Tekrar Deneyin.", "HATALI GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GirisButon_Click(object sender, EventArgs e)
        {
            giris();                       
        }

        private void KullaniciGirisForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void KullaniciAdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                giris();
            }
        }

        private void SifreTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                giris();
            }
        }

        private void KullaniciGirisForm_Load(object sender, EventArgs e)
        {
            GirisLabel.Visible = false;
        }

        private void KapatLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HesapOlusturLabel_Click(object sender, EventArgs e)
        {
            KayıtOlForm KOF = new KayıtOlForm();
            KOF.Show();
            this.Hide();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            delay++;
            if (delay >= 3)
                GirisLabel.Visible = false;
        }
    }
}
