// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");






    int gerade = 0;
    int ungerade = 0;
    string cache = "";
    string isbn = "978377043614";

    if (isbn.Length == 12)
    {
        for (int i = 0; i < 12; i++)
        {
            if (i % 2 == 0)
            {
                gerade += Convert.ToInt32(isbn[i].ToString());
                Console.WriteLine("isbn index " + isbn[i] + "gerade = " +  gerade);
            }
            else
            {
                ungerade += Convert.ToInt32(isbn[i].ToString()) ;
               Console.WriteLine("isbn index " + isbn[i] + " ungerade = " + ungerade);
        }

            
        }

        ungerade *= 3;
        Console.WriteLine("gerade * 3 = " + gerade);

        cache = Convert.ToString(gerade + ungerade);
        Console.WriteLine("gerade + ungerade = " + cache);

        cache = Convert.ToString(cache[cache.Length - 1]);
        Console.WriteLine("cache letzte ziffer" + cache);

        cache = Convert.ToString(10 - Convert.ToInt32(cache));
        Console.WriteLine("10 - cache " + cache);    

        isbn = $"{isbn}{cache}";

        Console.WriteLine("isbn: " + isbn);

        Console.ReadLine();

    }


