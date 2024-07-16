using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2022
{

    class Item
    {
        public int value;

        public Item()
        {
            value = 69;
        }

        public Item(int a)
        {
            value = a;
        }

        public static Item operator +(Item a, Item b)
        {
            return new Item(a.value + b.value);
        }
    }
    class MultiDimensionalField
    {
        private int m;
        private int n;
        private int k;

        private Item[][][] data;
        public MultiDimensionalField(int m, int n, int k)
        {
            this.m = m;
            this.n = n;
            this.k = k;

            data = new Item[m][][];

            for (int i = 0; i < m; i++)
            {
                data[i] = new Item[n][];
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    data[i][j] = new Item[k];
            }
        }

        public Item this[int i, int j, int k]
        {
            get
            {
                return data[i][j][k];
            }
            set
            {
                data[i][j][k] = value;
            }
        }

        public static MultiDimensionalField operator+(MultiDimensionalField p1, MultiDimensionalField p2)
        {
            // Mora sve dimenzije budu iste da bi se sabralo
            if (p1.m != p2.m || p1.n != p2.n || p1.k != p2.k)
            {
                return null;
            }

            MultiDimensionalField novo = new MultiDimensionalField(p1.m, p1.n, p1.k);

            for (int i = 0; i < p1.m; i++)
            {
                for (int j = 0; j < p1.n; j++)
                {
                    for (int s = 0; s < p1.k; s++)
                    {
                        novo[i, j, s] = p1[i, j, s] + p2[i, j, s];
                    }
                }
            }

            return novo;
        }

    }

    class JUN_Zadatak3
    {
        public static void Procitaj(string path)
        {
            StreamReader st = null;

            try
            {
                st = new StreamReader(File.Open(path, FileMode.Open));

                while (!st.EndOfStream)
                {
                    string currLine = st.ReadLine();

                    if (currLine.Contains("stop"))
                    {
                        throw new Exception("Ima rec stop");
                    }

                    Console.WriteLine(currLine);
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (st != null)
                    st.Close();
            }
        }
    }


}
