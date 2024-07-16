using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023
{
    class Radnik
    {
        string ime;
        string prezime;
        double plata;

        public Radnik(string ime, string prezime, double plata)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.plata = plata;
        }

        public static Dictionary<int, Radnik> ProcitajFajl(String putanja)
        {
            StreamReader sr = null;
            Dictionary<int, Radnik> mapa = new Dictionary<int, Radnik>();


            try
            {
                sr = new StreamReader(File.Open(putanja, FileMode.Open));

                while (!sr.EndOfStream)
                {
                    int jmbg = int.Parse(sr.ReadLine());

                    string ime = sr.ReadLine();
                    string prezime = sr.ReadLine();
                    double plata = double.Parse(sr.ReadLine());

                    if (!mapa.ContainsKey(jmbg)) 
                    {
                        mapa[jmbg] = new Radnik(ime, prezime, plata);
                    }
                }


            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) 
                    sr.Close();
            }

            return mapa;
        }
    }
}
