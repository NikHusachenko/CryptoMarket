using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework.Repository;
using Newtonsoft.Json;

namespace CryptoMarket.Services.PingServices
{
	public class PingService
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
				var message = await client.GetAsync(@"https://api.coingecko.com/api/v3/ping");
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
