using System;
using System.Collections.Generic;
using System.Reflection;
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
			var checkout = _cart.Checkout(books);
			Assert.AreEqual(100, checkout);
		}

		[TestMethod]
		public void BuyEP12_190()
		{
			var books = new Dictionary<string, int>() { { "EP1", 1 }, { "EP2", 1 } };
			var checkout = _cart.Checkout(books);
			Assert.AreEqual(190, checkout);
		}

		[TestMethod]
		public void BuyEP123_270()
		{
			var books = new Dictionary<string, int>() { { "EP1", 1 }, { "EP2", 1 }, { "EP3", 1 } };
			var checkout = _cart.Checkout(books);
			Assert.AreEqual(270, checkout);
		}

		[TestMethod]
		public void BuyEP1234_320()
		{
			var books = new Dictionary<string, int>()
			{
				{ "EP1", 1 }, { "EP2", 1 }, { "EP3", 1 }, { "EP4", 1 }
			};
			var checkout = _cart.Checkout(books);
			Assert.AreEqual(320, checkout);
		}

		[TestMethod]
		public void BuyEP12345_375()
		{
			var books = new Dictionary<string, int>()
			{
				{ "EP1", 1 }, { "EP2", 1 }, { "EP3", 1 }, { "EP4", 1 } , { "EP5", 1 }
			};
			var checkout = _cart.Checkout(books);
			Assert.AreEqual(375, checkout);
		}
	}
}
