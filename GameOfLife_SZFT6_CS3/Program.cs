using GameOfLife_SZFT6_CS3;


SejtSzabaly sejtSzabaly = new();

// A játék kezdeti kiíratása, az alakzat kiválasztása.
sejtSzabaly.KezdoTer();

// Itt lesz a játék fejleményei, SejtSzabály vizsgálata
while (true)
{
    // Ha escape gombot nyom az ember, akkor álljon le a program
    if (Console.KeyAvailable)
    {
        var kilep = Console.ReadKey(true).Key;
        if (kilep == ConsoleKey.Escape)
        {
            break;
        }
    }

    // Konkrétan a sejtek változásának metódusa
    sejtSzabaly.Szomszedok();
    Thread.Sleep(5000);
}