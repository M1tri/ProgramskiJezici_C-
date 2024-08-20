using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _2023
{

    #region JUN_ZADATAK1

    enum Prognoza1 { NemaPrognoze = 0, Sunce = 1, Oblaci = 2, Kisa = 4, Vetar = 8, Sneg = 16 }

    enum Prognoza2 { NemaPrognoze, Sunce, Oblaci, Kisa, Vetar, Sneg }


    #endregion

    class Glavna
    {
        public static void Main(String[] args)
        {

            #region Septembar
            Matrica a = new Matrica(2, 2);
            Matrica b = new Matrica(2, 2);

            a[0, 0] = b[0, 0] = 0;
            a[0, 1] = b[0, 1] = 1;
            a[1, 0] = b[1, 0] = 2;
            a[1, 1] = b[1, 1] = 3;

            Matrica c = a + b;

            for (int i = 0; i < c.BrojVrsta; i++)
            {
                for (int j = 0; j < c.BrojKolona; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion

            #region Oktobar2

            int sum = OKT2_Zadatak1.zbirKvadrata(1, 2, 3);

            #endregion

            #region JUN

            Prognoza1 p = Prognoza1.Oblaci | Prognoza1.Kisa | Prognoza1.Vetar;
            if ((p & Prognoza1.Sunce) != 0)
                Console.WriteLine("Sunčano je.");
            if ((p & Prognoza1.Oblaci) != 0)
                Console.WriteLine("Oblačno je.");
            if ((p & Prognoza1.Kisa) != 0)
                Console.WriteLine("Pada kiša.");
            if ((p & Prognoza1.Vetar) != 0)
                Console.WriteLine("Duva vetar.");
            if ((p & Prognoza1.Sneg) != 0)
                Console.WriteLine("Pada sneg.");

            Console.WriteLine("Prognoza 2:\n");
            Prognoza2 p1 = Prognoza2.Oblaci | Prognoza2.Kisa | Prognoza2.Vetar;
            if ((p1 & Prognoza2.Sunce) != 0)
                Console.WriteLine("Sunčano je.");
            if ((p1 & Prognoza2.Oblaci) != 0)
                Console.WriteLine("Oblačno je.");
            if ((p1 & Prognoza2.Kisa) != 0)
                Console.WriteLine("Pada kiša.");
            if ((p1 & Prognoza2.Vetar) != 0)
                Console.WriteLine("Duva vetar.");
            if ((p1 & Prognoza2.Sneg) != 0)
                Console.WriteLine("Pada sneg.");


            Dictionary<int, Radnik> mapa = Radnik.ProcitajFajl("C:\\Users\\Dimitrije\\source\\repos\\ProgramskiJezici_C#\\2023\\Radnici.txt");

            #endregion

            #region Jun2

            DijagonalnaMatrica digMat = new DijagonalnaMatrica(3);

            for (int i = 0; i < digMat.Dimenzija; i++)
            {
                for (int j = 0; j < digMat.Dimenzija; j++)
                    Console.Write(digMat[i, j] + " ");
                Console.WriteLine();
            }

            DonjeTrougaonaMatrica troMat = new DonjeTrougaonaMatrica(3);    

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
