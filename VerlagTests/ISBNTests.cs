using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verlag;

namespace VerlagTests
{
    [TestClass]
    public class ISBNTests
    {
        [TestMethod]
        public void Buch_KannISBNBekommen()
        {
            //Arrange
            string isbn = "978-3770436163";

            //Act
            Buch b = new Buch("autor", "titel", isbn);
            Buch c = new Buch("autor", "titel", 14, isbn);

            //Assert
            Assert.AreEqual(isbn, b.ISBN);
            Assert.AreEqual(isbn, c.ISBN);
        }
    }
}
