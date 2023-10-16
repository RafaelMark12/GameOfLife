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
        public int[,] mezo = new int[75, 75];
        public ConsoleKeyInfo billentyukulcs;
        int sejtvaltozas = 0;
        public int Sejtvaltozas { get { return sejtvaltozas; } set { sejtvaltozas = value; } }

        public Sejtek()
        {
            Console.Write("Kérem adja meg, hogy melyik számmal indítsuk a programot: \n");
            billentyukulcs = Console.ReadKey();
            for (int sor = 0; sor < 75; sor++)
            {
                for (int oszlop = 0; oszlop < 75; oszlop++)
                {
                    mezo[sor, oszlop] = 0;
                }
            }
            

            //Kezdeti érték beállítása
            switch (billentyukulcs.KeyChar)
            {
                case '1':
                    mezo[11, 11] = 1;
                    mezo[11, 12] = 1;
                    mezo[11, 13] = 1;
                    mezo[12, 10] = 1;
                    mezo[12, 14] = 1;
                    mezo[13, 9]  = 1;
                    mezo[13, 15] = 1;
                    mezo[14, 9]  = 1;
                    mezo[14, 15] = 1;
                    mezo[15, 9]  = 1;
                    mezo[15, 15] = 1;
                    mezo[16, 10] = 1;
                    mezo[16, 14] = 1;
                    mezo[17, 11] = 1;
                    mezo[17, 12] = 1;
                    mezo[17, 13] = 1;
                    break;

                case '2':
                    mezo[30, 30] = 1;
                    mezo[30, 31] = 1;
                    mezo[30, 32] = 1;
                    mezo[30, 33] = 1;
                    mezo[30, 34] = 1;
                    mezo[30, 35] = 1;
                    mezo[30, 36] = 1;

                    mezo[36, 30] = 1;
                    mezo[36, 31] = 1;
                    mezo[36, 32] = 1;
                    mezo[36, 33] = 1;
                    mezo[36, 34] = 1;
                    mezo[36, 35] = 1;
                    mezo[36, 36] = 1;

                    mezo[31, 30] = 1;
                    mezo[32, 30] = 1;
                    mezo[33, 30] = 1;
                    mezo[34, 30] = 1;
                    mezo[35, 30] = 1;
                    mezo[36, 30] = 1;

                    mezo[31, 36] = 1;
                    mezo[32, 36] = 1;
                    mezo[33, 36] = 1;
                    mezo[34, 36] = 1;
                    mezo[35, 36] = 1;
                    mezo[36, 36] = 1;
                    break;

                case '3':
                    mezo[40, 45] = 1;
                    mezo[41, 44] = 1;
                    mezo[41, 46] = 1;
                    mezo[42, 43] = 1;
                    mezo[42, 47] = 1;
                    mezo[43, 42] = 1;
                    mezo[43, 48] = 1;
                    mezo[44, 41] = 1;
                    mezo[44, 49] = 1;
                    mezo[45, 40] = 1;
                    mezo[45, 50] = 1;
                    mezo[46, 41] = 1;
                    mezo[46, 49] = 1;
                    mezo[47, 42] = 1;
                    mezo[47, 48] = 1;
                    mezo[48, 43] = 1;
                    mezo[48, 47] = 1;
                    mezo[49, 44] = 1;
                    mezo[49, 46] = 1;
                    mezo[50, 45] = 1;
                    break;

                case '4':
                    mezo[50, 55] = 1;
                    mezo[51, 55] = 1;
                    mezo[52, 55] = 1;
                    mezo[53, 55] = 1;
                    mezo[54, 55] = 1;
                    mezo[55, 50] = 1;
                    mezo[55, 51] = 1;
                    mezo[55, 52] = 1;
                    mezo[55, 53] = 1;
                    mezo[55, 54] = 1;
                    mezo[55, 55] = 1;
                    mezo[55, 56] = 1;
                    mezo[55, 57] = 1;
                    mezo[55, 58] = 1;
                    mezo[55, 59] = 1;
                    mezo[55, 60] = 1;
                    mezo[56, 55] = 1;
                    mezo[57, 55] = 1;
                    mezo[58, 55] = 1;
                    mezo[59, 55] = 1;
                    mezo[60, 55] = 1;
                    break;


                case '5':
                    mezo[60, 60] = 1;
                    mezo[61, 60] = 1;
                    mezo[62, 60] = 1;
                    mezo[63, 60] = 1;
                    mezo[64, 60] = 1;
                    mezo[65, 60] = 1;
                    mezo[66, 60] = 1;

                    mezo[60, 60] = 1;
                    mezo[60, 61] = 1;
                    mezo[60, 62] = 1;
                    mezo[60, 63] = 1;
                    mezo[60, 64] = 1;
                    mezo[60, 65] = 1;
                    mezo[60, 66] = 1;
                    mezo[60, 67] = 1;
                    mezo[60, 68] = 1;
                    mezo[60, 69] = 1;
                    mezo[60, 70] = 1;

                    mezo[60, 70] = 1;
                    mezo[61, 70] = 1;
                    mezo[62, 70] = 1;
                    mezo[63, 70] = 1;
                    mezo[64, 70] = 1;
                    mezo[65, 70] = 1;
                    mezo[66, 70] = 1;

                    mezo[61, 61] = 1;
                    mezo[61, 62] = 1;
                    mezo[61, 63] = 1;
                    mezo[62, 61] = 1;
                    mezo[62, 62] = 1;
                    mezo[63, 61] = 1;

                    mezo[61, 69] = 1;
                    mezo[61, 68] = 1;
                    mezo[61, 67] = 1;
                    mezo[62, 69] = 1;
                    mezo[62, 68] = 1;
                    mezo[63, 69] = 1;

                    break;


                case '6':
                    mezo[70, 71] = 1;
                    mezo[71, 71] = 1;
                    mezo[72, 71] = 1;
                    mezo[72, 72] = 1;
                    mezo[73, 72] = 1;
                    mezo[73, 73] = 1;
                    mezo[74, 73] = 1;
                    mezo[74, 74] = 1;
                    break;


                case '7':
                    mezo[20, 21] = 1;
                    mezo[21, 21] = 1;
                    mezo[22, 21] = 1;
                    mezo[22, 22] = 1;
                    mezo[23, 22] = 1;
                    mezo[23, 23] = 1;
                    mezo[24, 23] = 1;
                    mezo[24, 24] = 1;
                    break;
            }
        }





    }
}
