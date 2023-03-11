using CryptoMarket.Services.Response;

namespace CryptoMarket.Services.EmailService
{
    public interface IEmailSenderService
    {
        Task<ResponseService> SendEmail(string emailTo, string nameTo, string message);
    }
}