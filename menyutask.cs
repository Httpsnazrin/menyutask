Console.WriteLine("Menyu ile tanis ola bilersiniz: ");
Console.WriteLine("1 - Suplar");
Console.WriteLine("2 - Ana yemekler");
Console.WriteLine("3 - Içkiler");
Console.WriteLine("4 - Desertler");
int choice=Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        Console.WriteLine("Suplar:");
        Console.WriteLine("1.Pomidor supu");
        Console.WriteLine("2.Gobelek supu");
        Console.WriteLine("3.Merci supu");

        int sup = Convert.ToInt32(Console.ReadLine());
        switch (sup)
        {
            case 1:
                Console.WriteLine("Pomidor supu sifaris edildi.");
                break;
            case 2:
                Console.WriteLine("Gobelek supu sifaris edildi.");
                break;
            case 3:
                Console.WriteLine("Merci supu sifaris edildi.");
                break;
            
        }
       
        break;
    case 2:
        Console.WriteLine("Ana yemekler:");
        Console.WriteLine("1.Fast Food");
        Console.WriteLine("2.Dolma");
        Console.WriteLine("3.Plov");
        int anaYemek = Convert.ToInt32(Console.ReadLine());
        switch (anaYemek)
        {
            case 1:
                Console.WriteLine("Fast Food sifaris edildi.");
                break;
            case 2:
                Console.WriteLine("Dolma sifaris edildi.");
                break;
            case 3:
                Console.WriteLine("Plov sifaris edildi.");
                break;

        }
        break;
    case 3:
        Console.WriteLine("Ickiler :");
        Console.WriteLine("1.Meyve siresi");
        Console.WriteLine("2.Kofe");
        Console.WriteLine("3.Cay");
        int icki = Convert.ToInt32(Console.ReadLine());
        switch (icki)
        {
            case 1:
                Console.WriteLine("Meyve sifaris edildi.");
                break;
            case 2:
                Console.WriteLine("Kofeler :");
                Console.WriteLine("1.Capucino");
                Console.WriteLine("2.Latte");
                Console.WriteLine("3.Americano");
                int kofe=Convert.ToInt32(Console.ReadLine());

                switch (kofe)
                {
                   
                    case 1:
                        Console.WriteLine("Capucino sifaris edildi.");
                        break;
                    case 2:
                        Console.WriteLine("Latte sifaris edildi.");
                        break;
                    case 3:
                        Console.WriteLine("Americano sifaris edildi.");
                        break;
                }
                break;
            case 3:
                Console.WriteLine("Cay sifaris edildi.");
                break;

        }
        break;
    case 4:
        Console.WriteLine("Desertler:");
        Console.WriteLine("1.San Sebastian");
        Console.WriteLine("2.Turk paxlavasi");
        Console.WriteLine("3.Ekler");
        Console.WriteLine("4.Trimasu");
        int desert=Convert.ToInt32(Console.ReadLine());
        switch (desert)
        {
            case 1:
                Console.WriteLine("San Sebastian sifaris edildi.");
                break;
            case 2:
                Console.WriteLine("Turk paxlavasi sifaris edildi.");
                break;
            case 3:
                Console.WriteLine("Ekler sifaris edildi.");
                break;
            case 4:
                Console.WriteLine("Trimasu sifaris edildi.");
                break;

        }
        break;
    default : 
        Console.WriteLine("Menyuda bele bir yemek yoxdur.");
        break;
}
