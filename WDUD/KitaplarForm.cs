using Microsoft.Win32;
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
    public partial class KitaplarForm : Form
    {

        public KitaplarForm()
        {
            InitializeComponent();
        }


        private void SetStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

         /*   if (s)
                rk.SetValue("qwe", Application.ExecutablePath);
            else
                rk.DeleteValue("qwe", false);*/

        }

        public int get_id;
        bool okunacak_kitap;
        SqlBaglanti baglanti = new SqlBaglanti();
        Color cc1 = System.Drawing.ColorTranslator.FromHtml("#479DEE");
        Color varsayilan = System.Drawing.ColorTranslator.FromHtml("#488A99");

        private void KitaplarForm_Load(object sender, EventArgs e)
        {
            okunacak_kitap = true;
            OkunacakKitapButon.IdleFillColor = cc1;
           // MessageBox.Show(get_id.ToString());
            DataGridViewGroupBox.Visible = false;
        }

        private void OkunanKitapButon_Click(object sender, EventArgs e)
        {
            if (okunacak_kitap == true)
            {

                OkunanKitapButon.IdleFillColor = cc1;
                OkunacakKitapButon.IdleFillColor = varsayilan;
                KitapLabel.Text = "Okunan Kitap";
                okunacak_kitap = false;
        
            }
        }

        private void OkunacakKitapButon_Click(object sender, EventArgs e)
        {
            if (okunacak_kitap == false)
            {
               
                OkunanKitapButon.IdleFillColor = varsayilan;
                OkunacakKitapButon.IdleFillColor = cc1;
                KitapLabel.Text = "Okunacak Kitap";
                okunacak_kitap = true;
            }
        }
        bool eklegöster = true;
        private void EkleButon_Click(object sender, EventArgs e)
        {
            DataGridViewGroupBox.Visible = false;
            
         
            if (eklegöster == true)
            {
                if (KitapTextBox.Text != "" && KitapYazariTextBox.Text != "" && SayfaSayisiTextBox.Text != "")
                {
                
                    if(okunacak_kitap)
                    {
                        SqlCommand islem = new SqlCommand("INSERT INTO Okunacak_KitaplarTablo(Okunacak_Kitap_Adi,Kitap_Yazari,Sayfa_Sayisi,Kullanici_ID) values(@kitapadi,@yazari,@sayfa,@kullanici_id)", baglanti.Baglan());
                        islem.Parameters.AddWithValue("@kitapadi", KitapTextBox.Text);
                        islem.Parameters.AddWithValue("@yazari", KitapYazariTextBox.Text);
                        islem.Parameters.AddWithValue("@sayfa", SayfaSayisiTextBox.Text);
                        islem.Parameters.AddWithValue("@kullanici_id", get_id);
                        islem.ExecuteNonQuery();
                        MessageBox.Show("okunacak");

                    }
                    else if(okunacak_kitap == false)
                    {
                        SqlCommand islem = new SqlCommand("INSERT INTO Okunan_KitaplarTablo(Okunan_Kitap_Adi,Kitap_Yazari,Sayfa_Sayisi,Kullanici_ID) values(@kitapadi,@yazari,@sayfa,@kullanici_id)", baglanti.Baglan());
                        islem.Parameters.AddWithValue("@kitapadi", KitapTextBox.Text);
                        islem.Parameters.AddWithValue("@yazari", KitapYazariTextBox.Text);
                        islem.Parameters.AddWithValue("@sayfa", SayfaSayisiTextBox.Text);
                        islem.Parameters.AddWithValue("@kullanici_id", get_id);
                        islem.ExecuteNonQuery();
                        MessageBox.Show("Okunan");
                        profilAdd();
                    }
                }
                else
                    MessageBox.Show("Alanlar Boş Geçilemez!");
            }
            eklegöster = true;
        }
        private void profilAdd()
        {
            SqlCommand oku = new SqlCommand("SELECT * FROM Kullanici_Tablo", baglanti.Baglan());
            SqlDataReader dr = oku.ExecuteReader();
            if (dr.Read())
            {
                SqlCommand güncelle = new SqlCommand("UPDATE Kullanici_Tablo Set Okunan_Kitap_Sayisi = Okunan_Kitap_Sayisi+1 where Kullanici_ID=" + get_id, baglanti.Baglan());
                güncelle.ExecuteNonQuery();

            }
            else
            {
                MessageBox.Show("veri yok");
            }
            //  SqlCommand profil = new SqlCommand("INSERT INTO Kullanici_Tablo(Kullanici_ID,Ögrenilen_Kelime_Sayisi) values(@id,@ögrenilenKelimeS)", baglanti.Baglan());

        }
        private void GösterButon_Click(object sender, EventArgs e)
        {
            eklegöster = false;
            DataGridViewGroupBox.Visible = true;
            if(okunacak_kitap == true)
            {
                SqlDataAdapter okunacak = new SqlDataAdapter("SELECT Okunacak_Kitap_Adi,Kitap_Yazari,Sayfa_Sayisi from Okunacak_KitaplarTablo where Kullanici_ID =" + get_id, baglanti.Baglan());
                DataSet ds = new DataSet();
                okunacak.Fill(ds, "Okunacak_KitaplarTablo");
                dataGridView1.DataSource = ds.Tables["Okunacak_KitaplarTablo"].DefaultView;
            }
            else if(okunacak_kitap == false)
            {
                SqlDataAdapter okunan = new SqlDataAdapter("SELECT Okunan_Kitap_Adi,Kitap_Yazari,Sayfa_Sayisi from Okunan_KitaplarTablo where Kullanici_ID =" + get_id, baglanti.Baglan());
                DataSet ds = new DataSet();
                okunan.Fill(ds, "Okunan_KitaplarTablo");
                dataGridView1.DataSource = ds.Tables["Okunan_KitaplarTablo"].DefaultView;
            }
        }
    }
}
