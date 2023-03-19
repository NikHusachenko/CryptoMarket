using CryptoMarket.Common;
using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework.Repository;
using Newtonsoft.Json;

namespace CryptoMarket.Services.PingServices
{
	public class PingService : IPingService
	{
		private readonly IGenericRepository<PingEntity> _pingRepository;

		public PingService(IGenericRepository<PingEntity> pingRepository)
		{
			_pingRepository = pingRepository;
		}

		public void Create(PingEntity entity)
		{
			_pingRepository.Create(entity);
		}

		public async Task<PingEntity> GetAPIServerStatusAsync()
		{
			try
			{
				var client = new HttpClient();
				var message = await client.GetAsync($"{CoinGrecko.PING}");
				message.EnsureSuccessStatusCode();
				var context = await message.Content.ReadAsStringAsync();
				var status = JsonConvert.DeserializeObject<PingEntity>(context);
				return status;
			}
			catch (Exception ex)
			{
				return null;
			}
		}
	}
}
