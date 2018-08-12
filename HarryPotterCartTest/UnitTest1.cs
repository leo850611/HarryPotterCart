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
			var money = cart.Checkout(books);
			Assert.AreEqual(100, money);
		}
	}
}
