using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage;

        public Buch(string autor, string titel, int auflage) : this(autor,titel)
        {
            this.autor = autor;
            this.titel = titel;
            this.auflage = auflage;
        }

        public Buch(string autor, string titel)
        {
            this.autor = autor;
            this.titel = titel;
        }


        public string Autor   
        {
            set { this.autor = value; }
            get { return autor; }   
        }

        public string Titel   
        {
            get { return titel; }   
        }

        public int Auflage   
        {
            set { this.Auflage = value; }
            get { return auflage; }  
        }


    }
}
