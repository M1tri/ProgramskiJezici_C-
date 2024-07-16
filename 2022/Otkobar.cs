using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022
{
    class Otkobar
    {
        enum Smer { R, US, ELK, EKM, T }
        class Student
        {
            String ime, prezime;
            DateTime datumRodjenja;
            int brojIndeksa;
            Smer smer;
            List<int> ocene;

            public void ProcitajBinarni(String putanja)
            {
                BinaryReader br = null;

                try
                {
                    br = new BinaryReader(File.Open(putanja, FileMode.Open));
                    ime = br.ReadString();
                    prezime = br.ReadString();
                    datumRodjenja = DateTime.Parse(br.ReadString());
                    int brojIndeksa = br.ReadInt32();
                    smer = (Smer)br.ReadInt32();

                    int count = br.ReadInt32();

                    for (int i = 0; i < count; i++)
                    {
                        ocene.Add(br.ReadInt32());
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    if (br != null)
                    {
                        br.Close();
                    }
                }
            }

            public void UpisiTekstualni(String putanja)
            {
                StreamWriter sr = null;

                try
                {
                    sr = new StreamWriter(File.Open(putanja, FileMode.Create));

                    sr.Write(ime);
                    sr.WriteLine();

                    sr.Write(prezime);
                    sr.WriteLine();

                    sr.Write(datumRodjenja.ToString());
                    sr.WriteLine();

                    sr.Write(this.brojIndeksa);
                    sr.WriteLine();

                    sr.Write((int)smer);
                    sr.WriteLine();

                    sr.WriteLine(ocene.Count);
                    sr.WriteLine();

                    for (int i = 0; i < ocene.Count; i++)
                    {
                        sr.Write(ocene[i]);
                        sr.WriteLine();
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }
                }
            }
        }


        class Buffer
        {
            private int[] data;
            private int max;
            private int curr;

            private static readonly object lock_obj = new object();

            public Buffer(int max)
            {
                this.max = max;
                curr = 0;
                data = new int[max];
            }

            // ovo je sa zakljucavanje resursa
            public void Add(int e)
            {
                lock(lock_obj)
                {
                    if (curr >= max) 
                    {
                        return;
                    }

                    data[curr++] = e;
                }
            }
            public int Remove(int e) 
            {
                lock(lock_obj)
                {
                    if (curr > 0)
                    {
                        return data[--curr];
                    }

                    return -1;
                }
            
            }


            public void Add_Monitor(int e)
            {
                Monitor.Enter(lock_obj);

                try
                {
                    if (curr >= max)
                    {
                        return;
                    }

                    data[curr++] = e;
                }
                finally
                {
                    Monitor.Exit(lock_obj);
                }
            }
            public int Remove_Monitor()
            {
                Monitor.Enter(lock_obj);

                int toRet = -1;

                try
                {
                    if (curr > 0)
                    {
                        toRet = data[--curr];
                    }
                }
                finally
                {
                    Monitor.Exit(lock_obj);
                }

                return toRet;
            }
        }

    } 
}
