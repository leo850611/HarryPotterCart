using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterCart
{
	public class Cart
	{
		private Dictionary<int, double> _discountLookUp = new Dictionary<int, double>() { { 1, 1 }, { 2, 0.95 }, { 3, 0.9 } };

		public double Checkout(Dictionary<string, int> books)
		{
			var money = 100 * books.Count;
			return money * _discountLookUp[books.Count];
		}
	}
}
