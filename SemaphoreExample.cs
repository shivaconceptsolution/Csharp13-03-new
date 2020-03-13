using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp2
{
    class SemaphoreExample
    {
        static Semaphore obj = new Semaphore(1, 5);

        static void Main(string[] args)
        {
            try
            {
                for (int i = 1; i <= 5; i++)
                {
                    Thread t = new Thread(SempStart);
                    t.Start(i);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            Console.ReadKey();
        }
        static void SempStart(object id)
        {

            Console.WriteLine(id + " Wants to Get Enter for processing");
            try
            {
                //Blocks the current thread until the current WaitHandle receives a signal.   
                obj.WaitOne();
                Console.WriteLine(" Success: " + id + " is in!");
                //Thread.Sleep(1000);
                Console.WriteLine(id + "<<-- is exit because it completed there operation");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                //Release() method to releage semaphore  
                obj.Release();
            }
        }  
    }
}
