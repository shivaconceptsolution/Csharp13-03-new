using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp2
{
    class FileExmple
    {
        static void Main()
        {
           // File.Create("d://training//mydata.txt");

            //File.WriteAllText("d://training//rrrrrr.txt", "hfg ajh gfjhagfha gdfhgdfh gdjhfghdgfhgd dfdjhfg dhfg ");
           // File.Encrypt("d://training//mydata.txt");
            File.Move("d://training//rrrrrr.txt", "d://uploads//abc.txt");
            Console.WriteLine(File.ReadAllText("d://training//mydata.txt"));
            Console.ReadKey();
        }
    }
}
