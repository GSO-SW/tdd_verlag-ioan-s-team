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
        public void TestValidISBN13TestValidISBN13()
        {

            //Arrange
            string input = "978-3770436163";
            Buch b = new Buch("Walter Isaacson", "Steve Jobs");

            //Act
            b.ISBN = input;

            //Assert
            Assert.AreEqual(input, b.ISBN);
        }

    }
}
