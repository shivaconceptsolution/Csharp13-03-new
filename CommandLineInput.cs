using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CommandLineInput
    {
       static void add(string a)
        {

        }
       
        public static void Main(String [] args)
        {
            add("");
         //   add(12.3,12);
            args[0] = "12";
            int sum=0;
            foreach (String a in args)
            {
                sum = sum + int.Parse(a);
                Console.WriteLine(a);
            }
         //   Console.WriteLine(args[3]);
            Console.ReadKey();
        }
    }
}
