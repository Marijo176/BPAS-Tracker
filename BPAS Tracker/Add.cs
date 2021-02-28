using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BPAS_Tracker
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        private double temp1 = 0;
        private int temp = 0;
        private DateTime RecordTime = new DateTime();
        private double TimeInSeconds = 0;
        private string[] HMS = new string[] { };
        private void AddBP_Click(object sender, EventArgs e)
        {
            Form1.soundPlayer.Play(); //pokretanje .wav zapisa
            SBPError.Text = "";
            DBPError.Text = "";
            HRError.Text = "";
            temp = 0;
            try //zabrana unosa slova i ostalih neodgovarajucih podataka
            {
                if (int.TryParse(SBPInput.Text, out temp))//parsiranje sadržaja textboxa u int --> provjera sadrži li textbox nešto osim brojeva
                {
                    if (int.TryParse(DBPInput.Text, out temp))
                    {
                        if (int.TryParse(HRInput.Text, out temp))
                        {
                            temp = 0;
                            if (Convert.ToInt32(SBPInput.Text) > 200 || Convert.ToInt32(SBPInput.Text) < 50) //Provjeriti realne vrijednosti
                            {
                                SBPError.Text = "*Check your SBP value";
                                temp++;
                            }
                            if (Convert.ToInt32(DBPInput.Text) > 150 || Convert.ToInt32(DBPInput.Text) < 30)
                            {
                                DBPError.Text = "*Check your DBP value";
                                temp++;
                            }
                            if (Convert.ToInt32(HRInput.Text) > 200 || Convert.ToInt32(HRInput.Text) < 30)
                            {
                                HRError.Text = "*Check your HR value";
                                temp++;
                            }
                            if (temp == 0)
                            {
                                try //povezivnej sa bazom i spreamnje unesenih podataka od korisnika
                                {
                                    RecordTime = monthCalendar1.SelectionRange.Start; //dohvaćanje trenutno označenog datuma u kalendaru
                                    
                                    DatabaseConnection.cmd.CommandText = "INSERT INTO BloodPressure(DATE, SYS, DIA, HR) VALUES (@param1, @param2, @param3, @param4)";
                                    DatabaseConnection.cmd.Parameters.AddWithValue("@param1",(Convert.ToInt64(RecordTime.Subtract((new DateTime(1970, 1, 1))).TotalSeconds) + ConvertTimeToDouble(DateTime.Now.ToString("HH:mm:ss"))));//pretvaranje datuma u UNIX Epoch Time
                                    DatabaseConnection.cmd.Parameters.AddWithValue("@param2", SBPInput.Text);
                                    DatabaseConnection.cmd.Parameters.AddWithValue("@param3", DBPInput.Text);
                                    DatabaseConnection.cmd.Parameters.AddWithValue("@param4", HRInput.Text);
                                    int i = DatabaseConnection.cmd.ExecuteNonQuery();
                                    if (i != 0)
                                    {
                                        MessageBox.Show("Data successfully saved!");
                                        SBPInput.Text = ""; DBPInput.Text = ""; HRInput.Text = "";
                                    }
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message.ToString());
                                }


                            }
                        }
                        else
                        {
                            HRError.Text = "Wrong input, try again!";
                        }
                    }
                    else
                    {
                        DBPError.Text = "Wrong input, try again!";
                    }
                }
                else
                {
                    SBPError.Text = " Wrong input, try again!";
                }
            }
            catch (Exception)
            {
                //throw;
            }

        }

        private void AddBS_Click(object sender, EventArgs e)
        {
            Form1.soundPlayer.Play(); //pokretanje .wav zapisa
            temp = 0;
            BSError.Text = "";
            try
            {
                if (double.TryParse(BSInput.Text, out temp1))
                {
                    temp1 = 0;
                    if (Convert.ToDouble(BSInput.Text) > 50 || Convert.ToDouble(BSInput.Text) < 1) //Provjeriti realne vrijednosti
                    {
                        BSError.Text = "*Check your BS value";
                        temp1++;
                    }
                    if (temp1 == 0)
                    {
                        try
                        {
                            RecordTime = monthCalendar1.SelectionRange.Start.ToLocalTime(); //dohvaćanje trenutno označenog datuma u kalendaru
                            DatabaseConnection.cmd.CommandText = "INSERT INTO BloodSugar(DATE, BS) VALUES (@param1, @param2)";
                            DatabaseConnection.cmd.Parameters.AddWithValue("@param1", (Convert.ToInt64(RecordTime.Subtract((new DateTime(1970, 1, 1))).TotalSeconds) + ConvertTimeToDouble(DateTime.Now.ToString("HH:mm:ss"))));
                            DatabaseConnection.cmd.Parameters.AddWithValue("@param2", BSInput.Text);
                            int i = DatabaseConnection.cmd.ExecuteNonQuery();
                            if (i != 0)
                            {
                                MessageBox.Show("Data successfully saved!");
                                BSInput.Text = "";
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message.ToString());
                        }
                    }
                }
                else
                {
                    // ispisati u BSError da ima nedozvoljenih znakova
                    BSError.Text = " Wrong input, try again!";
                }
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void ClearDatabase_Click(object sender, EventArgs e)
        {
            //upit za bazu za brisanje svih podataka prema ID (>0)
            try
            {
                DatabaseConnection.cmd.CommandText = "DELETE FROM BloodPressure WHERE Id >= 0";
                DatabaseConnection.cmd.ExecuteNonQuery();
                DatabaseConnection.cmd.CommandText = "DELETE FROM BloodSugar WHERE Id >= 0";
                DatabaseConnection.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Action failed with error message: " + ex.Message);
            }
            finally
            {
                MessageBox.Show("Database data was successfully deleted.");
            }
        }

        private void RemoveLastBP_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection.cmd.CommandText = "DELETE FROM BloodPressure WHERE Id = (SELECT MAX(Id) FROM BloodPressure)";
                DatabaseConnection.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Action failed with error message: " + ex.Message);
            }
            finally
            {
                MessageBox.Show("Last record was successfully deleted.");
            }
        }

        private void RemoveLastBS_Click(object sender, EventArgs e)
        {
            try
            {
                //cmd.CommandText = "DELETE FROM BloodSugar WHERE Id IN (SELECT TOP 1 Id FROM BloodSugar ORDER BY Id DESC )";
                DatabaseConnection.cmd.CommandText = "DELETE FROM BloodSugar WHERE Id = (SELECT MAX(Id) FROM BloodSugar)";
                DatabaseConnection.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Action failed with error message: " + ex.Message);
            }
            finally
            {
                MessageBox.Show("Last record was successfully deleted.");
            }           
        }
        private double ConvertTimeToDouble(string CurrentTime)
        {   
            HMS = CurrentTime.Split(':');
            TimeInSeconds = Convert.ToDouble(HMS[0])*3600 + Convert.ToDouble(HMS[1]) * 60 + Convert.ToDouble(HMS[2]);
            return TimeInSeconds;
        }
    }
}
