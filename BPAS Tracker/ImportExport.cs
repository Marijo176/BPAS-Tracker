using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data.SQLite;

namespace BPAS_Tracker
{
    public partial class ImportExport : Form
    {
        public ImportExport()
        {
            InitializeComponent();
        }
        #pragma warning disable IDE0044 // Add readonly modifier
        OpenFileDialog openFileDialog = new OpenFileDialog();
        #pragma warning restore IDE0044 // Add readonly modifier
        private string NameOfFile = "", line = "";
        public static string PassableFileName = "";
        public static bool IncludeImages = false;
        DateTime InsertTime = new DateTime();

        private void Open_Click(object sender, EventArgs e)
        {
            SelectedFile.Text = "";
            Form1.soundPlayer.Play(); //pokretanje .wav zapisa
            if (openFileDialog.ShowDialog() == DialogResult.OK) //provjera je li odabrana datoteka
            {
                SelectedFile.ForeColor = System.Drawing.Color.Black;
                SelectedFile.Text = openFileDialog.FileName;
                NameOfFile = openFileDialog.FileName;
                if (NameOfFile.Substring(NameOfFile.IndexOf(".")) == ".csv")//provjera je li datoteka u ispravnom formatu (trenutno radi s .csv)
                {
                    try
                    {
                        using (StreamReader streamReader = new StreamReader(NameOfFile))//otvaranje čitača odabrane datoteke
                        {
                            while ((line = streamReader.ReadLine()) != null) //čitanje liniju po liniju, stvaranje konekcije s bazom i zapis podataka u bazu
                            {
                                string[] StringSplits;
                                StringSplits = line.Split(',');//"razdvajanje" vrijednosti iz datoteke i pohrana u polje stringova; vrijednostima pristupiti preko indeksa (0 - 3)
                                DatabaseConnection.cmd.CommandText = "INSERT INTO BloodPressure(DATE, SYS, DIA, HR) VALUES (@param1, @param2, @param3, @param4)";
                                InsertTime = Convert.ToDateTime(StringSplits[0]);
                                DatabaseConnection.cmd.Parameters.AddWithValue("@param1", Convert.ToInt64(InsertTime.Subtract((new DateTime(1970, 1, 1,0,0,0))).TotalSeconds)-3600);
                                DatabaseConnection.cmd.Parameters.AddWithValue("@param2", StringSplits[1]);
                                DatabaseConnection.cmd.Parameters.AddWithValue("@param3", StringSplits[2]);
                                DatabaseConnection.cmd.Parameters.AddWithValue("@param4", StringSplits[3]);
                                if (StringSplits.Length > 4)//Ako su definirane samo četiri vrijednosti unesene su samo vrijednosti za tlak
                                {
                                    SQLiteCommand cmd2 = new SQLiteCommand("INSERT INTO BloodSugar(DATE, BS) VALUES (@param5, @param6)", DatabaseConnection.con);
                                    DatabaseConnection.cmd.Parameters.AddWithValue("@param5", StringSplits[4]);
                                    cmd2.Parameters.AddWithValue("@param6", StringSplits[5]);
                                    cmd2.ExecuteNonQuery();
                                }//TODO: Import samo vrijednosti za šećer                           
                                DatabaseConnection.cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Opening file failed with error:" + ex.Message);
                    }
                    finally
                    {
                        MessageBox.Show("Data successfully imported!");
                    }

                }
                else//ako je datoteka u neispravnom formatu, prikazati poruku u TextBoxu
                {
                    SelectedFile.Text = "Only supporting .csv format!";
                    SelectedFile.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void Email_Click(object sender, EventArgs e)
        {
            Form1.soundPlayer.Play(); //pokretanje .wav zapisa
            if (openFileDialog.ShowDialog() == DialogResult.OK) //provjeri je li odabrana datoteka
            {
                PassableFileName = openFileDialog.FileName; //--> prosljeđivanje imena odabrane datoteke (prilog elektroničke pošte) formi SendMail
                this.ParentForm.Visible = false;//skrivanje trenutne "roditeljske" forme
                SendMail sendMail = new SendMail
                {
                    ReferenceToMainForm = this.ParentForm //referenca na "roditeljsku" formu kako bi se mogla vratiti po zatvaranju forme SendMail
                };
                sendMail.Show();
            }
        }

        private void SaveLocalBP_Click(object sender, EventArgs e)
        {
            Form1.soundPlayer.Play(); //pokretanje .wav zapisa
            SaveFileDialog saveFileDialog = new SaveFileDialog //Otvaranje prozora za spremanje datoteka
            {
                Filter = "Comma-separated values(.csv)|*.csv", //odabir formata za pohranu datoteke
                Title = "Select export location"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK) //provjeri je li uspješno odabrana lokacija i ime datoteke
            {
                try//otvaranje veze s bazom, čitanje podataka te pohrana u datoteku
                {
                    SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM BloodPressure", DatabaseConnection.con);
                    StreamWriter file = new StreamWriter(saveFileDialog.FileName);
                    SQLiteDataReader sqlDataReader = cmd.ExecuteReader();
                    while (sqlDataReader.Read())//čitanje podataka iz tablice BloodPressure
                    {
                        file.WriteLine(DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(sqlDataReader["DATE"])) + "," + sqlDataReader["SYS"] + "," + sqlDataReader["DIA"] + "," + sqlDataReader["HR"]);//pohrana podataka iz baze u odabranu datoteku
                    }
                    file.Close();
                    sqlDataReader.Close();
                    Process.Start("explorer.exe", saveFileDialog.FileName);
                }
                catch (Exception ex)//ispis greške u radu s bazom ili prilikom zapisa podataka u datoteku
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void SaveLocalBS_Click(object sender, EventArgs e)
        {
            Form1.soundPlayer.Play(); //pokretanje .wav zapisa
            SaveFileDialog saveFileDialog = new SaveFileDialog //otvaranje dijaloga za spremanje datoteke
            {
                Filter = "Comma-separated values(.csv)|*.csv",//odabir formata za pohranu datoteke
                Title = "Select export location"
            };//Otvaranje prozora za spremanje datoteka
            if (saveFileDialog.ShowDialog() == DialogResult.OK)//provjeri je li uspješno odabrana lokacija i ime datoteke
            {
                try//otvaranje veze s bazom, čitanje podataka te pohrana u datoteku
                {
                    SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM BloodSugar", DatabaseConnection.con);
                    StreamWriter file = new StreamWriter(saveFileDialog.FileName);
                    SQLiteDataReader sqlDataReader = cmd.ExecuteReader();
                    while (sqlDataReader.Read())//čitanje podataka iz tablice BloodSugar
                    {
                        file.WriteLine(DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(sqlDataReader["DATE"])) + "," + sqlDataReader["BS"]);//pohrana podataka iz baze u odabranu datoteku
                    }
                    file.Close();
                    sqlDataReader.Close();
                    Process.Start("explorer.exe", saveFileDialog.FileName); //otvaranje datoteke sa spremljenim vrijednostima; datoteka se otvara u zadanom programu za rad s .csv datotekama
                }
                catch (Exception ex)//ispis greške u radu s bazom ili prilikom zapisa podataka u datoteku
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void IncludeImagesCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (IncludeImages == false)
            {
                IncludeImages = true;
            }
            else
            {
                IncludeImages = false;
            }
        }
        
    }
}
