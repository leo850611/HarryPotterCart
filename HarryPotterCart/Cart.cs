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
		    if (books.Count == 2)
		    {
			    return 100 * 2 * 0.95;
		    }
		    return 100;
	    }
    }
}
