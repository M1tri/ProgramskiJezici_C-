using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024
{
    interface IMatrica
    {
        double this[int i, int j] { get; }
        int Dimenzija { get; }
    }

    class DijagonalnaMatrica : IMatrica
    {
        private double[] data;

        public DijagonalnaMatrica(int dim)
        {
            Random ran = new Random();
            data = new double[dim];

            for (int i = 0; i < dim; i++)
                data[i] = ran.NextDouble();
        }

        public double this[int i, int j]
        {
            get
            {
                if (i == j)
                    return data[i];

                return 0;
            }
        }

        public int Dimenzija { get { return data.Length; } }
    }

    class GornjeTrougaonaMatrica : IMatrica
    {
        private double[][] data;

        //   0 1 2
        // 0 1 2 3
        // 1 0 4 5
        // 2 0 0 7

        public GornjeTrougaonaMatrica(int dim)
        {
            Random ran = new Random();

            data = new double[dim][];

            for (int i = 0; i < dim; i++)
                data[i] = new double[dim - i];

            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim - i; j++)
                    data[i][j] = ran.NextDouble();
            }
        }

        public double this[int i, int j]
        {
            get
            {
                // ide j - i jer se rezervise samo onolko mesta kolko ima elemenata
                // i-ta vrsta ima za i manje elemenata i onda je pomeraj na indeksu kolone za i
                if (j >= i)
                    return data[i][j - i]; 

                return 0;
            }
        }

        public int Dimenzija { get { return data.Length; } }
    }
}
