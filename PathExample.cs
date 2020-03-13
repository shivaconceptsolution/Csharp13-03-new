using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp2
{
    class PathExample
    {
        static void Main()
        {
            Console.WriteLine(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            Console.WriteLine(Path.GetFileName(Directory.GetCurrentDirectory()));
            String [] arr=     Directory.GetFiles(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            foreach (String s in arr)
            {
                Console.WriteLine(s);
            }
            string[] drives = Directory.GetLogicalDrives();

            foreach (string drive in drives)
            {
                System.Console.WriteLine(drive);
            }
          //  Console.WriteLine(Path.GetFileName(Path.GetFileName(Directory.GetCurrentDirectory())));
            Console.ReadKey();



        }
    }
}
