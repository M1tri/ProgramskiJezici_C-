using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023
{
    interface IMatrica_JUN2
    {
        double this[int i, int j] { get; }
        int Dimenzija { get; }
    }

    class DijagonalnaMatrica : IMatrica_JUN2
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

    class DonjeTrougaonaMatrica : IMatrica_JUN2
    {
        private double[][] data;

        //   0 1 2
        // 0 1 0 0
        // 1 2 3 0
        // 2 4 5 6

        public DonjeTrougaonaMatrica(int dim)
        {
            Random ran = new Random();

            data = new double[dim][];

            for (int i = 0; i < dim; i++)
                data[i] = new double[i + 1];

            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    data[i][j] = ran.NextDouble();
            }
        }

        public double this[int i, int j]
        {
            get
            {
                if (j <= i)
                    return data[i][j];

                return 0;
            }
        }

        public int Dimenzija { get { return data.Length; } }
    }
}
