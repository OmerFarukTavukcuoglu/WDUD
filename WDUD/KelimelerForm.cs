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
    public partial class KelimelerForm : Form
    {
        public KelimelerForm()
        {
            InitializeComponent();
        }
        public int get_id;
        SqlBaglanti baglanti = new SqlBaglanti();

        public void EkleButon_Click(object sender, EventArgs e)
        {
            if(KelimeAnlamiTextBox.Text == string.Empty || ÖgrenilenKelimeTextBox.Text == string.Empty)
            {
                MessageBox.Show("İlgili Alanları Doldur!");
            }
            else
            {
                SqlCommand islem = new SqlCommand("INSERT INTO KelimelerTablo(Ögrenilen_Kelime,Kelime_Anlami,Kullanici_ID) values(@ögrenilen,@anlami,@kullanici_id)", baglanti.Baglan());
                islem.Parameters.AddWithValue("@ögrenilen", ÖgrenilenKelimeTextBox.Text);
                islem.Parameters.AddWithValue("@anlami", KelimeAnlamiTextBox.Text);
                islem.Parameters.AddWithValue("@kullanici_id", get_id);
                islem.ExecuteNonQuery();
                profilAdd();
                MessageBox.Show("Öğrenilen Kelime Başarıyla Eklendi.","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            
            
        }
        private void profilAdd()
        {
            SqlCommand oku = new SqlCommand("SELECT * FROM Kullanici_Tablo", baglanti.Baglan());
            SqlDataReader dr = oku.ExecuteReader();
            if(dr.Read())
            {
                SqlCommand güncelle = new SqlCommand("UPDATE Kullanici_Tablo Set Ögrenilen_Kelime_Sayisi = Ögrenilen_Kelime_Sayisi+1 where Kullanici_ID=" + get_id, baglanti.Baglan());
                güncelle.ExecuteNonQuery();

            }
            else
            {
                MessageBox.Show("veri yok");
            }
          //  SqlCommand profil = new SqlCommand("INSERT INTO Kullanici_Tablo(Kullanici_ID,Ögrenilen_Kelime_Sayisi) values(@id,@ögrenilenKelimeS)", baglanti.Baglan());

        }


        private void KelimelerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wDUDatabaseDataSet.KelimelerTablo' table. You can move, or remove it, as needed.
            //      this.kelimelerTabloTableAdapter.Fill(this.wDUDatabaseDataSet.KelimelerTablo);
            //   MessageBox.Show(get_id.ToString());

            //  dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
             dataGridView1.ClearSelection();
             dataGridView1.ClearSelection();


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Selected = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Selected = false;
                }
            }



        }

        private void GösterButon_Click(object sender, EventArgs e)
        {


           /* dataGridView1.Columns[0].FillWeight = 10;
            dataGridView1.Columns[1].FillWeight = 10;*/

            SqlDataAdapter komut = new SqlDataAdapter("SELECT Ögrenilen_Kelime,Kelime_Anlami from KelimelerTablo where Kullanici_ID=" + get_id  , baglanti.Baglan());
            var commandBuilder = new SqlCommandBuilder(komut);
          //  dataGridView1.DataMember = "KelimelerTablo";
            DataSet ds = new DataSet();
            komut.Fill(ds, "KelimelerTablo");
        /*    DataGridViewColumn amount = new DataGridViewColumn();
            amount.HeaderText = "Ögrenilen_Kelime";
            amount.Name = "Ögrenilen_Kelime";
            dataGridView1.Columns.Insert(0, amount);*/
            dataGridView1.DataSource = ds.Tables["KelimelerTablo"].DefaultView; 


        }
    }
}
