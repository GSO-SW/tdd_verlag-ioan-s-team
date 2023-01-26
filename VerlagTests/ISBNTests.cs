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
	}
}

