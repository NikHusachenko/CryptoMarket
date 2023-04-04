using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMarket.Desktop.FormsServices.CoinServices
{
	public interface ICoinService
	{
		string FormatValueOrDefault(double? value);
	}
}
