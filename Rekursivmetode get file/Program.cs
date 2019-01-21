using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursivmetode_get_file
{
    class Program
    {
        static void Main(string[] args)
        {

            // find ud af 

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
        

    static void PrintFiler(string sti)
    {
        var filer = System.IO.Directory.GetFiles(sti);
        foreach (string fil in filer)
            Console.WriteLine(fil);

        var mapper = System.IO.Directory.GetDirectories(sti);
        foreach (string mappe in mapper)
            PrintFiler(mappe);
    }
}
    }

