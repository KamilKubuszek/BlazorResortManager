using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

namespace BlazorResortManager1.Services
{
    public interface IEmailService
    {
        void Send(string from, string to, string subject, string html);
    }

    public class EmailService : IEmailService
    {
        public void Send(string from, string to, string subject, string html)
        {
            // create message
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(from));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = html };

            // send email
            using var smtp = new SmtpClient();
            
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("", "");
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
