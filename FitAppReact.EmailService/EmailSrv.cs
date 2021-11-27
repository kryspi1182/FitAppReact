using FitAppReact.Common.Configurations;
using FitAppReact.Interfaces.Infrastructure.EmailService;
using MailKit.Net.Smtp;
using MimeKit;
using System;

namespace FitAppReact.EmailService
{
    public class EmailSrv : IEmailSrv
    {
        private readonly IEmailConfiguration emailConfiguration;

        public EmailSrv(IEmailConfiguration _emailConfiguration)
        {
            emailConfiguration = _emailConfiguration;
        }
        public void SendVerificationEmail(string email, string subject, string content)
        {
            var message = new MimeMessage();
            var name = email.Split('@')[0];

            message.From.Add(new MailboxAddress(emailConfiguration.SmtpName, emailConfiguration.UserName));

            message.To.Add(new MailboxAddress($"{name}", email));

            //var footer = string.Format(this.templateManager.EmailFooter, emailConfiguration.SmtpName, "", emailConfiguration.SmtpUserName);

            message.Subject = subject;
            message.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = content //+ footer,
            };


            using (var client = new SmtpClient())
            {
                client.Connect(emailConfiguration.SmtpServer, emailConfiguration.SmtpPort, false);

                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate(emailConfiguration.UserName, emailConfiguration.Password);

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
