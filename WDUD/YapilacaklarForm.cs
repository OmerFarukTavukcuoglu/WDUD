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
    public partial class YapilacaklarForm : Form
    {
        public YapilacaklarForm()
        {
            InitializeComponent();
        }
        public int get_id;
        SqlBaglanti baglanti = new SqlBaglanti();

        private void profilAdd()
        {
            SqlCommand oku = new SqlCommand("SELECT * FROM Kullanici_Tablo", baglanti.Baglan());
            SqlDataReader dr = oku.ExecuteReader();
            if (dr.Read())
            {
                SqlCommand güncelle = new SqlCommand("UPDATE Kullanici_Tablo Set Olusturulan_Yapilacaklar_Listesi_Sayisi = Olusturulan_Yapilacaklar_Listesi_Sayisi+1 where Kullanici_ID=" + get_id, baglanti.Baglan());
                güncelle.ExecuteNonQuery();

            }
            else
            {
                MessageBox.Show("veri yok");
            }
            //  SqlCommand profil = new SqlCommand("INSERT INTO Kullanici_Tablo(Kullanici_ID,Ögrenilen_Kelime_Sayisi) values(@id,@ögrenilenKelimeS)", baglanti.Baglan());

        }

        private void ListeOlusturButon_Click(object sender, EventArgs e)
        {
            SqlCommand islem = new SqlCommand("INSERT INTO YapilacaklarTablo(Yapilacaklar_Baslik,Yapilacaklar_icerik,Kullanici_ID) values(@baslik,@icerik,@kullanici_id)", baglanti.Baglan());
            islem.Parameters.AddWithValue("@baslik", ListeBaslikTextBox.Text);
            islem.Parameters.AddWithValue("@icerik", YapilacaklarRichTextBox.Text);
            islem.Parameters.AddWithValue("@kullanici_id", get_id);
            islem.ExecuteNonQuery();
            profilAdd();
            MessageBox.Show("basarili");
        }

        private void YapilacaklarForm_Load(object sender, EventArgs e)
        {
            SqlCommand islem = new SqlCommand("Select * from YapilacaklarTablo where Kullanici_ID =" + get_id, baglanti.Baglan());
            SqlDataReader oku = islem.ExecuteReader();

            if(oku.Read())
            {
                ListeBaslikTextBox.Text = oku[1].ToString();
                YapilacaklarRichTextBox.Text = oku[2].ToString();
            }

          
        }
    }
}
