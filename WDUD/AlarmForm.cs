using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WDUD
{
    public partial class AlarmForm : Form
    {
        public AlarmForm()
        {
            InitializeComponent();
        }
 
        private void AlarmForm_Load(object sender, EventArgs e)
        {
         //   MessageBox.Show(DateTime.Now.Minute.ToString());
            DateTimePicker.Visible = false;
            for (int i = 0; i < 60; i++)
            {
                if (i < 10)
                {
                    DakikaComboBox.Items.Add("0" + i.ToString());
            }
                else
                {
                 DakikaComboBox.Items.Add(i.ToString());
            }
        }
            for(int y =  0; y<25; y++)
            {
             if (y< 10)
                {
                    SaatCombobox.Items.Add("0" + y.ToString());
                }
                else
                {
                    SaatCombobox.Items.Add(y.ToString());
                }
            }
        }
        public bool alarm = false;

        bool bugünCheckBox = false;
        bool farklıgünCheckBox = false;
        private void BugünCheckBox_OnChange(object sender, EventArgs e)
        {
            if (FarkliGünCheckBox.Checked)
                FarkliGünCheckBox.Checked = false;
            DateTimePicker.Visible = false;
             
                bugünCheckBox = true;
            farklıgünCheckBox = false;
        }

        private void FarkliGünCheckBox_OnChange(object sender, EventArgs e)
        {
            if (BugünCheckBox.Checked)
                BugünCheckBox.Checked = false;
            DateTimePicker.Visible = true;
            
                farklıgünCheckBox = true;
            bugünCheckBox = false;

        }
        AlarmBildiri AB = new AlarmBildiri();
        //string.Format("{0:HH:mm:ss}", DateTime.Now);
        public void AlarmKurButon_Click(object sender, EventArgs e)
        {
            if (AlarmAdıTextBox.Text == string.Empty)            
                MessageBox.Show("isim");             
            else if (aktivitebuton == false && yapilacakbuton == false)
                MessageBox.Show("aktivite yada yapilacak");
            else if (BugünCheckBox.Checked == false && FarkliGünCheckBox.Checked == false)
                MessageBox.Show("combobox");
            else if (SaatCombobox.Text == string.Empty || DakikaComboBox.Text == string.Empty)
                MessageBox.Show("süre");
            else
            {
                BildiriTimer.Start();
                alarm = true;
            }


        }

         public void BildiriTimer_Tick(object sender, EventArgs e)
        {
             
            try
            {
                if ((SaatCombobox.Text + ":" + DakikaComboBox.Text) == DateTime.Now.ToShortTimeString())
                {
                    
                    if (BugünCheckBox.Checked)
                    {
                        AB.StartPosition = FormStartPosition.Manual;
                        AB.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - AB.Width,
                                                Screen.PrimaryScreen.WorkingArea.Height - AB.Height);
                        BildiriTimer.Start();
                        AB.Show();
                         BildiriTimer.Stop();
                     
                        AB.AlarmUyarıLabel.Text = Convert.ToString(AlarmAdıTextBox.Text +" "+ "adlı alarmın süresi geldi."+"\n"+"Hadi harekete geç"+ "\n" + "Saat " + SaatCombobox.Text + ":" + DakikaComboBox.Text + " ");

                        SonucLabelText.Text = Convert.ToString("Alarm" + " " + BugünLabel.Text + " " + "Saat " + SaatCombobox.Text + ":" + DakikaComboBox.Text + " " + "Kuruldu!"); 
                        
                       
                    }
                    else if (FarkliGünCheckBox.Checked)
                    {
                        SonucLabelText.Text = Convert.ToString("Alarm" + " " + DateTimePicker.Text + " " + "Saat " + SaatCombobox.Text + ":" + DakikaComboBox.Text + " " + "Kuruldu!");
                        AB.AlarmUyarıLabel.Text = Convert.ToString("Alarm" + " " + DateTimePicker.Text + " " + "Saat " + SaatCombobox.Text + ":" + DakikaComboBox.Text + " " + "Kuruldu!");
                    }
                }
            }
            catch (Exception )
            {

                ;
            }
           
         
        }
        bool aktivitebuton = false;
        bool yapilacakbuton = false;
        private void AktivitelerButon_Click(object sender, EventArgs e)
        {
            yapilacakbuton = false;
            aktivitebuton = true;
        }

        private void YapilacaklarButon_Click(object sender, EventArgs e)
        {
            aktivitebuton = false;
            yapilacakbuton = true;
        }
    }
}
