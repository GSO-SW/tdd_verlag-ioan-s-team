using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Verlag;

namespace VerlagTests
{
	[TestClass]
	public class ISBNTests
	{
		[TestMethod]
		public void ISBN_KannEingegebenWerden()
		{
			//Arrange
			ISBN b = new ISBN();
			//Act
			b.isbn = "978-3770436163";
			//Assert
			Assert.AreEqual("978-3770436163", b.isbn);
        }

		[TestMethod]
		public void ISBN_PrueffzifferErgenzen()
		{
			//Arrange
			ISBN b = new ISBN();
			//Act
			b.isbn = "978-377043616";
			//b.ISBN = "978-381582086";
			//Assert
			Assert.AreEqual("978-3770436163", b.isbn);
        }

		[TestMethod]
		public void ISBN_FromISBN13ToISBN10()
		{
			//Arrange
			ISBN b = new ISBN();
			b.isbn = "978-3770436064";
			//Act
			string ISBN10 = b.ISBN10();
			//Assert
			Assert.AreEqual("3770436067", ISBN10);
        }
	}
}

