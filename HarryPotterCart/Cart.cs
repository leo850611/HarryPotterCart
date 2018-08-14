using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterCart
{
	public class Cart
	{
		public double Checkout(Dictionary<string, int> books)
		{
			var total = 0d;
			var maxBook = books.Max(p => p.Value);
			for (int i = maxBook; i > 0; i--)
			{
				var count = books.Count(p => p.Value >= i);
				var money = 100 * count;
				total += money * _discountLookUp[count];
			}
			return total;
		}

		private Dictionary<int, double> _discountLookUp = new Dictionary<int, double>()
		{
			{ 1, 1 }, { 2, 0.95 }, { 3, 0.9 }, { 4, 0.8 }, { 5, 0.75 }
		};

	}
}
