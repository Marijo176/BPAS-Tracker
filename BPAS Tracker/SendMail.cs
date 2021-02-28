using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace BPAS_Tracker
{
    public partial class SendMail : Form
    {
        public SendMail()
        {
            InitializeComponent();
        }
        public Form ReferenceToMainForm {
            get; set; }

        private void CloseMailWindow_Click(object sender, EventArgs e)
        {
            this.ReferenceToMainForm.Show();
            this.Close();
        }

        private void SendEMailButton_Click(object sender, EventArgs e)
        {
            try //dio koda za slanje elektroničke pošte --> trenutno implementirano za rad s gmail servisom; korisničke podatke preuzima direktno iz postavljenih TextBox kontrola
            {  //obavezno mora biti u try-catch bloku (neispravni podatci, internetska veza...)
                MailMessage mail = new MailMessage
                {
                    Subject = "BPAS Tracker Report",
                    From = new MailAddress(UsernameField2.Text),
                    Body = "You can find your blood pressure and/or blood sugar values in the attachement! Enjoy your day and stay healthy! "
                };
                mail.To.Add(MailToField.Text);
                Attachment attachment;
                attachment = new Attachment(ImportExport.PassableFileName);
                if (ImportExport.IncludeImages == true)
                {                 
                    Attachment Image1 = new Attachment(Directory.GetCurrentDirectory() + @"\BloodPressureLevels.jpeg");
                    Attachment Image2 = new Attachment(Directory.GetCurrentDirectory() + @"\BloodSugarLevels.jpeg");
                    mail.Attachments.Add(Image1);
                    mail.Attachments.Add(Image2);
                }
                mail.Attachments.Add(attachment);             
                SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                {
                    Credentials = new NetworkCredential(mail.From.ToString(), PasswordField.Text),
                    EnableSsl = true,
                    Port = 587
                };
                smtp.Send(mail);
                mail.Dispose();
            }
            catch (Exception ex)//ispis poruke s greškom vezanom uz slanje elektroničke pošte
            {
                MessageBox.Show("Action failed with error message: " + ex.Message);
            }
            finally//prikaz poruke ukoliko je elektronička pošta uspješno poslana
            {
                MessageBox.Show("Mail successfully sent!");
            }

        }

        private void UsernameField2_Click(object sender, EventArgs e)
        {
            UsernameField2.Clear();
        }

        private void PasswordField_Click(object sender, EventArgs e)
        {
            PasswordField.Clear();
        }

        private void MailToField_Click(object sender, EventArgs e)
        {
            MailToField.Clear();
        }
    }
}
