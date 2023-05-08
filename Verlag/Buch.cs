using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
using System.Net;
using System.Security.Cryptography.X509Certificates;
>>>>>>> 8ff97c2416f45ab3c4fb7a93f7166ae999c97209

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage;
<<<<<<< HEAD

        public Buch(string autor, string titel, int auflage)
        {
            this.autor = autor;
            this.titel = titel;
            if (auflage <= 0)
            {
                throw new ArgumentOutOfRangeException();
=======
        private ISBN isbn = new ISBN();


        public Buch(string autor, string titel, int auflage) : this(autor, titel)
        {
            if (auflage < 1)
            {
                throw new ArgumentOutOfRangeException("Auflagenummer zu klein");
>>>>>>> 8ff97c2416f45ab3c4fb7a93f7166ae999c97209
            }
            else
            {
                this.auflage = auflage;
            }
        }

        public Buch(string autor, string titel)
        {
<<<<<<< HEAD
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
=======
            if (autor == "" || autor == "#" || autor == ";" || autor == "�" || autor == "%" || autor == null)
            {
                throw new ArgumentException("Name des Authors ist unzulässig");
            }
            else
            {
                this.autor = autor;
>>>>>>> 8ff97c2416f45ab3c4fb7a93f7166ae999c97209
            }
            this.titel = titel;
            auflage = 1;
        }

        public string Autor
        {
<<<<<<< HEAD
            get { return autor; }
=======
            get
            {
                return autor;
            }
>>>>>>> 8ff97c2416f45ab3c4fb7a93f7166ae999c97209
            set
            {
                autor = value;
            }
        }

        public string Titel
        {
<<<<<<< HEAD
            get { return titel; }
=======
            get
            {
                return titel;
            }
>>>>>>> 8ff97c2416f45ab3c4fb7a93f7166ae999c97209
        }

        public int Auflage
        {
<<<<<<< HEAD
            get { return auflage; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
=======
            get
            {
                return auflage;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Auflagenummer zu klein");
>>>>>>> 8ff97c2416f45ab3c4fb7a93f7166ae999c97209
                }
                else
                {
                    auflage = value;
                }
            }
        }
<<<<<<< HEAD
    }

}

=======

        public string ISBN
        {
            get
            {
                return isbn.ISBN13;
            }
            set
            {
                isbn.ISBN13 = value;
            }
        }
        
    }
}



>>>>>>> 8ff97c2416f45ab3c4fb7a93f7166ae999c97209
