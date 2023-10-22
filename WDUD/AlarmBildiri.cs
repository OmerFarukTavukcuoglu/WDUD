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
    public partial class AlarmBildiri : Form
    {
        public AlarmBildiri()
        {
            InitializeComponent();
        }
        int time = 0;
        private void AlarmBildiri_Load(object sender, EventArgs e)
        {
            /* this.Top = 60;
             this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;*/
            open.Start();
            timeout.Start();
        }
         private void open_Tick(object sender, EventArgs e)
        {
             
        }

        private void close_Tick(object sender, EventArgs e)
        {

            if (this.Opacity <= 0.1)
            {
                this.Hide();
                
            }
            else if(this.Opacity >= 0.1)
            {
                this.Opacity -= 0.1;
            }
           

        }

        private void KapatLabel_Click(object sender, EventArgs e)
        {
            close.Start();
           
        }

        private void timeout_Tick(object sender, EventArgs e)
        {
            
            time++;
            if (time>=15)
            {
                close.Start();
                this.Hide();
            }
            
        }
    }
}
