using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022
{

    struct MyStructA
    {
        public int a;
        public int b;
        public MyStructA(int a, int b) { this.a = a; this.b = b; }
        public void Funkcija() { Console.WriteLine("Struct_A -> " + a + "," + b); }
    }

    class MyClassA
    {
        public int a;
        public MyClassA() { a = 10; Console.WriteLine("constructor A"); }
        public virtual void Funkcija() { Console.WriteLine("A_" + a); }
    }

    class MyClassB : MyClassA
    {
        public int b;
        public MyClassB() { b = 5; Console.WriteLine("constructor B"); }
        public void Funkcija() { Console.WriteLine("B_" + b); }
    }

    class JUN2_Zadatak2
    { 
        public static double ZbirKorena(params double[] args)
        {
            double sum = 0.0;
            for (int i = 0; i < args.Length; i++) 
            {
                sum += Math.Sqrt(args[i]);
            }

            return sum;
        }
    
    }

    // Zadatak_3

    class Node
    {
        public int value;
        public Node? next; // ? je da ne bi vs kukao, oznacava da atribut moze bude null
        public Node(int value)
        {
            this.value = value;
            next = null;
        }
    }

    class LancanaLista : IEnumerator
    {
        private Node? head;

        // koristi se za IEnumerator
        private Node? iter = null;


        public LancanaLista()
        {
            head = null;
            iter = null;
        }

        public void insert(int e)
        {
            if (head == null)
            {
                head = new Node(e);
                return;
            }

            Node novi = new Node(e);
            novi.next = head;
            head = novi;
        }


        public Object Current
        {
            get
            {
                return iter;
            }
        }

        public bool MoveNext()
        {
            if (iter == null)
            {
                if (head != null)
                {
                    iter = head;
                    return true;
                }

                return false;
            }

            if (iter.next != null)
            {
                iter = iter.next;
                return true;
            }

            return false;
        }
        public void Reset()
        {
            iter = null;
        }
    }

}
