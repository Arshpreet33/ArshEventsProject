using EventUk.Web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace EventUk.Web.MyWork
{
    public class ContactUsDetails
    {
        public string EmailFunctionality(ContactUsViewModel contact)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(contact.Email);
                mail.To.Add("arpitrai123@hotmail.co.uk");
                mail.Subject = "User Contact";
                mail.Body = contact.Message;

                SmtpServer.Port = 25;
                SmtpServer.Credentials = new System.Net.NetworkCredential("devmvc33@gmail.com", "9956788788");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                //MailMessage mail = new MailMessage(contact.Email, "arpitrai123@gmail.com");
                //SmtpClient client = new SmtpClient();
                //client.Port = 25;
                //client.DeliveryMethod = SmtpDeliveryMethod.Network;
                //client.UseDefaultCredentials = false;
                //client.Host = "smtp.gmail.com";
                //mail.Subject = "Testing email functionality.";
                //mail.Body = "This is my test email body";
                //client.Send(mail);
            }
            catch (Exception e)
            {
                return "Oops! Error Occured";
            }

            return "Success";
        }
    }
}