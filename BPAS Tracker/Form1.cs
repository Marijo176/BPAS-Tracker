using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SQLite;

namespace BPAS_Tracker
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] //učitavanje DLL-a potrebnog za iscrtavanje "ovalnih" rubova prozora
        private static extern IntPtr CreateRoundRectRgn//deklaracija funkcije CreateRoundRectRgn --> dokumentacija https://docs.microsoft.com/en-us/windows/win32/api/wingdi/nf-wingdi-createroundrectrgn
        (
            int x1,
            int y1,
            int x2,
            int y2,
            int w,
            int h
        );
        public Form1()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            DateAndTime.Text = DateTime.Now.ToString();
        }

        public static System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(Properties.Resources.ClickSound); 
        /*stvaranje nove instance SoundPlayera za pokretanje .wav zvuka iz Resursa projekta --> može se referencirati kroz Form1*/

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            DatabaseConnection.ConnectionClose();
            Application.Exit();
            
        }

        private void ButtonAddValues_Click(object sender, EventArgs e)
        {
            DisplayActiveButtonPanel(ButtonAddValues.Location.X, ButtonAddValues.Location.Y);
            WindowName.Text = "Values";
            soundPlayer.Play(); //pokretanje .wav zapisa
            this.FormLoader.Controls.Clear();//brisanje svih kontrola iz panela "FormLoader"
            Add AddWindow = new Add() { //stvaranje nove instance forme Add i postavljanje svojstava
            Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            this.FormLoader.Controls.Add(AddWindow);//dodavanje novih kontrola u panel "FormLoader" --> dio forme Add
            AddWindow.Show();//prikaz nove forme u panelu

        }

        private void ButtonPressure_Click(object sender, EventArgs e)
        {
            DisplayActiveButtonPanel(ButtonPressure.Location.X, ButtonPressure.Location.Y);
            WindowName.Text = "Blood Pressure levels"; //prikazivanje takozvanog "naslova" prilikom izmeje prozora
            soundPlayer.Play();
            this.FormLoader.Controls.Clear(); //brisanje kontrola iz proslog prozora
            BloodPressure BPWindow = new BloodPressure()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.FormLoader.Controls.Add(BPWindow); //dopustenje koristenja kontrola od novog prozora
            BPWindow.Show(); //priakz prozora
        }

        private void ButtonSugar_Click(object sender, EventArgs e)
        {
            DisplayActiveButtonPanel(ButtonSugar.Location.X, ButtonSugar.Location.Y);
            WindowName.Text = "Sugar levels";
            soundPlayer.Play();
            this.FormLoader.Controls.Clear();
            BloodSugar BSWindow = new BloodSugar()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.FormLoader.Controls.Add(BSWindow);
            BSWindow.Show();
        }

        private void ButtonImportExport_Click(object sender, EventArgs e)
        {
            DisplayActiveButtonPanel(ButtonImportExport.Location.X, ButtonImportExport.Location.Y);
            WindowName.Text = "Import / Export data";
            soundPlayer.Play();
            this.FormLoader.Controls.Clear();
            ImportExport IEWindow = new ImportExport()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.FormLoader.Controls.Add(IEWindow);
            IEWindow.Show();
        }

        private void Timer_Tick(object sender, EventArgs e) //timer koji "broji" po 1000ms --> za ažuriranje labela s prikazom vremena
        {
            DateAndTime.Text = DateTime.Now.ToString();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            DisplayActiveButtonPanel(HomeButton.Location.X, HomeButton.Location.Y);
            WindowName.Text = "Home";
            soundPlayer.Play();
            this.FormLoader.Controls.Clear();
            Home HomeWindow = new Home()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.FormLoader.Controls.Add(HomeWindow);
            HomeWindow.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseConnection.CheckAndCreateDatabase();
            DatabaseConnection.ConnectionOpen();
            WindowName.Text = "Home";
            this.FormLoader.Controls.Clear();
            Home HomeWindow = new Home()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.FormLoader.Controls.Add(HomeWindow);
            HomeWindow.Show();
        }
        public void DisplayActiveButtonPanel(int x, int y)
        {        
            ActiveButtonPanel.Location = new Point(x, y);
        }
    }
}
