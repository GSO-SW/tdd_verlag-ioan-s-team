using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage;
        private string isbn;
        public Buch(string autor, string titel, string isbn) : this(autor, titel)
        {
            this.isbn = isbn;
        }

        public Buch(string autor, string titel, int auflage, string isbn) : this(autor, titel, auflage)
        {
            this.isbn = isbn;
        }

        public Buch(string autor, string titel, int auflage) : this(autor, titel)
        {
            if (auflage <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                this.auflage = auflage;
            }
        }

        public Buch(string autor, string titel)
        {
            switch (autor)
            {
                case "":
                case "#":
                case ";":
                case "§":
                case "%":
                    throw new ArgumentException();
                default:
                    this.autor = autor;
                    break;
            }
            this.titel = titel;
            auflage = 1;
        }


        public string Autor
        {
            get { return autor; }
            set
            {
                autor = value;
            }
        }

        public string Titel
        {
            get { return titel; }
        }

        public int Auflage
        {
            get { return auflage; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    auflage = value;
                }
            }
        }

        public string ISBN
        {
            get { return isbn; }
        }
    }

}

