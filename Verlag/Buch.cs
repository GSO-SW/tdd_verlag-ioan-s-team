using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Verlag
{
    internal class Buch
    {
        private string Autor;
        private string Titel;
        private int Auflage;

        public Buch(string autor, string titel, int auflage)
        {
            this.Autor = autor;
            this.Titel = titel;
            this.Auflage = auflage;
        }

        public string autor   // property
        {
            get { return autor; }   // get method
        }

        public string titel   // property
        {
            get { return titel; }   // get method
        }

        public int auflage   // property
        {
            get { return auflage; }   // get method
        }


    }
}
