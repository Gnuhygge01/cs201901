﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_udvidet
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool()); // true eller false

            Console.ReadKey();

        }
    }
    class UdvidetRandom : System.Random
    {
        public bool NextBool()
        {
            return this.Next(1, 1002) <= 500;
        }

    }

}
