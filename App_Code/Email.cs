using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace InterviewTool.App_Code
{
    public class Email
    {
        public static void SendEmail(string emailSubject, string emailBody, string emailTo)
        {
            SmtpClient smtpClient = new SmtpClient("mail.MyWebsiteDomainName.com", 25);

            smtpClient.Credentials = new System.Net.NetworkCredential("info@MyWebsiteDomainName.com", "myIDPassword");
            smtpClient.UseDefaultCredentials = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            MailMessage mail = new MailMessage();

            mail.Subject = emailSubject;
            mail.Body = emailBody;
            //Setting From , To and CC
            mail.From = new MailAddress("info@MyWebsiteDomainName", "MyWeb Site");
            mail.To.Add(new MailAddress(emailTo));
            //mail.CC.Add(new MailAddress("MyEmailID@gmail.com"));

            smtpClient.Send(mail);
        }
    }
}