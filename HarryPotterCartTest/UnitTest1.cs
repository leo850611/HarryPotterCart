using System;
using System.Collections.Generic;
using HarryPotterCart;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HarryPotterCartTest
{
	[TestClass]
	public class UnitTest1
	{
		private Cart _cart = new Cart();

		[TestMethod]
		public void BuyEP1_100()
		{
			var books = new Dictionary<string, int>() { { "EP1", 1 } };
			var money = _cart.Checkout(books);
			Assert.AreEqual(100, money);
		}

		[TestMethod]
		public void BuyEP12_190()
		{
			var books = new Dictionary<string, int>() { { "EP1", 1 }, { "EP2", 1 } };
			var money = _cart.Checkout(books);
			Assert.AreEqual(190, money);
		}

		[TestMethod]
		public void BuyEP123_270()
		{
			var books = new Dictionary<string, int>() { { "EP1", 1 }, { "EP2", 1 }, { "EP3", 1 } };
			var money = _cart.Checkout(books);
			Assert.AreEqual(270, money);
		}
	}
}
