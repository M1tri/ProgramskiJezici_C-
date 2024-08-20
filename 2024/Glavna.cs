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

            Red q = new Red(5);

            q.Dodaj_ZakljucavanjeResursa(1);
            q.Dodaj_ZakljucavanjeResursa(2);
            q.Dodaj_ZakljucavanjeResursa(3);
            q.Dodaj_ZakljucavanjeResursa(4);

            Console.WriteLine(q.Procitaj_ZakljucavanjeResursa());
            Console.WriteLine(q.Procitaj_ZakljucavanjeResursa());
            Console.WriteLine(q.Procitaj_ZakljucavanjeResursa());

            q.Dodaj_ZakljucavanjeResursa(5);
            q.Dodaj_ZakljucavanjeResursa(6);

            Console.WriteLine(q.Procitaj_ZakljucavanjeResursa());
            Console.WriteLine(q.Procitaj_ZakljucavanjeResursa());
            Console.WriteLine(q.Procitaj_ZakljucavanjeResursa());
            

            #endregion
        }
    }
}
