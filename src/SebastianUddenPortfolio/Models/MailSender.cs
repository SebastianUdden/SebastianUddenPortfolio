using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SebastianUddenPortfolio.Models
{
    public class MailSender
    {
        public void SendMail(string fromName, string theSubject, string fromEmail, string textMessage)
        {
            // Sending from and to
            MailMessage mail = new MailMessage("inbetween.musicgroup@gmail.com", "sebastian.udden@gmail.com");

            mail.Subject = theSubject;

            mail.Body = textMessage + "\n" + "\n" + "From: " + fromName + "\n" + "Email: " + fromEmail + "\n\n" + "(This message was sent to you from your web portfolio.)";

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587; // Koden är specifik för gmail

            // Below is the emailadress and password for the mail which the message is sent FROM
            smtp.Credentials = new NetworkCredential("inbetween.musicgroup@gmail.com", "MikaelBrunnberg"); // (Email sent from, password to the same email)
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
    }
}

