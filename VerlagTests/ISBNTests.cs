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

        [TestMethod]
        public void Pruefziffer_KannErrechnetWerden()
        {
            //Arrange 
            string isbnOhnePrufeziffer = "978-377043614";
            string isbnMitPruefziffer = "978-3770436149";

            //Act 
            Buch b = new Buch("Titel", "Autor", isbnOhnePrufeziffer);
            Buch c = new Buch("Autor", "Titel", 25, isbnOhnePrufeziffer);

            //Asseert
            Assert.AreEqual(isbnMitPruefziffer, b.ISBN);
            Assert.AreEqual(isbnMitPruefziffer, c.ISBN);

        }

        //[TestMethod]
        //public void ISBN13zuISBN10()
        //{
        //    //Arrange 
        //    string isbn13 = "978-3770436064";
        //    Buch b = new Buch("Titel", "Autor", isbn13);
        //    string ergebnis = "3770436067";

        //    //Act
        //    string isbn10 = b.ISBN10Umrechnen();

        //    //Assert
        //    Assert.AreEqual(ergebnis, isbn10);
        //}


    }
}
