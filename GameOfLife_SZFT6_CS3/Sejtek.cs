using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife_SZFT6_CS3
{
    internal class Sejtek
    {
        public int[,] mezo = new int[75, 75];
        public ConsoleKeyInfo billentyukulcs;


        public Sejtek()
        {
            Console.Write("Kérem adja meg, hogy melyik számmal indítsuk a programot: ");
            billentyukulcs = Console.ReadKey();
            for (int i = 0; i < 75; i++)
            {
                for (int j = 0; j < 75; j++)
                {
                    mezo[i, j] = 0;
                }
            }
            
            switch (billentyukulcs.KeyChar)
            {
                case '1':
                    mezo[11, 11] = 1;
                    mezo[11, 12] = 1;
                    mezo[11, 11] = 1;
                    mezo[11, 13] = 1;
                    mezo[11, 14] = 1;
                    break;

                case '2':
                    mezo[30, 31] = 1;
                    mezo[31, 31] = 1;
                    mezo[32, 31] = 1;
                    mezo[32, 32] = 1;
                    mezo[33, 32] = 1;
                    mezo[33, 33] = 1;
                    mezo[34, 33] = 1;
                    mezo[34, 34] = 1;
                    break;

                case '3':
                    mezo[40, 41] = 1;
                    mezo[41, 41] = 1;
                    mezo[42, 41] = 1;
                    mezo[42, 42] = 1;
                    mezo[43, 42] = 1;
                    mezo[43, 43] = 1;
                    mezo[44, 43] = 1;
                    mezo[44, 44] = 1;
                    break;

                case '4':
                    mezo[50, 51] = 1;
                    mezo[51, 51] = 1;
                    mezo[52, 51] = 1;
                    mezo[52, 52] = 1;
                    mezo[53, 52] = 1;
                    break;


                case '5':
                    mezo[62, 62] = 1;
                    mezo[63, 62] = 1;
                    mezo[63, 63] = 1;
                    mezo[64, 63] = 1;
                    mezo[64, 64] = 1;
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
