using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_med_strenge
{
    class Program
    {
        static void Main(string[] args)
        {
            String fornavn = "Mikkel";
            String efternavn = "Cronberg";

            String samletNavn = fornavn + " " + efternavn;
           
            Console.WriteLine(samletNavn);

            string navnStort = samletNavn.ToUpper();

            Console.WriteLine(navnStort);

            string navnLille = samletNavn.ToLower();

            Console.WriteLine(navnLille);

            string del = samletNavn.Substring(7, 4);

            Console.WriteLine(del);



            Console.WriteLine(fornavn + "\r\n\t" + efternavn);

            System.IO.File.WriteAllText("c:\\temp\\test.txt", samletNavn);





            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
