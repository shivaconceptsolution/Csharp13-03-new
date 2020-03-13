using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp2
{
    class Akshay  
    {  
        //private static Mutex mutex = new Mutex();  
        private static Semaphore mutex = new Semaphore(3, 2);
        private const int numhits = 1;  
        private const int numThreads = 5;  
        private static void ThreadProcess()  
        {  
            for (int i = 0; i < 5; i++)  
            {  
                UseCsharpcorner();  
            }  
        }  
        private static void UseCsharpcorner()  
        {
            try
            {
                mutex.WaitOne();   // Wait until it is safe to enter.  
                Console.WriteLine("{0} Thread in ",
                    Thread.CurrentThread.Name);
                // Place code to access non-reentrant resources here.  
                Thread.Sleep(500);    // Wait until it is safe to enter.  
                Console.WriteLine("{0} is  Thread out",
                    Thread.CurrentThread.Name);
                //  mutex.ReleaseMutex();    // Release the Mutex.  
               
            }
            finally
            {
                mutex.Release();
            }
        }  
       static void Main(string[] args)  
       {  
             for (int i = 0; i < numThreads; i++)  
            {  
                Thread mycorner = new Thread(new ThreadStart(ThreadProcess));  
                mycorner.Name = String.Format("Thread{0}", i + 1);  
                mycorner.Start();  
            }  
            Console.Read();  
        }  
    }  
}  

