namespace CryptoMarket.Common
{
    public class SendGridConfiguration
    {
        public const string EMAIL_FROM = "kkolyann99kkolyann@gmail.com";
        public const string NAME_FROM = "CryptoMarket";
        public const string API_KEY = "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";
        public const string EMAIL_TITLE = "You have message from CryptoMarket!";
    }

    public class DbConfiguration
    {
        public const string DEFAULT_CONNECTION = "Data Source=localhost;Database=CryptoMarketDb;Trusted_Connection=True;Encrypt=false";
    }

    public class Errors
    {
        public const string USER_IS_EXISTING_ERROR = "User with such email or login is existing";
        public const string CREATE_ERROR = "Didn't create. Something went wrong";
    }

    public class Styles
    {

    }
}