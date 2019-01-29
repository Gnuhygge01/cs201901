using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action
{
     

    class Program
    {


        static void Main(string[] args)
        {
            Action<String> f1 = (MinSkrivTilConsole);
            f1.Invoke("test");

            Action<String> f2 = MinSkrivTilConsole;
            f2.DynamicInvoke("test");

            Action<string> f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3("Gnuen er");

            f1 -= MinSkrivTilConsole;
            f2 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole;
            f3 -= Console.WriteLine;
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }

        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " Gnuen");
        }
    }
}
