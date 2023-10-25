using GameOfLife_SZFT6_CS3;


SejtSzabaly sejtSzabaly = new();

// A játék kezdeti kiíratása, az alakzat kiválasztása.
sejtSzabaly.KezdoTer();

int index = 0;

// Itt lesz a játék fejleményei, SejtSzabály vizsgálata
while (index < 100)
{
    sejtSzabaly.Szomszedok();
    Thread.Sleep(3000);
    index++;
}
