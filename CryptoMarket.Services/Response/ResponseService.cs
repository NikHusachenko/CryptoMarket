namespace CryptoMarket.Services.Response
{
    public class ResponseService
    {
        public bool IsError { get; set; }
        public string ErrorMessage { get; set; }

        public static ResponseService Ok()
        {
            return new ResponseService()
            {
                IsError = false,
            };
        }

        public static ResponseService Error(string message)
        {
            return new ResponseService()
            {
                ErrorMessage = message,
                IsError = true,
            };
        }
    }

    public class ResponseService<T> where T : class
    {
        public bool IsError { get; set; }
        public string ErrorMessage { get; set; }
        public T Value { get; set; }

        public static ResponseService<T> Ok(T value)
        {
            return new ResponseService<T>()
            {
                Value = value,
                IsError = false,
            };
        }

        public static ResponseService<T> Error(string message)
        {
            return new ResponseService<T>()
            {
                IsError = true,
                ErrorMessage = message,
            };
        }
    }
}