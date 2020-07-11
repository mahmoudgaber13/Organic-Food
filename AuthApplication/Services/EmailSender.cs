using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using SendGrid;
using SendGrid.Helpers.Mail;
using SendGrid.Helpers.Mail.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApplication.Services
{
    public class EmailSender : IEmailSender
    {
        public AuthMessageSenderOptions Options { get; }
        public EmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor)
        {
            Options = optionsAccessor.Value;
        }
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Execute(Options.SendGridKey, subject, message, email);
        }

        private Task Execute(string apiKey, string subject, string message, string email)
        {
            var Client = new SendGridClient(apiKey);
            var Msg = new SendGridMessage()
            {
                From = new EmailAddress("mahtiger201293@gmail.com", "night walkers"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            Msg.AddTo(new EmailAddress(email));
            Msg.SetClickTracking(false, false);
            return Client.SendEmailAsync(Msg);
        }
    }
}
