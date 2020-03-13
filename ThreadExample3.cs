using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp2
{
    class ThreadExample3
    {
        int num;
        ThreadExample3(int num)
        {
            this.num = num;
        }
        public void PrintTable()
        {
           lock(this)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(num*i);
                    Thread.Sleep(1000);
                }
            }
           num = 5;
        }

        static void Main()
        {
            //ThreadExample3 obj = new ThreadExample3(5);
            ThreadExample3 obj1 = new ThreadExample3(7);
            Thread t1 = new Thread(new ThreadStart(obj1.PrintTable));
            
            Thread t2 = new Thread(new ThreadStart(obj1.PrintTable));
            t1.Start();
            t2.Start();
            Console.ReadKey();



        }

    }
   
}
