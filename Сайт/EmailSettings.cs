using Microsoft.Extensions.Options;
using System;
using System.Net.Mail;
using System.Threading.Tasks;

namespace FlightManager
{
    public class EmailSettings
    {
        public String PrimaryDomain { get; set; }

        public int PrimaryPort { get; set; }
           

        public String UsernameEmail { get; set; }

        public String UsernamePassword { get; set; }

        public String FromEmail { get; set; }

        public String ToEmail { get; set; }

        public String CcEmail { get; set; }
    }
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
    public class AuthMessageSender : IEmailSender
    {
        public AuthMessageSender(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public EmailSettings _emailSettings { get; }

        public Task SendEmailAsync(string email, string subject, string message)
        {

            Execute(email, subject, message).Wait();
            return Task.FromResult(0);
        }

        public async Task Execute(string email, string subject, string message)
        {
            try
            {
                string toEmail = string.IsNullOrEmpty(email)
                                 ? _emailSettings.ToEmail
                                 : email;
                MailMessage mail = new MailMessage()
                {
                    From = new MailAddress(_emailSettings.UsernameEmail, "Flight Manager Webmaster ")
                };
                mail.To.Add(new MailAddress(toEmail));
                mail.CC.Add(new MailAddress(_emailSettings.CcEmail));

                mail.Subject = "Registration Link - " + subject;
                mail.Body = message;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;

               
            }
            catch (Exception ex)
            {
                //do something here
            }
        }
    }
}
