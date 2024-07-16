using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2022
{
    class Glavna
    {
        // Jun zadatak2
        delegate void Printer();
        // Jun zadatak2

        // Oktobar zadatak1
        static String s;
        static DateTime d;
        // Otkobar zadatak1

        public static void Main(String[] args)
        {

            #region Jun

            MultiDimensionalField f1 = new MultiDimensionalField(2, 2, 2);
            MultiDimensionalField f2 = new MultiDimensionalField(2, 2, 2);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        f1[i, j, k] = f2[i, j, k] = new Item(10 * i + j + k);
                    }
                }
            }

            MultiDimensionalField f3 = f1 + f2;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.WriteLine(p3[i, j, k].value);
                    }
                }
            }

            JUN_Zadatak3.Procitaj("C:\\Users\\Dimitrije\\source\\repos\\ProgramskiJezici_C#\\2022\\Ulaz.txt");

            // zadatak 2
                // w umesto i jer se nece kompajlira sa i jer je C# rtd
            List<Printer> printers = new List<Printer>();
            int w = 0;
            for (; w < 10; w++)
            {
                printers.Add(delegate { Console.WriteLine(w); });
            }
            foreach (var printer in printers)
            {
                printer();
            }

            // zadatak2

            #endregion

            #region Oktobar

            Console.WriteLine(s == null ? "String je NULL!" : s);
            Console.WriteLine(d == null ? "DateTime je NULL!" : d.ToString());
            Console.ReadLine();

            double a = 1.23456789;
            object b = a;
            // dodao sam try da bi nastavio kod se izvrsava da moze probas ostalo
            try
            {
                int c = (int)b; // exception
                Console.WriteLine(c);
            }
            catch(Exception e) {}
            #endregion

            #region Jun2

            int b1 = 5;
            Int32 c = 6;
            String s2 = "ja sam string";
            MyClassB p1 = new MyClassB();
            MyClassA p2 = new MyClassB();
            MyClassA p3 = p2;
            p3.a = 20;
            MyStructA p4 = new MyStructA(10, 20);
            p4.a += 15;
            Console.WriteLine("P1");
            p1.Funkcija();
            Console.WriteLine("P2");
            p2.Funkcija();
            Console.WriteLine("P3");
            p3.Funkcija();
            Console.WriteLine("P4");
            p4.Funkcija();

            double sum = JUN2_Zadatak2.ZbirKorena(1, 2, 3, 4, 5);

            LancanaLista ll = new LancanaLista();
            ll.insert(1);
            ll.insert(2);
            ll.insert(3);
            ll.insert(4);

            ll.Reset();
            while (ll.MoveNext())
            {
                Console.WriteLine(((Node)ll.Current).value);
            }



            #endregion
        }
    }
}
