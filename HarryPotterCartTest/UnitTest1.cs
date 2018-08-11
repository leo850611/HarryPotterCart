using System;
using System.Collections.Generic;
using HarryPotterCart;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HarryPotterCartTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void BuyEP1_100()
		{
			var cart = new Cart();
			var books = new Dictionary<string, int>() {{"EP1", 1}};
			cart.BuyEpisode(books);
			var money = cart.Checkout();
			Assert.Equals(100, money);
		}
	}
}
