using Business.Utilities.Interceptors;
using Castle.DynamicProxy;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Business.Aspects.Mail
{
  public  class EditörSendMail
    {
        
        public static void SendMail(string email, string password)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(email);
            mailMessage.From = new MailAddress("asdfgerty123456@hotmail.com");
            mailMessage.Subject = "Aramıza Hoşgeldiniz!";
            mailMessage.Body = "Mail adresinize atanmış olan şifrniz : "+password;

            SmtpClient smtpClient = new SmtpClient();
         
            smtpClient.Credentials = new System.Net.NetworkCredential("asdfgerty123456@hotmail.com", "ASD123.HJK789.");
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.live.com";
            smtpClient.EnableSsl = true;


            smtpClient.Send(mailMessage);
        }

    }
}
