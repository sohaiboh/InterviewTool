using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;

namespace InterviewTool
{
    public class Email
    {
        public static void SendEmail(string emailSubject, string emailBody, string emailTo)
        {/*
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

             smtpClient.Credentials = new System.Net.NetworkCredential("testinterview1234@gmail.com", "Test1234,");
             smtpClient.UseDefaultCredentials = true;
             smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
             smtpClient.EnableSsl = true;
             MailMessage mail = new MailMessage();

             mail.Subject = emailSubject;
             mail.Body = emailBody;
             //Setting From , To and CC
             mail.From = new MailAddress("testinterview1234@gmail.com", "Interviewtool");
             mail.To.Add(new MailAddress(emailTo));
             //mail.CC.Add(new MailAddress("MyEmailID@gmail.com"));
             //hier kommt email adress funktion..
             smtpClient.Send(mail);
             */
             
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.To.Add(emailTo);
            mail.From = new MailAddress(ConfigurationManager.AppSettings["EmailFrom"], ConfigurationManager.AppSettings["EmailName"], System.Text.Encoding.UTF8);
            mail.Subject = emailSubject;
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.Body = emailBody;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["EmailUserName"], ConfigurationManager.AppSettings["EmailPassword"]);
            client.Port = Convert.ToInt32(ConfigurationManager.AppSettings["EmailSMTPPort"]);
            client.Host = ConfigurationManager.AppSettings["EmailSMTP"];
            client.EnableSsl = true;
            try
            {
                client.Send(mail);
               //Page.RegisterStartupScript("UserMsg", "<script>alert('Successfully Send...');if(alert){ window.location='SendMail.aspx';}</script>");
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                string errorMessage = string.Empty;
                while (ex2 != null)
                {
                    errorMessage += ex2.ToString();
                    ex2 = ex2.InnerException;
                }
              //  Page.RegisterStartupScript("UserMsg", "<script>alert('Sending Failed...');if(alert){ window.location='SendMail.aspx';}</script>");
            }
            
        }
    }
}