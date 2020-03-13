using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp2
{
    class ThreadExample
    {
        static void Main()
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.Write(t.Name);
            Console.ReadKey();
        }
    }
}
