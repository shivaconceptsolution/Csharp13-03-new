using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class TupleExample
    {
        static void Main()
        {
           // Tuple<int,int,int> obj =new Tuple<int,int,int>(10,20,30);
            var obj = Tuple.Create(10, 20, 30);
            Console.WriteLine(obj.Item1 + " " + obj.Item2 + " " + obj.Item3);
            Console.ReadLine();

        }
    }
}
