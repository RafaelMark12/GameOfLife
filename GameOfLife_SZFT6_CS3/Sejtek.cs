using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife_SZFT6_CS3
{
    internal class Sejtek
    {
        //Alapadatok
        public bool[,] mezo = new bool[75, 75];
        string mezokegyben;
        int körkesleltetes;
        public ConsoleKeyInfo billentyukulcs;
        
        
        int sejtvaltozas;
        public int Sejtvaltozas { get { return sejtvaltozas = 0; } set { sejtvaltozas = value; } }
        public string MezokEgyben { get { return mezokegyben; } set { mezokegyben = value; } }
        public Sejtek()
        {

            // A mező alapértelmezett értékét itt állítottuk be.
            for (int sor = 0; sor < 75; sor++)
            {
                for (int oszlop = 0; oszlop < 75; oszlop++)
                {
                    mezo[sor, oszlop] = false;
                }
            }


            //Megkérjük itt a felhasználót, hogy egy szám alapján milyen alakzatot rajzoljon ki. 
            Console.Write("Kérem adja meg, hogy melyik számmal indítsuk a programot: ");
            billentyukulcs = Console.ReadKey();
            switch (billentyukulcs.KeyChar)
            {
                case '1':
                    mezo[1, 2] = true;
                    mezo[2, 3] = true;
                    mezo[3, 1] = true;
                    mezo[3, 2] = true;
                    mezo[3, 3] = true;
                    break;

                case '2':
                    mezo[30, 31] = true;
                    mezo[31, 31] = true;
                    mezo[32, 31] = true;
                    mezo[32, 32] = true;
                    mezo[33, 32] = true;
                    mezo[33, 33] = true;
                    mezo[34, 33] = true;
                    mezo[34, 34] = true;
                    break;

                case '3':
                    mezo[40, 41] = true;
                    mezo[41, 41] = true;
                    mezo[42, 41] = true;
                    mezo[42, 42] = true;
                    mezo[43, 42] = true;
                    mezo[43, 43] = true;
                    mezo[44, 43] = true;
                    mezo[44, 44] = true;
                    break;

                case '4':
                    mezo[2, 2] = true;
                    mezo[2, 3] = true;
                    mezo[2, 4] = true;
                    mezo[3, 2] = true;
                    mezo[3, 4] = true;
                    mezo[4, 3] = true;
                    mezo[5, 3] = true;
                    break;


                case '5':
                    mezo[62, 62] = true;
                    mezo[63, 62] = true;
                    mezo[63, 63] = true;
                    mezo[64, 63] = true;
                    mezo[64, 64] = true;
                    break;


                case '6':
                    mezo[70, 71] = true;
                    mezo[71, 71] = true;
                    mezo[72, 71] = true;
                    mezo[72, 72] = true;
                    mezo[73, 72] = true;
                    mezo[73, 73] = true;
                    mezo[74, 73] = true;
                    mezo[74, 74] = true;
                    break;


                case '7':
                    mezo[20, 21] = true;
                    mezo[21, 21] = true;
                    mezo[22, 21] = true;
                    mezo[22, 22] = true;
                    mezo[23, 22] = true;
                    mezo[23, 23] = true;
                    mezo[24, 23] = true;
                    mezo[24, 24] = true;
                    break;
            }
        }





    }
}

