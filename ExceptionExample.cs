using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ExceptionExample
    {
        static void Add()
        {

           
            try
            {
                int a = unchecked(2147483647 + 1);
                int b;
                //Console.WriteLine("num1");
                //a = int.Parse(Console.ReadLine());
                // if (a < 0)
                //   throw new NegativeException("enter positive number");
                Console.WriteLine("num2");
                b = int.Parse(Console.ReadLine());
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;

            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }
        static void Main()
        {

            try
            {
                Add();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());

            }
            
            Console.ReadKey();
        }
    }
    class NegativeException : Exception
    {
       
       internal NegativeException(String s):base(s)
        {
            
        }

    }
}
