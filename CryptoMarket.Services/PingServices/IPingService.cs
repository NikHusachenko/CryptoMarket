using CryptoMarket.Database.Entities;

namespace CryptoMarket.Services.PingServices
{
	public interface IPingService
	{
		public void Create(PingEntity entity);

		public Task<PingEntity> GetAPIServerStatusAsync();
	}
}
