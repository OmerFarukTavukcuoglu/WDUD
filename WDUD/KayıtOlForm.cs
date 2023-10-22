using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace WDUD
{
    public partial class KayıtOlForm : Form
    {
        public KayıtOlForm()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();
        Random rsayi = new Random();
        int sayi = 0;
        private void Captcha()
        {
             
            sayi = rsayi.Next(100000, 111111);
            var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("TimesNewRoman", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(sayi.ToString(), font, Brushes.White, new Point(0, 0));
            pictureBox1.Image = image;
        }
        private void KayıtOlForm_Load(object sender, EventArgs e)
        {
            BallGifPictureBox.Visible = false;
            KayıtBasariliLabel.Visible = false;
            KayıtBasariliTimer.Interval = 50;
            Captcha();
        }
        System.Drawing.Color renk = System.Drawing.ColorTranslator.FromHtml("#B4B4B4");

        string regularexpression = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        void  Kontrol()
        {
 
            #region textboxKontrol
             if (KullaniciAdTextBox.Text == string.Empty)
               KullaniciAdTextBox.LineIdleColor = Color.Red;
             else
             KullaniciAdTextBox.LineIdleColor = renk; 

             if (SifreTextBox.Text == string.Empty)
                SifreTextBox.LineIdleColor = Color.Red;
             else
            {
                SifreTextBox.LineIdleColor = renk;
                if (SifreTextBox.Text != SifreTekrarTextBox.Text)
                {
                    SifreTextBox.LineIdleColor = Color.Red;
                    SifreTekrarTextBox.LineIdleColor = Color.Red;
                }
                else
                {
                    SifreTextBox.LineIdleColor = renk;
                    SifreTekrarTextBox.LineIdleColor = renk;
                }
            }
               
             if (SifreTekrarTextBox.Text == string.Empty)
                SifreTekrarTextBox.LineIdleColor = Color.Red;   
             else
            {
                SifreTekrarTextBox.LineIdleColor = renk;
                if (SifreTextBox.Text != SifreTekrarTextBox.Text)
                {
                    SifreTextBox.LineIdleColor = Color.Red;
                    SifreTekrarTextBox.LineIdleColor = Color.Red;
                }
                else
                {
                    SifreTextBox.LineIdleColor = renk;
                    SifreTekrarTextBox.LineIdleColor = renk;
                }
            }
               

             

             if (sayi.ToString() != CaptchaTextBox.Text)
                CaptchaTextBox.LineIdleColor = Color.Red; 
             else
                CaptchaTextBox.LineIdleColor = renk;
            
                if (Regex.IsMatch(MailAdresTextBox.Text, regularexpression)) { MailAdresTextBox.LineIdleColor = renk;  }
                else
                MailAdresTextBox.LineIdleColor = Color.Red;



            #endregion


        }
        bool kayitvarmi = false;
        bool butonaktif = false;
        private void GirisButon_Click(object sender, EventArgs e)
        {
            butonaktif = true;
            Kontrol();

               if (KullaniciAdTextBox.Text != string.Empty && SifreTextBox.Text != string.Empty && SifreTekrarTextBox.Text != string.Empty &&
                 SifreTekrarTextBox.Text == SifreTekrarTextBox.Text && (sayi.ToString() == CaptchaTextBox.Text && MailAdresTextBox.Text != string.Empty))
              {

                SqlCommand oku = new SqlCommand("SELECT* FROM Kullanici_Tablo",baglanti.Baglan());
                SqlDataReader dr = oku.ExecuteReader();
                while(dr.Read())
                {
                    /*if (dr[1].ToString() != KullaniciAdTextBox.Text)
                    {
                        kayitvarmi = false;
                    }*/

                    if (dr[1].ToString() == KullaniciAdTextBox.Text)
                    {
                        kayitvarmi = true;
                    }
                    else
                        kayitvarmi = false;
                    
                }
                if(kayitvarmi == false)
                {
                       SqlCommand kullaniciEkle = new SqlCommand("INSERT INTO Kullanici_Tablo(Kullanici_Adi,Sifre,Mail,Okunan_Kitap_Sayisi,Ögrenilen_Kelime_Sayisi,Olusturulan_Günlük_Aktivite_Sayisi,Olusturulan_Yapilacaklar_Listesi_Sayisi,Programa_Baslangic_Tarihi)" +
                       "Values(@kullanici_ad,@sifre,@mail,@okunankitap,@ögrenilenkelime,@günlükaktivite,@yapilacaklarlistesi,@baslangictarihi)", baglanti.Baglan());
                       kullaniciEkle.Parameters.AddWithValue("@kullanici_ad", KullaniciAdTextBox.Text);
                       kullaniciEkle.Parameters.AddWithValue("@sifre", SifreTextBox.Text);
                       kullaniciEkle.Parameters.AddWithValue("@mail", MailAdresTextBox.Text);
                       kullaniciEkle.Parameters.AddWithValue("@okunankitap", 0);
                       kullaniciEkle.Parameters.AddWithValue("@ögrenilenkelime", 0);
                       kullaniciEkle.Parameters.AddWithValue("@günlükaktivite", 0);
                       kullaniciEkle.Parameters.AddWithValue("@yapilacaklarlistesi", 0);
                       kullaniciEkle.Parameters.AddWithValue("@baslangictarihi", DateTime.Now.ToLongDateString());
                       kullaniciEkle.ExecuteNonQuery(); 
                       KayıtBasariliTimer.Start();                  
                }
                else
                {
                     KayıtBasariliTimer.Start();
                    MessageBox.Show("Böyle Bir Kullanıcı Mevcut!");
                }
            }

            timer.Start();
          
            /*try
            {
                new System.Net.Mail.MailAddress(this.MailAdresTextBox.Text);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Boş");
            }
            catch (FormatException)
            {
                MessageBox.Show("gecersiz");
            }*/
        }

        private void KullaniciAdTextBox_Leave(object sender, EventArgs e)
        {
            if(butonaktif== true)
               Kontrol(); 
        }

        private void SifreTextBox_Leave(object sender, EventArgs e)
        {
            if (butonaktif == true)
                Kontrol();
        }

        private void SifreTekrarTextBox_Leave(object sender, EventArgs e)
        {
            if (butonaktif == true)
                Kontrol();
        }

        private void MailAdresTextBox_Leave(object sender, EventArgs e)
        {
            if (butonaktif == true)
                Kontrol();
        }

        private void CaptchaTextBox_Leave(object sender, EventArgs e)
        {
            if (butonaktif == true)
                Kontrol();
        }
       
        
        int kayitBasarisüre = 0;
        bool delay = false;
        private void KayıtBasariliTimer_Tick(object sender, EventArgs e)
        {
            kayitBasarisüre++;
            BallGifPictureBox.Visible = true;

            if (kayitBasarisüre <= 18)
            {
                this.Height += 5;                
            }
            else if (kayitBasarisüre >= 40)
            {
                KayıtBasariliLabel.Visible = true;
                if(kayitBasarisüre >=65)
                {
                    if (kayitvarmi == false)
                    {                       
                        KayıtBasariliTimer.Stop();
                        BallGifPictureBox.Visible = false;
                        KayıtBasariliLabel.Text = "                   Kayıt Başarılı";
                        delay = true;                                                                                           
                    }
                    else
                    {
                        BallGifPictureBox.Visible = false;
                        KayıtBasariliLabel.Text = "     Böyle Bir Kullanıcı Mevcut! \n     Lütfen Tekrar Deneyiniz!";
                    }
                }
               
            }

        }
        int basarilisüre = 0;

        private void AllTextBoxClear()
        {
            KullaniciAdTextBox.Text = string.Empty;
            SifreTextBox.Text = string.Empty;
            SifreTekrarTextBox.Text = string.Empty;
            MailAdresTextBox.Text = string.Empty;
            CaptchaTextBox.Text = string.Empty;
        }
        KullaniciGirisForm KGF = new KullaniciGirisForm();

        private void timer_Tick(object sender, EventArgs e)
        {
            if(delay  )
            {
                 basarilisüre++;
              //  label3.Text = basarilisüre.ToString();
                if(basarilisüre >=20)
                {
                    BallGifPictureBox.Visible = true;
                    KayıtBasariliLabel.Visible = false;
                }
               if(basarilisüre >= 35)
                {
                      this.Hide();
                      KGF.Show();
                      timer.Stop();
                }                   
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void KayıtOlForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
