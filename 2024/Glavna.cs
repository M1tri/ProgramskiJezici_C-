using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024
{
    class Glavna
    {
        public static void Main(String[] args)
        {
            #region JUN2

            DijagonalnaMatrica digMat = new DijagonalnaMatrica(3);

            for (int i = 0; i < digMat.Dimenzija; i++)
            {
                for (int j = 0; j < digMat.Dimenzija; j++)
                    Console.Write(digMat[i, j] + " ");
                Console.WriteLine();
            }

            GornjeTrougaonaMatrica troMat = new GornjeTrougaonaMatrica(3);

            for (int i = 0; i < troMat.Dimenzija; i++)
            {
                for (int j = 0; j < troMat.Dimenzija; j++)
                    Console.Write(troMat[i, j] + " ");
                Console.WriteLine();
            }

            #endregion
        }
    }
}
