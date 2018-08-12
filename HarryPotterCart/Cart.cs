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
		    var money = 100 * books.Count;
		    if (books.Count == 2)
		    {
			    return money * 0.95;
		    }

		    return money;
	    }
    }
}
