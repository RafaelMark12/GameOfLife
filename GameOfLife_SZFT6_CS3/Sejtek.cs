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
        public ConsoleKeyInfo billentyukulcs = Console.ReadKey();


        public Sejtek()
        {
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

            }

        }


        


    }
}
