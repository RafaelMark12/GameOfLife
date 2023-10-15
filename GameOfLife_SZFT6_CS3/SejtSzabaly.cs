using System;
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
            for (int sor = 0; sor < eletter.mezo.Length; sor++)
            {
                for (int oszlop = 0; oszlop < eletter.mezo.Length; oszlop++)
                {
                    
                    if (sor > 0)
                    {
                        if (oszlop > 0)
                        {
                            eletter.Sejtvaltozas += eletter.mezo[sor - 1, oszlop - 1] == 1 ? 1 : 0;
                        }
                        eletter.Sejtvaltozas += eletter.mezo[sor - 1, oszlop - 1] == 1 ? 1 : 0;
                        if (oszlop < eletter.mezo.GetLength(1) - 1)
                        {
                            eletter.Sejtvaltozas += eletter.mezo[sor - 1, oszlop - 1] == 1 ? 1 : 0;
                        }
                    }
                }
            }

        }

    }
}
