using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterCart
{
	public class Cart
	{
		private const int UnitPrice = 100;

		public double Checkout(Dictionary<string, int> books)
		{
			var total = 0d;
			for (int i = books.Max(p => p.Value); i > 0; i--)
			{
				var count = books.Count(p => p.Value >= i);
				total += UnitPrice * count * _discountLookUp[count];
			}
			return total;
		}

		private Dictionary<int, double> _discountLookUp = new Dictionary<int, double>()
		{
			{ 1, 1 }, { 2, 0.95 }, { 3, 0.9 }, { 4, 0.8 }, { 5, 0.75 }
		};
	}
}
