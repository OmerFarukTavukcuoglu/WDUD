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
    public partial class ProfilForm : Form
    {
        public ProfilForm()
        {
            InitializeComponent();
        }
        public int get_id;
        SqlBaglanti baglanti = new SqlBaglanti();
        private void ProfilForm_Load(object sender, EventArgs e)
        {
            SqlCommand veri = new SqlCommand("SELECT * FROM Kullanici_Tablo where Kullanici_ID=" + get_id, baglanti.Baglan());
            SqlDataReader oku = veri.ExecuteReader();
            if(oku.Read())
            {
              
                KullaniciAdLabel.Text = oku[1].ToString();
                mailLabel.Text = oku[3].ToString();
                OkunanKitapSayisiLabel.Text = oku[4].ToString();
                ÖgrenilenKelimeSayisiLabel.Text = oku[5].ToString();
                OlusturulanAktiviteLabel.Text = oku[6].ToString();
                OlusturulanYapilacaklarListesiLabel.Text = oku[7].ToString();
                BaslangicTarihiLabel.Text = oku[8].ToString();
            }
        }
    }
}
