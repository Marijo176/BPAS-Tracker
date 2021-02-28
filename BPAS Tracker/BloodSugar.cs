using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Drawing;
using System.Data.SQLite;

namespace BPAS_Tracker
{
    public partial class BloodSugar : Form
    {
        public BloodSugar()
        {
            InitializeComponent();
        }
        private double AverageBS = 0, NumberOfInputs = 0, LastBS = 0, SortSelector = 0;
        private string ImageLocation = "";
        private long DateRange = 0;
        private void SortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortList.SelectedItem.ToString() == "Last 7 days")
            {
                DateRange = DateTimeOffset.Now.ToUnixTimeSeconds() - 604800;// Trenutno UNIX vrijeme minu 604800 --> broj sekundi u 7 dana
                SortSelector = 1;

            }
            else if (SortList.SelectedItem.ToString() == "Last 30 days")
            {
                DateRange = DateTimeOffset.Now.ToUnixTimeSeconds() - 2592000;// Trenutno UNIX vrijeme minu 2592000 --> broj sekundi u 30 dana
                SortSelector = 1;
            }
            else if (SortList.SelectedItem.ToString() == "Last 30 values")
            {
                DatabaseConnection.cmd.CommandText = "SELECT * FROM BloodSugar LIMIT 30";
                SortSelector = 2;
            }
            else
            {
                SortSelector = 0;
            }
            ChartData();
        }

        private void BloodSugar_Load(object sender, EventArgs e)
        {
            SortList.SelectedItem = "Last 30 values";
        }
        private void ChartData()
        {
            DatabaseConnection.cmd.Parameters.Clear();
            try //povezivanje sa bazom 
            {
                if (SortSelector == 1)
                {
                    //upit za bazu
                    //cmd.CommandText = "SELECT Id, DATE, SYS, DIA, HR from BloodPressure WHERE DATE >='" + Convert.ToDateTime(DateRange) + "'";
                    DatabaseConnection.cmd.CommandText = "SELECT Id, DATE, BS from BloodSugar WHERE DATE >= @param1";
                    DatabaseConnection.cmd.Parameters.AddWithValue("@param1", DateRange);
                }
                else if (SortSelector == 2)
                {
                    DatabaseConnection.cmd.CommandText = "SELECT * FROM BloodSugar LIMIT 30";
                }
                else
                {
                    DatabaseConnection.cmd.CommandText = "SELECT * FROM BloodSugar";
                }
                Series BS = chart1.Series["Blood sugar"];
                BS.Points.Clear();
                AverageBS = 0; NumberOfInputs = 0; LastBS = 0;
                SQLiteDataReader sqlDataReader = DatabaseConnection.cmd.ExecuteReader();
                while (sqlDataReader.Read())// čitanje podataka iz tablice BloodSugar, redak po redak
                {
                    NumberOfInputs++;
                    AverageBS += Convert.ToDouble(sqlDataReader["BS"]);
                    LastBS = Convert.ToDouble(sqlDataReader["BS"]);
                    //dodavanje točaka na graf --> x-os = ID, y-os = vrijednost šećera
                    BS.Points.AddXY(DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(sqlDataReader["DATE"])).ToString("dd.MM.yyyy HH:mm:ss"), sqlDataReader["BS"]);

                }
                sqlDataReader.Close();
                if (NumberOfInputs != 0)
                {
                    AverageBS = Math.Round(AverageBS / NumberOfInputs, 2);
                    SetLabelColors();
                    AverageBS2.Text = Convert.ToString(AverageBS);

                    if (LastBS > AverageBS)
                    {
                        AverageBSPicture.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp;
                        AverageBSPicture.IconColor = Color.Red;
                    }
                    else if (LastBS < AverageBS)
                    {
                        AverageBSPicture.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleDown;
                        AverageBSPicture.IconColor = Color.Green;
                    }
                    else
                    {
                        //AverageBSPicture.SetBounds(AverageBSPicture.Location.X, 469, AverageBSPicture.Width, AverageBSPicture.Width);
                        AverageBSPicture.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
                        AverageBSPicture.IconColor = Color.Gray;
                    }
                    ImageLocation = Directory.GetCurrentDirectory() + @"\BloodSugarLevels.jpeg";
                    chart1.SaveImage(ImageLocation, ChartImageFormat.Jpeg);//spremanje trenutnog grafa u obliku slike u radni direktorij
                }
                else
                {
                    MessageBox.Show("There are currently no values to show on the chart!");
                }
            }
            catch (Exception ex)//Ispis nastale greške pri radu s bazom
            {

                MessageBox.Show(ex.Message.ToString());

            }
        }
        private void SetLabelColors()
        {
            if (AverageBS <= 6 && AverageBS > 3.9)
            {
                AverageBS2.ForeColor = Color.Green;
            }
            else if (AverageBS >= 7 && AverageBS <= 10)
            {
                AverageBS2.ForeColor = Color.Orange;
            }
            else if (AverageBS >= 11)
            {
                AverageBS2.ForeColor = Color.Red;
            }
            else
            {
                AverageBS2.ForeColor = Color.MediumPurple;
            }
        }
    }
}
