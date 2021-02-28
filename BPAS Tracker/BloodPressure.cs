using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Drawing;
using System.Data.SQLite;

namespace BPAS_Tracker
{
    public partial class BloodPressure : Form
    {
        public BloodPressure()
        {
            InitializeComponent();
        }
        private int AverageSystolic = 0, AverageDiastolic = 0, AverageHR = 0, NumberOfInputs = 0;
        private int LastSystolic = 0, LastDiastolic = 0, LastHR = 0, SortSelector = 0;
        private string ImageLocation = "";
        private long DateRange = 0;
        private void SortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortList.SelectedItem.ToString() == "Last 7 days")
            {
                DateRange = DateTimeOffset.Now.ToUnixTimeSeconds() - 604800;// Trenutno UNIX vrijeme minus 604800 --> broj sekundi u 7 dana
                SortSelector = 1;

            }
            else if (SortList.SelectedItem.ToString() == "Last 30 days")
            {
                DateRange = DateTimeOffset.Now.ToUnixTimeSeconds() - 2592000;// Trenutno UNIX vrijeme minus 2592000 --> broj sekundi u 30 dana
                SortSelector = 1;
            }
            else if (SortList.SelectedItem.ToString() == "Last 30 values")
            {
                DatabaseConnection.cmd.CommandText = "SELECT * FROM BloodPressure LIMIT 30";
                SortSelector = 2;
            }
            else
            {
                SortSelector = 0;
            }
            ChartData();
        }

        private void BloodPressure_Load(object sender, EventArgs e)
        {
            SortList.SelectedItem = "Last 30 values";        
        }
        private void ChartData()
        {
            DatabaseConnection.cmd.Parameters.Clear();
            try
            {
                if (SortSelector == 1)
                {
                    //upit za bazu
                    DatabaseConnection.cmd.CommandText = "SELECT Id, DATE, SYS, DIA, HR from BloodPressure WHERE DATE >= @param1";
                    DatabaseConnection.cmd.Parameters.AddWithValue("@param1", DateRange);
                }
                else if (SortSelector == 2)
                {
                    DatabaseConnection.cmd.CommandText = "SELECT * FROM BloodPressure LIMIT 30";
                }
                else
                {
                    DatabaseConnection.cmd.CommandText = "SELECT * FROM BloodPressure";
                }
                ////povezivanje grafa s odgovarajućim nizovima podataka  
                Series SBP = chart1.Series["Systolic BP"];
                Series DBP = chart1.Series["Diastolic BP"];
                Series HR = chart1.Series["Heart rate"];
                SBP.Points.Clear();
                DBP.Points.Clear();
                HR.Points.Clear();
                AverageSystolic = 0; AverageDiastolic = 0; AverageHR = 0; NumberOfInputs = 0;
                LastSystolic = 0; LastDiastolic = 0; LastHR = 0;
                SQLiteDataReader sqlDataReader = DatabaseConnection.cmd.ExecuteReader();
                while (sqlDataReader.Read())//čitanje podataka iz tablice BloodPressure, redak po redak 
                {
                    NumberOfInputs++; //brojanje zapisa iz baze --> može se dohvaćati i Id pa sačuvati najveća vrijednost

                    //Spremanje vrijednosti u varijable kako bi se kasnije odredila srednja vrijednost
                    AverageSystolic += Convert.ToInt32(sqlDataReader["SYS"]);
                    AverageDiastolic += Convert.ToInt32(sqlDataReader["DIA"]);
                    AverageHR += Convert.ToInt32(sqlDataReader["HR"]);

                    LastSystolic = Convert.ToInt32(sqlDataReader["SYS"]);
                    LastDiastolic = Convert.ToInt32(sqlDataReader["DIA"]);
                    LastHR = Convert.ToInt32(sqlDataReader["HR"]);

                    //dodavanje točaka na graf --> x-os = ID, y-os = parametri tlaka (SYS, DIA, HR)
                    SBP.Points.AddXY(DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(sqlDataReader["DATE"])).ToString("dd.MM.yyyy HH:mm:ss"), sqlDataReader["SYS"]);
                    DBP.Points.AddXY(DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(sqlDataReader["DATE"])).ToString("dd.MM.yyyy HH:mm:ss"), sqlDataReader["DIA"]);
                    HR.Points.AddXY(DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(sqlDataReader["DATE"])).ToString("dd.MM.yyyy HH:mm:ss"), sqlDataReader["HR"]);
                }
                sqlDataReader.Close();               
                AverageSystolic /= NumberOfInputs; //racunanje prosjecnih vrijednosti unesenih podataka
                AverageDiastolic /= NumberOfInputs;
                AverageHR /= NumberOfInputs;
                AverageHRValue.Text = Convert.ToString(AverageHR);
                SetLabelColors();

                if (LastSystolic > AverageSystolic || LastDiastolic > AverageDiastolic) //uvjeti nakon izračunatih srednjih vrijednosti koji će upozoravati korisnika o njegovom zdravlju
                {
                    AverageBPPicture.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp;
                    AverageBPPicture.IconColor = Color.Red;
                }
                else if (LastSystolic < AverageSystolic || LastDiastolic < AverageDiastolic)
                {
                    AverageBPPicture.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleDown;
                    AverageBPPicture.IconColor = Color.Green;
                }
                else
                {
                    AverageBPPicture.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
                    AverageBPPicture.IconColor = Color.Gray;
                }
                if (LastHR > AverageHR)
                {
                    AverageHRPicture.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp;
                    AverageHRPicture.IconColor = Color.Red;
                }
                else if (LastHR < AverageHR)
                {
                    AverageHRPicture.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleDown;
                    AverageHRPicture.IconColor = Color.Green;
                }
                else
                {
                    AverageHRPicture.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
                    AverageHRPicture.IconColor = Color.Gray;
                }
                ImageLocation = Directory.GetCurrentDirectory() + @"\BloodPressureLevels.jpeg";
                chart1.SaveImage(ImageLocation, ChartImageFormat.Jpeg);//spremanje trenutnog grafa u obliku slike u radni direktorij
                SlashLabel.Visible = true;
            }
            catch (Exception ex)//Ispis nastale greške pri radu s bazom
            {
                SlashLabel.Visible = false;
                if (ex.GetType().ToString() == "System.DivideByZeroException")
                {
                    MessageBox.Show("There are currently no values to show on the chart!");                  
                }
                else
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void SetLabelColors()
        {
            AverageSystolicLabel.Text = AverageSystolic.ToString();
            AverageDiastolicLabel.Text = AverageDiastolic.ToString();
            //Bojanje vrijednosti za prosječni gornji tlak
            if (AverageSystolic >= 90 && AverageSystolic <= 120)
            {
                AverageSystolicLabel.ForeColor = Color.Green;
            }
            else if (AverageSystolic > 120 && AverageSystolic <= 140)
            {
                AverageSystolicLabel.ForeColor = Color.Orange;
            }
            else if (AverageSystolic > 140)
            {
                AverageSystolicLabel.ForeColor = Color.Red;
            }
            else
            {
                AverageSystolicLabel.ForeColor = Color.MediumPurple;
            }//END - Bojanje

            //Bojanje vrijednosti za prosječni donji tlak
            if (AverageDiastolic >= 60 && AverageDiastolic <= 80)
            {
                AverageDiastolicLabel.ForeColor = Color.Green;
            }
            else if (AverageDiastolic > 80 && AverageDiastolic <= 90)
            {
                AverageDiastolicLabel.ForeColor = Color.Orange;
            }
            else if (AverageDiastolic > 90)
            {
                AverageDiastolicLabel.ForeColor = Color.Red;
            }
            else
            {
                AverageDiastolicLabel.ForeColor = Color.MediumPurple;
            }

            //Bojanje vrijednosti za prosječni gornji tlak
            if (AverageHR <= 75 && AverageHR >= 60)
            {
                AverageHRValue.ForeColor = Color.Green;
            }
            else if (AverageHR > 75 && AverageHR >= 85)
            {
                AverageHRValue.ForeColor = Color.Orange;
            }
            else if (AverageHR > 85)
            {
                AverageHRValue.ForeColor = Color.Red;
            }
            else
            {
                AverageHRValue.ForeColor = Color.MediumPurple;
            }
            //END - Bojanje
        }
    }
}
