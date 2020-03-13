using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp2
{
    class ThreadExample2
    {
        static void Display()
        {
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine("Sub process of {0} {1}",Thread.CurrentThread.Name, i);
             //  Thread.Sleep(1000);
            }
        }
        static void Main()
        {
            ThreadStart t = new ThreadStart(Display);
            Thread t1 = new Thread(t);
            t1.Name = "Thread1";
            t1.Start();
           // t1.Join(1000);
            Thread t2 = new Thread(t);
            t2.Name = "Thread2";
            t2.Start();
            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;
            //Thread.Sleep(2000);
            /*try
            {
                t1.Abort();
                t2.Abort();
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }*/
           // t1.Abort();
            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.ReadKey();
        }
    }
}
