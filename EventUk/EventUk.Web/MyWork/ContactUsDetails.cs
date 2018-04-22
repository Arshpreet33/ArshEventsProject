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

                ////Create the msg object to be sent
                //MailMessage mail = new MailMessage();
                ////Add your email address to the recipients
                //mail.To.Add("apsmann@brit5media.co.uk");
                ////Configure the address we are sending the mail from
                //MailAddress address = new MailAddress("apsmann@brit5media.co.uk");
                //mail.From = address;
                //mail.Subject = "Customer Contacted";

                //string subject = "\n Hi, \n\n" + contact.Message + "\n\n" +
                //    "This email was sent by : \n Name: " + contact.FullName +
                //    "\n Email: " + contact.Email;

                //mail.Body = subject;

                //SmtpClient client = new SmtpClient();
                //client.Host = "relay-hosting.secureserver.net";
                //client.Port = 25;

                ////Send the msg
                //client.Send(mail);

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                //SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;

                mail.From = new MailAddress("devmvc33@gmail.com");
                mail.To.Add("apsmann@brit5media.co.uk");
                //mail.To.Add("arshpreetsingh33@gmail.com");
                mail.Subject = "Customer Contacted from Website";

                string subject = "\n Hi, \n\n" + contact.Message + "\n\n" +
                    "This email was sent by : \n Name: " + contact.FullName +
                    "\n Email: " + contact.Email;

                mail.Body = subject;

                SmtpServer.Port = 25;
                //SmtpServer.UseDefaultCredentials = true;
                SmtpServer.Credentials = new System.Net.NetworkCredential("devmvc33", "9956788788");
                //SmtpServer.Credentials = new System.Net.NetworkCredential("ph11393658822", "H@ppy1993");
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