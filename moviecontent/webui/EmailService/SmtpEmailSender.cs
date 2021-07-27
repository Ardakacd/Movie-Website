using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace webui.EmailService
{
    public class SmtpEmailSender : IEmailSender
    {

        private string user;

        private string password;

        private string host;

        private int port;

        private Boolean enableSsl;

        public SmtpEmailSender(string host,int port,string user,string password,Boolean enableSsl){
            this.enableSsl = enableSsl;
            this.port = port;
            this.host = host;
            this.user = user;
            this.password = password;
        }
        public Task sendEmailAsync(string email, string subject, string message)
        {
            var client = new SmtpClient(host,port){
                Credentials = new NetworkCredential(user,password),
                EnableSsl = this.enableSsl
                
            };

            return client.SendMailAsync(
                new MailMessage(user,email,subject,message){
                IsBodyHtml = true
            });
        }
    }
}