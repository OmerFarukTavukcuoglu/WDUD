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
    public partial class GünlükAktivitelerForm : Form
    {
        public GünlükAktivitelerForm()
        {
            InitializeComponent();
            SilButon.Visible = false;
        }
        public int get_id;

        SqlBaglanti baglanti = new SqlBaglanti();
        bool tiklama = false;

        private void AktivitelerTimer_Tick(object sender, EventArgs e)
        {
          
            AktivitelerGroupBox.Visible = true;

            DurumGroupBox.Visible = false;

            if (AktivitelerGroupBox.Height <= 520)
            {
                AktivitelerGroupBox.Height += 15;
                
            }
            if(AktivitelerGroupBox.Height >=520)
            {
                AktivitelerTimer.Stop();
            }
        }
        bool TextControlling = false;
        private void TextControl()
        {
            if (AktiviteBaslikTextBox.Text == "" || Aktivite1TextBox.Text == "" || Aktivite2TextBox.Text == "" || Aktivite3TextBox.Text == "" ||
                Aktivite4TextBox.Text == "" || Aktivite5TextBox.Text == "" || Aktivite6TextBox.Text == "" || Aktivite7TextBox.Text == "")
            {
                TextControlling = false;
                MessageBox.Show("Bos Bırakılamaz");
            }
            else
            {
                TextControlling = true;
            }
        }

        private void profilAdd()
        {
            SqlCommand oku = new SqlCommand("SELECT * FROM Kullanici_Tablo", baglanti.Baglan());
            SqlDataReader dr = oku.ExecuteReader();
            if (dr.Read())
            {
                SqlCommand güncelle = new SqlCommand("UPDATE Kullanici_Tablo Set Olusturulan_Günlük_Aktivite_Sayisi = Olusturulan_Günlük_Aktivite_Sayisi+1 where Kullanici_ID=" + get_id, baglanti.Baglan());
                güncelle.ExecuteNonQuery();

            }
            else
            {
                MessageBox.Show("veri yok");
            }
            //  SqlCommand profil = new SqlCommand("INSERT INTO Kullanici_Tablo(Kullanici_ID,Ögrenilen_Kelime_Sayisi) values(@id,@ögrenilenKelimeS)", baglanti.Baglan());

        }

        private void AktiviteOlusturButon_Click(object sender, EventArgs e)
        {
            tiklama = true;
            AktiviteBaslikTextBox.Focus();
            this.Refresh();
            Metod();
            if (AktiviteOlusturButon.ButtonText == "Yeniden Oluştur")
            {
                
                SqlCommand güncelle = new SqlCommand("UPDATE Günlük_AktiviteTablo SET Aktivite_Basligi='"+AktiviteBaslikTextBox.Text + "'" 
                    + ",Aktivite_1='" + Aktivite1TextBox.Text + "'" + ",Aktivite_2='" + Aktivite2TextBox.Text + "'" 
                    + ",Aktivite_3='" + Aktivite3TextBox.Text + "'" + ",Aktivite_4='" + Aktivite4TextBox.Text + "'" 
                    + ",Aktivite_5='" + Aktivite5TextBox.Text + "'" + ",Aktivite_6='" + Aktivite6TextBox.Text + "'" 
                    + ",Aktivite_7='" + Aktivite7TextBox.Text + "'" + " where Kullanici_ID =" + get_id, baglanti.Baglan());
                güncelle.ExecuteNonQuery();
            }

        }
         private void Metod()
        {
            SqlCommand islem = new SqlCommand("Select * from Günlük_AktiviteTablo where Kullanici_ID =" + get_id, baglanti.Baglan());
            SqlDataReader oku = islem.ExecuteReader();


            if (tiklama == false)
            {
                SilButon.Visible = true;
                if (oku.Read())
                {
                    AktiviteOlusturButon.ButtonText = "Yeniden Oluştur";
                    AktivitelerTimer.Start();
                    AktiviteBaslikTextBox.Text = oku[1].ToString();
                    Aktivite1TextBox.Text = oku[2].ToString();
                    Aktivite2TextBox.Text = oku[3].ToString();
                    Aktivite3TextBox.Text = oku[4].ToString();
                    Aktivite4TextBox.Text = oku[5].ToString();
                    Aktivite5TextBox.Text = oku[6].ToString();
                    Aktivite6TextBox.Text = oku[7].ToString();
                    Aktivite7TextBox.Text = oku[8].ToString();                  
                }
               
            }
            else
            {
            
              if (oku.Read() == false)
                {
                  

                    AktivitelerTimer.Start();
                    if (AktivitelerGroupBox.Visible)
                    {
                         TextControl();
                        if (TextControlling ==true)
                        {
                            SqlCommand ekle = new SqlCommand("INSERT INTO Günlük_AktiviteTablo(Aktivite_Basligi,Aktivite_1,Aktivite_2,Aktivite_3,Aktivite_4,Aktivite_5,Aktivite_6,Aktivite_7,Var_mi,Kullanici_ID) values(@baslik,@1,@2,@3,@4,@5,@6,@7,@Var_mi,@kullanici_id)", baglanti.Baglan());
                            ekle.Parameters.AddWithValue("@baslik", AktiviteBaslikTextBox.Text);
                            ekle.Parameters.AddWithValue("@1", Aktivite1TextBox.Text);
                            ekle.Parameters.AddWithValue("@2", Aktivite2TextBox.Text);
                            ekle.Parameters.AddWithValue("@3", Aktivite3TextBox.Text);
                            ekle.Parameters.AddWithValue("@4", Aktivite4TextBox.Text);
                            ekle.Parameters.AddWithValue("@5", Aktivite5TextBox.Text);
                            ekle.Parameters.AddWithValue("@6", Aktivite6TextBox.Text);
                            ekle.Parameters.AddWithValue("@7", Aktivite7TextBox.Text);
                            ekle.Parameters.AddWithValue("@Var_mi", 1);
                            ekle.Parameters.AddWithValue("@kullanici_id", get_id);
                            ekle.ExecuteNonQuery();
                            profilAdd();
                            MessageBox.Show("Basariyla Eklendi");
                            
                        }
                    }
                }
              }                      
        }
  
        private void GünlükAktivitelerForm_Load(object sender, EventArgs e)
        {
             AktivitelerGroupBox.Visible = false;
             Metod();
        }
        private void AktiviteSil()
        {
            SqlCommand sil = new SqlCommand("DELETE FROM Günlük_AktiviteTablo WHERE Kullanici_ID=" + get_id, baglanti.Baglan());
            sil.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Silindi");
            SilTimer.Start();
            AktivitelerGroupBox.Visible = false;
            DurumGroupBox.Visible = true;
            SqlCommand islem = new SqlCommand("Select * from Günlük_AktiviteTablo where Kullanici_ID =" + get_id, baglanti.Baglan());
            SqlDataReader oku = islem.ExecuteReader();
             AktiviteOlusturButon.ButtonText = "Aktivite Oluştur";
            TextBoxTemizle();
            SilButon.Visible = false;

           /* while (oku.Read())
            {
                AktiviteOlusturButon.ButtonText = "qwe";
                AktiviteBaslikTextBox.Text = oku[1].ToString();
                Aktivite1TextBox.Text = oku[2].ToString();
                Aktivite2TextBox.Text = oku[3].ToString();
                Aktivite3TextBox.Text = oku[4].ToString();
                Aktivite4TextBox.Text = oku[5].ToString();
                Aktivite5TextBox.Text = oku[6].ToString();
                Aktivite6TextBox.Text = oku[7].ToString();
                Aktivite7TextBox.Text = oku[8].ToString();
            }
            if(!oku.Read())
            {
               //  SilButon.Visible = false;
            }*/

        }



        private void SilButon_Click(object sender, EventArgs e)
        {
            AktiviteSil();
        }

        private void TextBoxTemizle()
        {
            AktiviteBaslikTextBox.Text = string.Empty;
            Aktivite1TextBox.Text = string.Empty;
            Aktivite2TextBox.Text = string.Empty;
            Aktivite3TextBox.Text = string.Empty;
            Aktivite4TextBox.Text = string.Empty;
            Aktivite5TextBox.Text = string.Empty;
            Aktivite6TextBox.Text = string.Empty;
            Aktivite7TextBox.Text = string.Empty;

        }

        private void SilTimer_Tick(object sender, EventArgs e)
        {
             


          /*  if (AktivitelerGroupBox.Height >= 75)
            {
                AktivitelerGroupBox.Height -= 15;
            }*/
        }
    }
}
