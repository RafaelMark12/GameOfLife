
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife_SZFT6_CS3
{
    internal class SejtSzabaly
    {
        Sejtek eletter = new Sejtek();


        // Kezdeti mező megjelenítése
        public void KezdoTer()
        {
            Console.Clear();




            // Először összefűzzük az értékeket egy szövegbe, hogy egyszerre jelenítse meg az értékeket.

            string mezokEgyben = "";

            for (int sor = 0; sor < eletter.mezo.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < eletter.mezo.GetLength(1); oszlop++)
                {
                    mezokEgyben += eletter.mezo[sor, oszlop] ? "1" : "0";
                }
                mezokEgyben += Environment.NewLine;
            }
            Console.WriteLine(mezokEgyben);

            // Pár sort kihagyunk, hogy a számokat is normálisan láthassuk
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            // Változott mező ábrákkal való megjelenítés alapján 
            mezokEgyben = "";

            for (int sor = 0; sor < eletter.mezo.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < eletter.mezo.GetLength(1); oszlop++)
                {
                    mezokEgyben += eletter.mezo[sor, oszlop] ? "█" : ".";
                }
                mezokEgyben += Environment.NewLine; // Egy sor után sortörés, hogy a következő sort ne a legelső sorba jelenítse meg.
            }

            // Most jelenítjük meg az összes mezőt egyben ábrákkal.
            Console.WriteLine(mezokEgyben);

            Thread.Sleep(1000);
        }



        // A sejt/celláknak a vizsgálata, a szabály betartása
        public void Szomszedok()
        {
            // A játék folyamán töröljük a mezőt, hogy a megváltozott mezőt tegyük helyére
            Console.Clear();

            // Az új mező, amit a számítások alapján feltöltünk


            for (int sor = 0; sor < eletter.mezo.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < eletter.mezo.GetLength(1); oszlop++)
                {
                    int sejtvaltozas = 0; // Ebben tároljuk a számított értéket

                    if (sor > 0)
                    {
                        if (oszlop > 0)
                        {
                            sejtvaltozas += eletter.mezo[sor - 1, oszlop - 1] ? 1 : 0; // Bal felső szomszéd vizsgálata
                        }
                        sejtvaltozas += eletter.mezo[sor - 1, oszlop] ? 1 : 0; // Felső szomszéd
                        if (oszlop < eletter.mezo.GetLength(1) - 1)
                        {
                            sejtvaltozas += eletter.mezo[sor - 1, oszlop + 1] ? 1 : 0; // Jobb felső szomszéd vizsgálata
                        }
                    }
                    if (oszlop > 0)
                    {
                        sejtvaltozas += eletter.mezo[sor, oszlop - 1] ? 1 : 0; // Bal szomszéd vizsgálata
                    }
                    if (oszlop < eletter.mezo.GetLength(1) - 1)
                    {
                        sejtvaltozas += eletter.mezo[sor, oszlop + 1] ? 1 : 0; // Jobb szomszéd vizsgálata
                    }
                    if (sor < eletter.mezo.GetLength(0) - 1)
                    {
                        if (oszlop > 0)
                        {
                            sejtvaltozas += eletter.mezo[sor + 1, oszlop - 1] ? 1 : 0; // Bal alsó szomszéd vizsgálata
                        }
                        sejtvaltozas += eletter.mezo[sor + 1, oszlop] ? 1 : 0; // Alsó szomszéd vizsgálata
                        if (oszlop < eletter.mezo.GetLength(1) - 1)
                        {
                            sejtvaltozas += eletter.mezo[sor + 1, oszlop + 1] ? 1 : 0; // Jobb alsó szomszéd vizsgálata
                        }
                    }

                    if (eletter.mezo[sor, oszlop])
                    {
                        if (sejtvaltozas == 2 || sejtvaltozas == 3)
                        {
                            eletter.mezo[sor, oszlop] = true;
                        }
                        else
                        {
                            eletter.mezo[sor, oszlop] = false; // A cella meghal
                        }
                    }
                    else
                    {
                        if (sejtvaltozas == 3)
                        {
                            eletter.mezo[sor, oszlop] = true; // A cella újjászületik
                        }
                    }

                }
            }






            // Itt is összefűzzük az értékeket, hogy egyszerre legyen megjelenítve a console applikációban

            string mezokEgyben = "";

            for (int sor = 0; sor < eletter.mezo.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < eletter.mezo.GetLength(1); oszlop++)
                {
                    mezokEgyben += eletter.mezo[sor, oszlop] ? "1" : "0";
                }
                mezokEgyben += Environment.NewLine; // Egy sor után sortörés, hogy a következő sort ne a legelső sorba jelenítse meg.
            }
            Console.WriteLine(mezokEgyben);

            // Pár sort kihagyunk itt is, hogy az ábrákat is normálisan láthassuk
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            // Változott mező ábrákkal való megjelenítés alapján 
            mezokEgyben = "";

            for (int sor = 0; sor < eletter.mezo.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < eletter.mezo.GetLength(1); oszlop++)
                {
                    mezokEgyben += eletter.mezo[sor, oszlop] ? "█" : ".";
                }
                mezokEgyben += Environment.NewLine; // Egy sor után sortörés, hogy a következő sort ne a legelső sorba jelenítse meg.
            }

            // Most jelenítjük meg az összes mezőt egyben ábrákkal.
            Console.WriteLine(mezokEgyben);

            //Itt egy időzítő, hogy mikor menjen a sejtváltozás következő köre
            Thread.Sleep(1000);


        }

    }
}

