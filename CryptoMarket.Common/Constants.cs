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
        public const string USER_NOT_FOUND_ERROR = "User not found";
        public const string CREATE_ERROR = "Didn't create. Something went wrong";
        public const string UPDATE_ERROR = "Didn't update. Something went wrong";
        public const string SERVER_DOWN = "The Server is down";

	}

    public class SuccessMessages
    {
        public const string REGISTRATION_SUCCESSFULY = "Registration successfuly";
    }

    public class Styles
    {

    }
    public class MarketFormConstants
    {
		public const int COINS_ON_PAGE = 152;
        public const int FIRST_COIN_ID = 28234;
        public const int TOTAL_NUMBER_OF_COINS = 11143;
	}
}