using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApp2
{
    class ArrayListExample
    {
        static void Main()
        {
          ArrayList obj = new ArrayList();
           
           // int [] x = {1,2,3};
          obj.Add(12);
          obj.Add("CPP");
           obj.Add(true);
         obj.Add(12);
         IEnumerator ie = obj.GetEnumerator();
         while (ie.MoveNext())
         {
             Console.WriteLine(ie.Current);

         }

           // obj.Insert(0, 11);
           // obj.AddRange(x);
           // //obj.InsertRange(2, x);
           // foreach (object o in obj)
           // {
           //     Console.WriteLine(o);
           // }

           // SortedList obj = new SortedList();
         /*  Hashtable obj = new Hashtable();
           obj.Add("A", 1001);
           obj.Add("E", 1000);
           obj.Add("B", 1004);
           obj.Add("C", 1007);
           foreach (DictionaryEntry de in obj)
           {
               Console.WriteLine(de.Key + "," + de.Value);
           }
           Stack obj = new Stack(1);
          
           obj.Push("C");
           obj.Push("CPP");
           obj.Push("DS");
           Console.WriteLine(obj.Pop());
           Console.WriteLine(obj.Pop());
         Queue q = new Queue();
         q.Enqueue("C");
         q.Enqueue("CPP");
         q.Enqueue("C");
         q.Enqueue("CPP");
         q.Enqueue("C");
         q.Enqueue("CPP");
         q.Enqueue(null);
         //Console.Write(q.Dequeue());
         while (q.Count > 0)
         {
             Console.WriteLine(q.Dequeue());
         }
         */
         Console.ReadKey();
        }
    }
}
