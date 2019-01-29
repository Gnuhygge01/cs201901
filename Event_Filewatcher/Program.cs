using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Filewatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w =
               new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            // bind en metode til w.Changed
            
            w.Changed += W_Changed;
            w.Created += (s, e) => { Console.WriteLine("Oprettet " + e.FullPath, System.Security.Principal.WindowsIdentity.GetCurrent().Name); };
            //string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            do { } while (true);

        }

        private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine($"Filen er rettet " + e.Name + System.Security.Principal.WindowsIdentity.GetCurrent().Name);  
        }
    }
}
