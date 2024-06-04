using Fojatek;


ConsoleColor szin1 = ConsoleColor.Black;
ConsoleColor szin2 = ConsoleColor.Red;

Console.BackgroundColor = szin1;
Console.ForegroundColor = szin2;
Console.CursorVisible = false;

int életerő = 20;
int lényhp = 15;
Bevezetés();
Console.Clear();
Elsoszint();
Console.Clear();
Masodikszint();





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

        Console.WriteLine("Válassz az alábbiak közül:");
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

        if (opcio > 2)
        {
            opcio = 1;
        }

        if (opcio < 1)
        {
            opcio = 2;
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
        lényhp -= 5;
        Console.WriteLine("\nMMegtámadtad a lényt, ő vesztett 5 életerőt!");
        Console.WriteLine($"\nFenmaradó lény életerő {lényhp}");
    }
    else
    {
        életerő -= 1;
        Console.WriteLine("Védekeztél, ezért lény támadása, csak 1 életerőt csökkentett!");
        Console.WriteLine($"\nFenmaradó életerő {életerő}");
    }



}