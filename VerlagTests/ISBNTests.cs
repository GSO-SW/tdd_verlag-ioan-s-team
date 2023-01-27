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
			Buch b = new Buch("Ioan Iancu", "titel");
			//Act
			b.ISBN = "978-3770436163";
			//Assert
			Assert.AreEqual("978-3770436163", b.ISBN);
        }

		[TestMethod]
		public void ISBN_PrueffzifferErgenzen()
		{
			//Arrange
			Buch b = new Buch("Ioan Iancu", "titel");
			//Act
			b.ISBN = "978-377043616";
			//b.ISBN = "978-381582086";
			//Assert
			Assert.AreEqual("978-3770436163", b.ISBN);
        }

		[TestMethod]
		public void ISBN_FromISBN13ToISBN10()
		{
			//Arrange
			Buch b = new Buch("Ioan Iancu", "title");
			b.ISBN = "978-3770436064";
			//Act
			string ISBN10 = b.ISBN10();
			//Assert
			Assert.AreEqual("3770436067", ISBN10);
        }
	}
}

