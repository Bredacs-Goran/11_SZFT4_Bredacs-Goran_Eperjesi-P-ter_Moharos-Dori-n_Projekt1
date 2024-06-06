using Fojatek;


ConsoleColor szin1 = ConsoleColor.Black;
ConsoleColor szin2 = ConsoleColor.Red;

Console.BackgroundColor = szin1;
Console.ForegroundColor = szin2;
Console.CursorVisible = false;

int életerő = 20;
int lényhp = 15;
int orcélet = 20;
int ütés = 5;
int bossélet = 30;
Bevezetés();
Console.Clear();
Elsoszint();
Console.Clear();
Masodikszint();
Console.Clear();
while (lényhp != 0)
{
    Harmadik();
    Console.Clear();
    if(életerő <= 0)
    {
        Console.WriteLine("Meghaltál, vége a játéknak!");
        Thread.Sleep(3000);
        Console.Clear();
        System.Environment.Exit(0);
    }
}
Console.WriteLine("Megölted a lényt, tovább haladhatsz a következő szintre, egy képesség választása után.");
Thread.Sleep(3000);
Console.Clear();
Képesség();
Console.Clear();
Negyedik();
Console.Clear();
while (orcélet <= 0)
{
    Otodik();
    Console.Clear();
    if (életerő <= 0)
    {
        Console.WriteLine("Meghaltál, vége a játéknak!");
        Thread.Sleep(3000);
        Console.Clear();
        System.Environment.Exit(0);
    }
}
Console.WriteLine("Megölted a lényt, tovább haladhatsz.");
Szoba();
Console.Clear();
Masodikszint();
Console.Clear();
while (lényhp != 0)
{
    Harmadik();
    Console.Clear();
    if (életerő <= 0)
    {
        Console.WriteLine("Meghaltál, vége a játéknak!");
        Thread.Sleep(3000);
        Console.Clear();
        System.Environment.Exit(0);
    }
}
Console.WriteLine("Megölted a lényt, tovább haladhatsz a következő szintre, egy képesség választása után.");
Képesség();
Boss();
Console.Clear();
while (bossélet <= 0)
{
    Bossloop();
    Console.Clear();
    if (életerő <= 0)
    {
        Console.WriteLine("Meghaltál, vége a játéknak!");
        Thread.Sleep(3000);
        Console.Clear();
        System.Environment.Exit(0);
    }
}
Console.Clear() ;
Console.WriteLine("Megynerted a játékot!");


void Bevezetés()
{




    int opcio = 1;
    bool kivalasztva = false;

    int x = Console.GetCursorPosition().Left;
    int y = Console.GetCursorPosition().Top;

    while (kivalasztva == false)
    {
        Console.SetCursorPosition(x, y);

        if (opcio > 1)
        {
            opcio = 1;
        }

        if (opcio < 1)
        {
            opcio = 1;
        }
        Console.WriteLine("Köszöntünk a Dungeon-Rush játékban!");
        Console.WriteLine("\nNyomd meg a gombot!:");

        if (opcio == 1)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tKezdődhet a játék!");

        

        Console.BackgroundColor = szin1;
        Console.ForegroundColor = szin2;

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.DownArrow:
                opcio++;
                break;
            case ConsoleKey.UpArrow:
                opcio--;
                break;
            case ConsoleKey.Enter:
                kivalasztva = true;
                break;
        }
    }











}

void Elsoszint()
{

    int opcio = 1;
    bool kivalasztva = false;

    int x = Console.GetCursorPosition().Left;
    int y = Console.GetCursorPosition().Top;

    while (kivalasztva == false)
    {
        Console.SetCursorPosition(x, y);

        if (opcio > 1)
        {
            opcio = 1;
        }

        if (opcio < 1)
        {
            opcio = 1;
        }

        Console.WriteLine("A gomb megnyomásával be tudsz lpni a dungeonba:");
        Console.WriteLine("\nJelenleg maximum életerővel rendelkezel (20)");
        if (opcio == 1)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tBelépés a dungeonba");


        Console.BackgroundColor = szin1;
        Console.ForegroundColor = szin2;

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.DownArrow:
                opcio++;
                break;
            case ConsoleKey.UpArrow:
                opcio--;
                break;
            case ConsoleKey.Enter:
                kivalasztva = true;
                break;
        }
    }




}

void Masodikszint()
{

    int opcio = 1;
    bool kivalasztva = false;

    int x = Console.GetCursorPosition().Left;
    int y = Console.GetCursorPosition().Top;

    while (kivalasztva == false)
    {
        Console.SetCursorPosition(x, y);

        if (opcio > 3)
        {
            opcio = 1;
        }

        if (opcio < 1)
        {
            opcio = 3;
        }
        Console.WriteLine("Szembejött egy ellenséges lény!");
        Console.WriteLine("\nVálassz az alábbiak közül:");

        if (opcio == 1)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tTámadás");

        if (opcio == 2)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tVédekezés");

        if (opcio == 3)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tSemmi");


        Console.BackgroundColor = szin1;
        Console.ForegroundColor = szin2;

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.DownArrow:
                opcio++;
                break;
            case ConsoleKey.UpArrow:
                opcio--;
                break;
            case ConsoleKey.Enter:
                kivalasztva = true;
                break;
        }

    }
  
    if (opcio == 1)
    {
        lényhp -= ütés;
        Console.WriteLine($"\nMegtámadtad a lényt, ő vesztett {ütés} életerőt!");
        Console.WriteLine($"\nFenmaradó lény életerő {lényhp}");
    }
    else if(opcio == 2)
    {
        életerő -= 1;
        Console.WriteLine("Védekeztél, ezért lény támadása, csak 1 életerőt csökkentett!");
        Console.WriteLine($"\nFenmaradó életerő {életerő}");
    }
    else
    {
        életerő -= 3;
        Console.WriteLine("Nem tettél semmit, ezért lény megtámadott, és 3 életerőt csökkentett!");
        Console.WriteLine($"\nFenmaradó életerő {életerő}");
    }


    Thread.Sleep(2000);

}

void Harmadik()
{
    

    int opcio = 1;
    bool kivalasztva = false;

    int x = Console.GetCursorPosition().Left;
    int y = Console.GetCursorPosition().Top;

    while (kivalasztva == false)
    {
        Console.SetCursorPosition(x, y);

        if (opcio > 3)
        {
            opcio = 1;
        }

        if (opcio < 1)
        {
            opcio = 3;
        }
        Console.WriteLine("A lénynek már nem kell sok!");
        Console.WriteLine("\nVálassz az alábbiak közül:");

        if (opcio == 1)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tTámadás");

        if (opcio == 2)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tVédekezés");

        if (opcio == 3)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tSemmi");


        Console.BackgroundColor = szin1;
        Console.ForegroundColor = szin2;

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.DownArrow:
                opcio++;
                break;
            case ConsoleKey.UpArrow:
                opcio--;
                break;
            case ConsoleKey.Enter:
                kivalasztva = true;
                break;
        }

    }

    if (opcio == 1)
    {
        lényhp -= ütés;
        Console.WriteLine($"\nMegtámadtad a lényt, ő vesztett {ütés} életerőt!");
        Console.WriteLine($"\nFenmaradó lény életerő {lényhp}");
    }
    else if (opcio == 2)
    {
        életerő -= 1;
        Console.WriteLine("Védekeztél, ezért lény támadása, csak 1 életerőt csökkentett!");
        Console.WriteLine($"\nFenmaradó életerő {életerő}");
    }
    else
    {
        életerő -= 3;
        Console.WriteLine("Nem tettél semmit, ezért lény megtámadott, és 3 életerőt csökkentett!");
        Console.WriteLine($"\nFenmaradó életerő {életerő}");
    }

    Thread.Sleep(2000);
}

void Képesség()
{


    int opcio = 1;
    bool kivalasztva = false;

    int x = Console.GetCursorPosition().Left;
    int y = Console.GetCursorPosition().Top;

    while (kivalasztva == false)
    {
        Console.SetCursorPosition(x, y);

        if (opcio > 3)
        {
            opcio = 1;
        }

        if (opcio < 1)
        {
            opcio = 3;
        }
        Console.WriteLine("Szereztél egy képességet!");
        Console.WriteLine("\nVálassz az alábbi három lehetőség közül:");

        if (opcio == 1)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tÜtés");

        if (opcio == 2)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tVédés bónusz");

        if (opcio == 3)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }
        Console.WriteLine("\t\tFutás");

        Console.BackgroundColor = szin1;
        Console.ForegroundColor = szin2;

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.DownArrow:
                opcio++;
                break;
            case ConsoleKey.UpArrow:
                opcio--;
                break;
            case ConsoleKey.Enter:
                kivalasztva = true;
                break;
        }

    }

    if (opcio == 1)
    {
        ütés+=3;
        Console.Clear();
        Console.WriteLine("Mivel az ütés képességet választottad, mostmár három ponttal többet sebzel! :DDD");
        Thread.Sleep(3000);
    }
    else if(opcio == 2)
    {
        Console.Clear();
        Console.WriteLine("Mivel a védekező képességet választottad, nem kapsz semmi bonuszt, rossz választás.");
        Thread.Sleep(3000);
    }
    else
    {
        Console.WriteLine("A futást választottad, elszaladtál és vége a játéknak!");
        Thread.Sleep(3000);
        Console.Clear();
        System.Environment.Exit(0);
    }

}

void Negyedik()
{


    int opcio = 1;
    bool kivalasztva = false;

    int x = Console.GetCursorPosition().Left;
    int y = Console.GetCursorPosition().Top;

    while (kivalasztva == false)
    {
        Console.SetCursorPosition(x, y);

        if (opcio > 3)
        {
            opcio = 1;
        }

        if (opcio < 1)
        {
            opcio = 3;
        }
        Console.WriteLine("Tovább jutottál!");
        Console.WriteLine("Szembejött egy új elenség, az Orc.");
        Console.WriteLine("Az Orcnak több élete van, mint annak a lénynek, akivel az előző szinten megküzőttél!");
        Console.WriteLine("\nVálassz az alábbiak közül:");

        if (opcio == 1)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tTámadás");

        if (opcio == 2)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tVédekezés");

        if (opcio == 3)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tSemmi");


        Console.BackgroundColor = szin1;
        Console.ForegroundColor = szin2;

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.DownArrow:
                opcio++;
                break;
            case ConsoleKey.UpArrow:
                opcio--;
                break;
            case ConsoleKey.Enter:
                kivalasztva = true;
                break;
        }

    }

    if (opcio == 1)
    {
        lényhp -= ütés;
        Console.WriteLine($"\nMegtámadtad a lényt, ő vesztett {ütés} életerőt!");
        Console.WriteLine($"\nFenmaradó lény életerő {lényhp}");
    }
    else if(opcio == 2)
    {
        életerő -= 3;
        Console.WriteLine("Védekeztél, ezért lény támadása, csak 3 életerőt csökkentett!");
        Console.WriteLine($"\nFenmaradó életerő {életerő}");
    }
    else
    {
        életerő -= 6;
        Console.WriteLine("Nem tettél semmit, ezért lény megtámadott, és 6 életerőt csökkentett!");
        Console.WriteLine($"\nFenmaradó életerő {életerő}");
    }

    Thread.Sleep(3000);

}

void Otodik()
{


    int opcio = 1;
    bool kivalasztva = false;

    int x = Console.GetCursorPosition().Left;
    int y = Console.GetCursorPosition().Top;

    while (kivalasztva == false)
    {
        Console.SetCursorPosition(x, y);

        if (opcio > 3)
        {
            opcio = 1;
        }

        if (opcio < 1)
        {
            opcio = 3;
        }

        Console.WriteLine("Győz le az Orcot!");
        Console.WriteLine("\nVálassz az alábbiak közül:");

        if (opcio == 1)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tTámadás");

        if (opcio == 2)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tVédekezés");

        if (opcio == 3)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tSemmi");


        Console.BackgroundColor = szin1;
        Console.ForegroundColor = szin2;

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.DownArrow:
                opcio++;
                break;
            case ConsoleKey.UpArrow:
                opcio--;
                break;
            case ConsoleKey.Enter:
                kivalasztva = true;
                break;
        }

    }

    if (opcio == 1)
    {
        lényhp -= ütés;
        Console.WriteLine($"\nMegtámadtad a lényt, ő vesztett {ütés} életerőt!");
        Console.WriteLine($"\nFenmaradó lény életerő {lényhp}");
    }
    else if (opcio == 2)
    {
        életerő -= 3;
        Console.WriteLine("Védekeztél, ezért lény támadása, csak 3 életerőt csökkentett!");
        Console.WriteLine($"\nFenmaradó életerő {életerő}");
    }
    else
    {
        életerő -= 6;
        Console.WriteLine("Nem tettél semmit, ezért lény megtámadott, és 6 életerőt csökkentett!");
        Console.WriteLine($"\nFenmaradó életerő {életerő}");
    }

    Thread.Sleep(3000);

}

void Szoba()
{
    int opcio = 1;
    bool kivalasztva = false;

    int x = Console.GetCursorPosition().Left;
    int y = Console.GetCursorPosition().Top;

    while (kivalasztva == false)
    {
        Console.SetCursorPosition(x, y);

        if (opcio > 2)
        {
            opcio = 1;
        }

        if (opcio < 1)
        {
            opcio = 2;
        }
        Console.WriteLine("Találtál egy gyanús szobát!");
        Console.WriteLine("\nVálassz az alábbiak közül:");

        if (opcio == 1)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tBemész");

        if (opcio == 2)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tNem mész be");



        Console.BackgroundColor = szin1;
        Console.ForegroundColor = szin2;

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.DownArrow:
                opcio++;
                break;
            case ConsoleKey.UpArrow:
                opcio--;
                break;
            case ConsoleKey.Enter:
                kivalasztva = true;
                break;
        }

    }

    if (opcio == 1)
    {
        életerő += 10;
        Console.WriteLine($"\nA szobában volt egy doktor, aki 10 életerőt adott neked!");
        Console.WriteLine($"\nFenmaradó életerő {életerő}");
    }
    else
    {
        Console.WriteLine("Tovább haladtál");
        Console.WriteLine($"\nFenmaradó életerő {életerő}");
    }


    Thread.Sleep(2000);

}

void Boss()
{
    int opcio = 1;
    bool kivalasztva = false;

    int x = Console.GetCursorPosition().Left;
    int y = Console.GetCursorPosition().Top;

    while (kivalasztva == false)
    {
        Console.SetCursorPosition(x, y);

        if (opcio > 3)
        {
            opcio = 1;
        }

        if (opcio < 1)
        {
            opcio = 3;
        }
        Console.WriteLine("Tovább jutottál!");
        Console.WriteLine("Meg kell küzened a Boss-al");
        Console.WriteLine("A Boss a legerősebb ellenség  játékban!");
        Console.WriteLine("\nVálassz az alábbiak közül:");

        if (opcio == 1)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tTámadás");

        if (opcio == 2)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tVédekezés");

        if (opcio == 3)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tSemmi");


        Console.BackgroundColor = szin1;
        Console.ForegroundColor = szin2;

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.DownArrow:
                opcio++;
                break;
            case ConsoleKey.UpArrow:
                opcio--;
                break;
            case ConsoleKey.Enter:
                kivalasztva = true;
                break;
        }

    }

    if (opcio == 1)
    {
        bossélet -= ütés;
        Console.WriteLine($"\nMegtámadtad a Boss-t, ő vesztett {ütés} életerőt!");
        Console.WriteLine($"\nFenmaradó lény életerő {bossélet}");
    }
    else if (opcio == 2)
    {
        életerő -= 5;
        Console.WriteLine("Védekeztél, ezért Boss támadása, csak 5 életerőt csökkentett!");
        Console.WriteLine($"\nFenmaradó életerő {életerő}");
    }
    else
    {
        életerő -= 10;
        Console.WriteLine("Nem tettél semmit, ezért lény megtámadott, és 10 életerőt csökkentett!");
        Console.WriteLine($"\nFenmaradó életerő {életerő}");
    }

    Thread.Sleep(3000);
}

void Bossloop()
{
    int opcio = 1;
    bool kivalasztva = false;

    int x = Console.GetCursorPosition().Left;
    int y = Console.GetCursorPosition().Top;

    while (kivalasztva == false)
    {
        Console.SetCursorPosition(x, y);

        if (opcio > 3)
        {
            opcio = 1;
        }

        if (opcio < 1)
        {
            opcio = 3;
        }

        Console.WriteLine("Győz le a Boss-t!");
        Console.WriteLine("\nVálassz az alábbiak közül:");

        if (opcio == 1)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tTámadás");

        if (opcio == 2)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tVédekezés");

        if (opcio == 3)
        {
            Console.BackgroundColor = szin2;
            Console.ForegroundColor = szin1;
        }
        else
        {
            Console.BackgroundColor = szin1;
            Console.ForegroundColor = szin2;
        }

        Console.WriteLine("\t\tSemmi");


        Console.BackgroundColor = szin1;
        Console.ForegroundColor = szin2;

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.DownArrow:
                opcio++;
                break;
            case ConsoleKey.UpArrow:
                opcio--;
                break;
            case ConsoleKey.Enter:
                kivalasztva = true;
                break;
        }

    }

    if (opcio == 1)
    {
        bossélet -= ütés;
        Console.WriteLine($"\nMegtámadtad a Boss-t, ő vesztett {ütés} életerőt!");
        Console.WriteLine($"\nFenmaradó lény életerő {bossélet}");
    }
    else if (opcio == 2)
    {
        életerő -= 5;
        Console.WriteLine("Védekeztél, ezért Boss támadása, csak 5 életerőt csökkentett!");
        Console.WriteLine($"\nFenmaradó életerő {életerő}");
    }
    else
    {
        életerő -= 10;
        Console.WriteLine("Nem tettél semmit, ezért lény megtámadott, és 10 életerőt csökkentett!");
        Console.WriteLine($"\nFenmaradó életerő {életerő}");
    }

    Thread.Sleep(3000);
}