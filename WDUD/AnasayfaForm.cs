using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WDUD
{
    public partial class AnasayfaForm : Form
    {
        public AnasayfaForm()
        {
            InitializeComponent();
            DikIconCubuguLabel.Visible = false;
           
        }
        KelimelerForm KF = new KelimelerForm();
        KitaplarForm KitaplarF = new KitaplarForm();
        GünlükAktivitelerForm GAF = new GünlükAktivitelerForm();
        ProfilForm PF = new ProfilForm();
        AlarmForm AF = new AlarmForm();
        YapilacaklarForm YF = new YapilacaklarForm();

        SqlBaglanti baglanti = new SqlBaglanti();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        bool panelacikmi = true;

        private void PanelAcKapaTimer_Tick(object sender, EventArgs e)
        {

            if (panelacikmi == true)
            {
                CubukLabel.Visible = true;
                if (İcerikPanel.Location.X >= 65)
                {
                    CubukLabel.Width = 10;
                    AltaAlLabel.Left -= 5;
                    KapatLabel.Left -= 5;
                    this.Width -= 5;
                    İcerikPanel.Left -= 5;
                    İcerikPanel.Width += 5;
                    CubukLabel.Left -= 5;
                    KullaniciResim.Visible = false;                    
                    if (İcerikPanel.Location.X <= 65)
                    {
                        DikIconCubuguLabel.Visible = true;
                        
                    }
                }

                else
                {
                    PanelAcKapaTimer.Stop();
                    panelacikmi = false;
                }

            }
            else if (panelacikmi == false)
            {
                if (İcerikPanel.Location.X <= 180)
                {
                    
                    CubukLabel.Left += 5;
                    AltaAlLabel.Left += 5;
                    KapatLabel.Left += 5;
                    this.Width += 5;
                    İcerikPanel.Left += 5;
                    İcerikPanel.Width -= 5;
                    CubukLabel.Width = 2;
                    if(İcerikPanel.Location.X >=179)
                    {
                        KullaniciResim.Visible = true;

                    }
                    DikIconCubuguLabel.Visible = false;
                }
                else if (İcerikPanel.Location.X >= 180)
                {
                    PanelAcKapaTimer.Stop();
                    panelacikmi = true;

                }

            }

        }
        private void PanelAcTimer_Tick(object sender, EventArgs e)
        {
            DikIconCubuguLabel.Visible = false;
            if (İcerikPanel.Location.X <= 180)
            {
                AltaAlLabel.Left += 5;
                KapatLabel.Left += 5;
                this.Width += 5;
                İcerikPanel.Left += 5;
                İcerikPanel.Width -= 5;
              
            }
            else if (İcerikPanel.Location.X >= 180)
            {
                PanelAcTimer.Stop();
                panelacikmi = true;
                 
            }
        }
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void KelimelerButon_Click(object sender, EventArgs e)
        {

        }

        private void butonEvent(object sender, EventArgs e)
        {
            string buton = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Name;
            //   MessageBox.Show(buton);
            if (buton == "KelimelerButon")
            {
                İcerikPanel.Controls.Clear();
                 KF.TopLevel = false;
                
                this.İcerikPanel.Controls.Add(KF);
                KF.Show();
                PanelAcTimer.Start();
            }
            else if (buton == "KitaplarButon")
            {
                İcerikPanel.Controls.Clear();
                KitaplarF.TopLevel = false;
                this.İcerikPanel.Controls.Add(KitaplarF);
                KitaplarF.Show();
                PanelAcTimer.Start();
            }
            else if (buton == "YapilacaklarButon")
            {
                İcerikPanel.Controls.Clear();
                YF.TopLevel = false;
                this.İcerikPanel.Controls.Add(YF);
                YF.Show();
                PanelAcTimer.Start();
            }
            else if (buton == "GünlükAktivitelerButon")
            {
                İcerikPanel.Controls.Clear();
                GAF.TopLevel = false;
                this.İcerikPanel.Controls.Add(GAF);
                GAF.Show();
                PanelAcTimer.Start();
            }
            else if (buton == "AlarmButon")
            {
                İcerikPanel.Controls.Clear();
                AF.TopLevel = false;
                this.İcerikPanel.Controls.Add(AF);
                AF.Show();
                PanelAcTimer.Start();
            }
            else if (buton == "ProfilButon")
            {
                İcerikPanel.Controls.Clear();
                PF.TopLevel = false;
                this.İcerikPanel.Controls.Add(PF);
                PF.Show();
                PanelAcTimer.Start();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panelacikmi == true)
            {
                if (İcerikPanel.Location.X <= 145)
                {
                    PanelCubukPictureBox.Left -= +8;
                    
                }
            }
            else if (panelacikmi == false)
            {
                if (PanelCubukPictureBox.Location.X <= 150)
                {
                    PanelCubukPictureBox.Left += +3;
                }
                else if (PanelCubukPictureBox.Location.X >= 150) { timer1.Stop(); }

            }
        }

        private void PanelCubukPictureBox_Click(object sender, EventArgs e)
        {
            timer1.Start();
            PanelAcKapaTimer.Start();
        }

        private void UstBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void AltaAlLabel_Click(object sender, EventArgs e)
        {
            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.ClientAreaEnabled;
            //  this.Hide(); // Uygulama arka planda çalışmaya devam ediyor.
            
        }

        private void KapatLabel_Click(object sender, EventArgs e)
        {
             if (AF.alarm == true)
            {
                notifyIcon1.Text = "My application";
                //  trayIcon.Icon = @"C:\Users\omarf\Desktop\CustomIcon.ico";

                // Add menu to tray icon and show it.
                // trayIcon.ContextMenu = "qweq";
                notifyIcon1.Visible = true;

                Visible = false; // Hide form window.
                ShowInTaskbar = false; // Remove from taskbar.
            }
            else
                Application.Exit();
                                
        }

        public int get_id;
        public void AnasayfaForm_Load(object sender, EventArgs e)
        {
            KullaniciResim.SizeMode = PictureBoxSizeMode.StretchImage;
            Profil_Resim_Load();
            

            if (KullaniciAdiLabel.Text.Length >= 7)
                KullaniciAdiLabel.Left -= 30;
            KF.get_id = get_id;
            KitaplarF.get_id = get_id;
            GAF.get_id = get_id;
            YF.get_id = get_id;
            PF.get_id = get_id;
           // MessageBox.Show(get_id.ToString());
        }
        string imageYol;

        private void KullaniciResim_Click(object sender, EventArgs e)
        {
 
            try
            {
                OpenFileDialog OFD = new OpenFileDialog();
                 OFD.Filter = "Resim Dosyaları|*.jpg;*.png;*.bmp;*.gif;*.tif";

                if (OFD.ShowDialog() == DialogResult.OK)
                {
                     imageYol = OFD.FileName;
                     KullaniciResim.SizeMode = PictureBoxSizeMode.StretchImage;
                     KullaniciResim.ImageLocation = imageYol;
                     SqlCommand resimekle = new SqlCommand("UPDATE Kullanici_Tablo SET Profil_Resim = @resim where Kullanici_ID=" + get_id, baglanti.Baglan());
                     resimekle.Parameters.AddWithValue("@resim", imageYol.ToString());
                     resimekle.ExecuteNonQuery();
                     MessageBox.Show("Profil Resimi Başarıyla Güncellendi"); 
                     
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Resim Güncellenirken Bir Hata Oluştu!");
            }
        }

        private void Profil_Resim_Load()
        {
            if (KullaniciResim.Image == null)
            {
                KullaniciResim.Image = WDUD.Properties.Resources.ProfilPicYok;
                PF.KullaniciResim.Image = WDUD.Properties.Resources.ProfilPicYok;
            }

            SqlCommand oku = new SqlCommand("SELECT* FROM Kullanici_Tablo where Kullanici_ID=" + get_id, baglanti.Baglan());
            SqlDataReader dr = oku.ExecuteReader();
            if(dr.Read())
            {
                KullaniciResim.ImageLocation = dr[9].ToString();
                PF.KullaniciResim.ImageLocation = dr[9].ToString();
            }
        }
    }
}
