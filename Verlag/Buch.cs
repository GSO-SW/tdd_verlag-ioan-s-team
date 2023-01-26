﻿using System;
using System.Net;

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage;
        private string isbn;
        private string isbn10;

        
        public string ConvertISBN13to10(string ISBN13)
        {
            // remove the prefix "978"

            if (isbn.Contains("-"))
            {
                isbn10 = isbn.Remove(0, 4);
            }
            else
            {
                isbn10 = isbn.Remove(0, 3);
            }
            
            

            // calculate the check digit using the ISBN-10 algorithm
            int sum = 0;
            for (int i = 0; i < isbn10.Length - 1; i++)
            {
                sum += (10 - i) * (isbn10[i] - '0');
            }
            int checkDigit = 11 - (sum % 11);
            if (checkDigit == 10)
            {
                checkDigit = 'X';
            }
            else if (checkDigit == 11)
            {
                checkDigit = '0';
            }
            // append the check digit to the ISBN-13 number
            isbn10 += checkDigit;// remove the prefix "978"
            isbn10 = isbn10.Remove(9,1);
            return isbn10;
        }

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

        public string ISBN
        {
            get
            {
                return isbn;
            }
            set
            {
                isbn = value;
                ConvertISBN13to10(isbn);
            }
        }

        public string ISBN10
        {
            get
            {
                return isbn10;
            }
            set
            {
                
                isbn10 = value;

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

        
    }
}

