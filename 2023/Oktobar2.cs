using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023
{
    class OKT2_Zadatak1
    {
        public static int zbirKvadrata(params int[] args)
        {
            int sum = 0;
            for (int i = 0; i < args.Length; i++) 
            {
                sum += args[i] * args[i];
            }

            return sum;
        }
    }
}
