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
			return CalculateFee(books, books.Max(p => p.Value));
		}

		private double CalculateFee(Dictionary<string, int> books, int index)
		{
			if (index > 0)
			{
				var count = books.Count(p => p.Value >= index);
				var total = UnitPrice * count * _discountLookUp[count];

				return total + CalculateFee(books, index - 1);
			}

			return 0;
		}

		private Dictionary<int, double> _discountLookUp = new Dictionary<int, double>()
		{
			{ 1, 1 }, { 2, 0.95 }, { 3, 0.9 }, { 4, 0.8 }, { 5, 0.75 }
		};
	}
}
