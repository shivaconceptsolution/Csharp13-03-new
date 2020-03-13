using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp2
{
    class DirectoryExample
    {
        static void Main()
        {
           // Directory.CreateDirectory("D://fileexample");
            DirectoryInfo obj = new DirectoryInfo("D://fileexample1");
            obj.Create();
           // Console.WriteLine(obj.ToString());
          //  File.WriteAllText(obj.ToString()+"/abc.txt", "Directory info");
            Console.ReadKey();
      
        }
    }
}
