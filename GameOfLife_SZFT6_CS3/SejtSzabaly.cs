
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife_SZFT6_CS3
    {
        internal class SejtSzabaly
        {
            Sejtek eletter = new Sejtek();


            // A sejt/celláknak a vizsgálata, a szabály betartása
            public void Szomszedok()
            {
                // A játék folyamán töröljük a mezőt, hogy a megváltozott mezőt tegyük helyére
                Console.Clear();

                // Az új mező, amit a számítások alapján feltöltünk
                int[,] SegedMezo = new int[75, 75];

                for (int sor = 0; sor < eletter.mezo.GetLength(0); sor++)
                {
                    for (int oszlop = 0; oszlop < eletter.mezo.GetLength(1); oszlop++)
                    {
                        int sejtvaltozas = 0; // --> Ebben tároljuk a számított értéket

                        if (sor > 0)
                        {
                            if (oszlop > 0)
                            {
                                sejtvaltozas += eletter.mezo[sor - 1, oszlop - 1] == 1 ? 1 : 0;
                            }
                            sejtvaltozas += eletter.mezo[sor - 1, oszlop] == 1 ? 1 : 0;
                            if (oszlop < eletter.mezo.GetLength(1) - 1)
                            {
                                sejtvaltozas += eletter.mezo[sor - 1, oszlop + 1] == 1 ? 1 : 0;
                            }
                        }
                        if (oszlop > 0)
                        {
                            sejtvaltozas += eletter.mezo[sor, oszlop - 1] == 1 ? 1 : 0;
                        }
                        if (oszlop < eletter.mezo.GetLength(1) - 1)
                        {
                            sejtvaltozas += eletter.mezo[sor, oszlop + 1] == 1 ? 1 : 0;
                        }
                        if (sor < eletter.mezo.GetLength(0) - 1)
                        {
                            if (oszlop > 0)
                            {
                                sejtvaltozas += eletter.mezo[sor + 1, oszlop - 1] == 1 ? 1 : 0;
                            }
                            sejtvaltozas += eletter.mezo[sor + 1, oszlop] == 1 ? 1 : 0;
                            if (oszlop < eletter.mezo.GetLength(1) - 1)
                            {
                                sejtvaltozas += eletter.mezo[sor + 1, oszlop + 1] == 1 ? 1 : 0;
                            }
                        }

                        // a számított értéket egy segéd mezőbe tesszük bele
                        SegedMezo[sor, oszlop] = sejtvaltozas;
                    }
                }

                // Az új mező tartalmát másoljuk vissza az eredeti mezőbe
                Array.Copy(SegedMezo, eletter.mezo, SegedMezo.Length);

                // Itt lesz kiírva a változás eredménye
                for (int sor = 0; sor < eletter.mezo.GetLength(0); sor++)
                {
                    for (int oszlop = 0; oszlop < eletter.mezo.GetLength(1); oszlop++)
                    {
                        Console.Write(eletter.mezo[sor, oszlop] == 1 ? "█" : ".");
                    }
                    Console.WriteLine();
                }

                // Itt pedig a számokkal való megjelenített változata lesz látható
            }

        }
    }
}
}
