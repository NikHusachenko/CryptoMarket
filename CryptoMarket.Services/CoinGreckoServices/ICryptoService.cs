using CryptoMarket.Services.Response;

namespace CryptoMarket.Services.CoinGreckoServices
{
    public interface ICryptoService
    {
	       Task<ResponseService> CheckApiStatusAsync();

	}
}