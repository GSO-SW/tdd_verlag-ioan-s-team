using System;
using System.Runtime.CompilerServices;

namespace Verlag
{
	public class ISBN
	{
        public string isbnIntern;

		public ISBN()
		{
		}


        public string ISBN13
        {
            get
            {
                return isbnIntern;
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
                    isbnIntern = value + pruefziffer;
                }
                else
                {
                    isbnIntern = value;
                }
            }
        }

        public string ISBN10()
        {
            string isbn10OhnePruefZiffer = "";
            string isbn10 = "";
            int isbn10PruefzifferOhneModulo = 0;
            int isbn10Pruefziffer = 0;
            for (int i = 4; i < 13; i++)
            {
                isbn10OhnePruefZiffer += isbnIntern[i];
            }

            for (int i = 0; i < 9; i++)
            {
                isbn10PruefzifferOhneModulo += Convert.ToInt32(isbn10OhnePruefZiffer[i].ToString()) * (i + 1);
            }

            isbn10Pruefziffer = isbn10PruefzifferOhneModulo % 11;

            isbn10 = isbn10OhnePruefZiffer + isbn10Pruefziffer.ToString();
            return isbn10;
        }
    }
}

