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
        public void TestValidISBN13()
        {

            //Arranges
            string input = "978-3770436163";
            Buch b = new Buch("Walter Isaacson", "Steve Jobs");

            //Act
            b.ISBN = input;

            //Assert
            Assert.AreEqual(input, b.ISBN);
        }

        [TestMethod]
        public void TestPrüfzifferISBN()
        {

            //Arranges
            string ohneprüfziffer = "978377043614";
            string mitprüfziffer = "9783770436149";
            Buch b = new Buch("Walter Isaacson", "Steve Jobs");

            //Act
            b.ISBN = ohneprüfziffer;

            //Assert
            Assert.AreEqual(mitprüfziffer, b.ISBN);
        }

        public void TestISBN13NachISBN10()
        {

            //Arranges
            string ISBN13 = "9783770436064";
            string ISBN10 = "3770436067";
            Buch b = new Buch("Walter Isaacson", "Steve Jobs");

            //Act
            b.ISBN = ISBN13;

            //Assert
            Assert.AreEqual(ISBN10, b.ISBN10);
            
        }


    }
}
