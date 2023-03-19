using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMarket.Database.Entities
{
	public class ImageEntity
	{
		public int Id { get; set; }
		public string Thumb { get; set; }
		public string Small { get; set; }
		public string Large { get; set; }

		public int CurrencyFK { get; set; }
		public CurrencyEntity Currency { get; set; }
	}
}
