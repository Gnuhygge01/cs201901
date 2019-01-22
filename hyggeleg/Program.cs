using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hyggeleg
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = Beregn.Lægsammen(65, 34);

            Console.WriteLine(res);
            int res2 = Beregn.Trækfra(45, 67);
            Console.WriteLine(res2);

            Console.ReadKey();

        }
         
        public class Beregn
        {
            public static int Lægsammen(int a, int b)
            {
                return a + b;
            }
            public static int Trækfra(int a, int b)
            {

                return a - b;

            }
            private Beregn() { }
        }
        
        



    }

}
