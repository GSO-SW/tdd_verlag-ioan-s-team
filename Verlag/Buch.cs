using System;
using System.Net;

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage;
        private string isbn;


        public Buch(string autor, string titel, int auflage) : this(autor, titel)
        {
            if (auflage < 1)
            {
                throw new ArgumentOutOfRangeException("Auflagenummer zu klein");
            }
            else
            {
                this.auflage = auflage;
            }
        }

        public Buch(string autor, string titel)
        {
            if (autor == "" || autor == "#" || autor == ";" || autor == "�" || autor == "%" || autor == null)
            {
                throw new ArgumentException("Name des Authors ist unzulässig");
            }
            else
            {
                this.autor = autor;
            }
            this.titel = titel;
            auflage = 1;
        }

        public string Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
            }
        }

        public string Titel
        {
            get
            {
                return titel;
            }
        }

        public int Auflage
        {
            get
            {
                return auflage;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Auflagenummer zu klein");
                }
                else
                {
                    auflage = value;
                }
            }
        }

        public string ISBN
        {
            get
            {
                return isbn;
            }
            set
            {
                if (value.Length == 13)
                {
                    int rechnungsErgebniss = 0;
                    for (int i = 0; i < 13; i++)
                    {
                        if (i == 0 || i == 2 || i == 5 || i == 7 || i == 9 || i == 11)
                        {
                            rechnungsErgebniss += Convert.ToInt32(value[i].ToString());
                        }
                        else if (i == 1 || i > 3)
                        {
                            rechnungsErgebniss += Convert.ToInt32(value[i].ToString()) * 3;
                        }
                    }
                    int pruefziffer = 10 - (rechnungsErgebniss % 10);
                    isbn = value + pruefziffer;
                } else
                {
                    isbn = value;
                }
            }
        }
    }
}
















