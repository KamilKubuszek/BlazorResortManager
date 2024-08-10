using BlazorResortManager1.Data;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Identity;
using MimeKit;
using MimeKit.Text;

namespace BlazorResortManager1.Services
{
    //public interface IEmailService
    //{
    //    void Send(string to, string subject, string html);
    //}

    public class EmailService : IEmailSender<ApplicationUser>
    {
        private readonly IConfiguration _config;
        public EmailService(IConfiguration config)
        {
            _config = config;
        }

        public Task SendConfirmationLinkAsync(ApplicationUser user, string email,
            string confirmationLink) => SendEmailAsync(email, "Confirm your email",
            "Please confirm your account by " +
            $"<a href='{confirmationLink}'>clicking here</a>.");

        public Task SendPasswordResetLinkAsync(ApplicationUser user, string email,
            string resetLink) => SendEmailAsync(email, "Reset your password",
            $"Please reset your password by <a href='{resetLink}'>clicking here</a>.");

        public Task SendPasswordResetCodeAsync(ApplicationUser user, string email,
            string resetCode) => SendEmailAsync(email, "Reset your password",
            $"Please reset your password using the following code: {resetCode}");
        public async Task SendEmailAsync(string to, string subject, string messageBody)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_config.GetSection("SenderAdress").Value));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = messageBody };

            using var smtp = new SmtpClient();
            
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate(
                _config.GetSection("SenderAdress").Value,
                _config.GetSection("SenderPass").Value);
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
