using GameOfLife_SZFT6_CS3;

Sejtek mezo = new();
SejtSzabaly sejtSzabaly = new();

// A játék kezdeti kiíratása, az alakzat kiválasztása.

Console.Clear();

for (int sor = 0; sor < 75; sor++)
{
    for (int oszlop = 0; oszlop < 75; oszlop++)
    {
        Console.Write(mezo.mezo[sor, oszlop] == 1 ? "█" : ".");
    }
    Console.WriteLine();
}

Thread.Sleep(1000);
