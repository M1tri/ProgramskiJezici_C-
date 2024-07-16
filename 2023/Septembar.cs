using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023
{
    interface IMatrica
    {
        double this[int i, int j] { get; set; }
        int BrojVrsta { get; }
        int BrojKolona { get; }
    }

    class Matrica : IMatrica
    {
        private double[][] data;
        private int rows;
        private int cols;

        public Matrica(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;

            data = new double[rows][];
            for (int i = 0; i < rows; i++) 
            {
                data[i] = new double[cols];
            }
        }

        public double this[int i, int j]
        {
            get
            {
                return data[i][j];
            }
            set
            {
                data[i][j] = value;
            }
        }

        public int BrojVrsta { get { return rows; } }
        public int BrojKolona { get {  return cols; } }


        public static Matrica operator+(Matrica a, Matrica b)
        {
            if (a.BrojVrsta != b.BrojVrsta || 
                a.BrojKolona != b.BrojKolona)
            {
                throw new Exception("Dimenzije se ne poklapaju");
            }

            Matrica c = new Matrica(a.rows, a.cols);

            for (int i = 0; i < a.BrojVrsta; i++) 
            {
                for (int j = 0; j < a.BrojKolona; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }

            return c;
        }

    }

    class Stack
    {
        int[] data;
        int size;
        int top;

        private static readonly object lock_obj = new object();

        public Stack(int size)
        {
            this.size = size;
            top = 0;
            data = new int[size];   
        }


        public void Push(int el)
        {
            lock(lock_obj)
            {
                if (top >= size)
                    throw new Exception("Stack overflow");

                data[top++] = el;
            }
        }

        public int Pop()
        {
            lock(lock_obj)
            {
                if (top <= 0)
                    throw new Exception("Stack underflow");

                return data[--top];
            }
        }

        public void Push_Monitor(int el)
        {
            Monitor.Enter(lock_obj);
            try
            {
                if (top >= size)
                    throw new Exception("Stack overflow");

                data[top++] = el;
            }
            finally
            {
                Monitor.Exit(lock_obj);
            }
        }
    
        public int Pop_Monitor()
        {
            Monitor.Enter(lock_obj);
    
            if (top <= 0)
                throw new Exception("Stack underflow");

            int toRet = 0;
            try
            {
                toRet = data[--top];
            }
            finally
            { 
                Monitor.Exit(lock_obj); 
            }

            return toRet;
        }

    }

}
