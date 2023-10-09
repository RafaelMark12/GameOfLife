using GameOfLife_SZFT6_CS3;

Sejtek mezo = new();

Console.Clear();

for (int i = 0; i < 40; i++)
{
    for (int j = 0; j < 40; j++)
    {
        Console.Write(mezo.mezo[i,j]);
    }
}
