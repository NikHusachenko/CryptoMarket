using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMarket.Desktop.FormsServices.CoinServices
{
	public class CoinService : ICoinService
	{
		public string FormatValueOrDefault(double? value)
		{
			if (value == null) return "No info";
			return value.ToString();
		}
	}
}
