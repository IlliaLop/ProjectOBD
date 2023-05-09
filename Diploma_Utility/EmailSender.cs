using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Diploma_Utility
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _configuration;
        private GMailSetings _GMailSetings { get; set; }

        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(email, subject, htmlMessage);
        }
        public async Task Execute(string email, string subject, string htmlMessage) 
        {
            _GMailSetings = _configuration.GetSection("GMailSetings").Get<GMailSetings>();
            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
            {
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;           
                client.Credentials = new NetworkCredential("furniturepanto@gmail.com", "dnrcknbrmddmyetk");
                MailMessage msgObj = new MailMessage();
                msgObj.To.Add(email);                
                msgObj.From = new MailAddress("furniturepanto@gmail.com");
                msgObj.Subject = subject;               
                msgObj.Body = htmlMessage;
                msgObj.IsBodyHtml = true;
                client.Send(msgObj);
            }
        }
    }
}
