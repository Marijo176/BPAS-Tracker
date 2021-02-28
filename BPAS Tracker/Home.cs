using System;
using System.Windows.Forms;

namespace BPAS_Tracker
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private int i = 0, j = 0;

        private void Home_Load(object sender, EventArgs e) //učitavanje početnih slika slideshowa prilikom pokretanja forme
        {
            timer1.Enabled = true;
            i++; j++;
            SlideShowBP.Image = Properties.Resources.SlideshowBP1;
            SlideShowBS.Image = Properties.Resources.SlideshowBS1;
        }

#pragma warning disable IDE1006 // Naming Styles
        private void timer1_Tick(object sender, EventArgs e) //slideshow u Home prozoru
#pragma warning restore IDE1006 // Naming Styles
        {
            if (i == 0 && j == 0)
            {
                i++; j++;
                SlideShowBP.Image = Properties.Resources.SlideshowBP1;
                SlideShowBS.Image = Properties.Resources.SlideshowBS1;
            }
            else if (i == 1 && j == 1)
            {
                i++; j++;
                SlideShowBP.Image = Properties.Resources.SlideshowBP2;
                SlideShowBS.Image = Properties.Resources.SlideshowBS2;
            }
            else if ( i == 2 && j == 2)
            {
                i = 0; j = 0;
                SlideShowBP.Image = Properties.Resources.SlideshowBP3;
                SlideShowBS.Image = Properties.Resources.SlideshowBS3;
            }

        }
    }
}
