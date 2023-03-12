using CryptoMarket.Common;
using CryptoMarket.Services.Response;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace CryptoMarket.Services.EmailService
{
    public class SendGridService : IEmailSenderService
    {
        private readonly SendGridClient _client;

        public SendGridService()
        {
            _client = new SendGridClient(SendGridConfiguration.API_KEY);
        }

        public async Task<ResponseService> SendEmail(string emailTo, string nameTo, string message)
        {
            EmailAddress from = new EmailAddress(SendGridConfiguration.EMAIL_FROM, SendGridConfiguration.NAME_FROM);
            EmailAddress to = new EmailAddress(emailTo, nameTo);

            SendGridMessage sendGridMessage = new SendGridMessage()
            {
                From = from,
                Subject = SendGridConfiguration.EMAIL_TITLE,
                HtmlContent = message,
            };
            sendGridMessage.AddTo(emailTo, nameTo);

            try
            {
                var response = await _client.SendEmailAsync(sendGridMessage);
                return ResponseService.Ok();
            }
            catch(Exception ex)
            {
                return ResponseService.Error(ex.Message);
            }
        }
    }
}