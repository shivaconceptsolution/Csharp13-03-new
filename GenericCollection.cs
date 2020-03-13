using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class GenericCollection
    {
        static void Main()
        {
            /*IList<String> obj = new List<String>();
            obj.Add("C");
            obj.Add("CPP");
            //obj.Add(12);*/
             IDictionary<string, int> obj = new Dictionary<string, int>();
            obj.Add("A", 12);
            obj.Add("B", 23);
            obj.Add("C", 11);
            obj.Add("E", 55);
            if (obj.IsReadOnly)
            {
                Console.WriteLine("Mutable");
            }
            else
            {
                Console.WriteLine("Not mutable");
            }
           // obj.Values.IsReadOnly;
                
                IDictionary<string, int> obj1 = new Dictionary<string, int>();
            obj1.Add("A1", 12);
            obj1.Add("B1", 23);
            obj1.Add("C1", 11);
            obj1.Add("E1", 55);
            Console.WriteLine(obj["A"]);
            //KeyValuePair<string,int> kv = ;
         //   obj.Add(
         //   obj.Add("E", 45);
           // obj.Remove("E");
            
           
            foreach (KeyValuePair<string,int> s in obj1)
            {
                obj.Add(s);
               // Console.WriteLine(s.Key+" " +s.Value);
            }
            Console.ReadKey();
        }
    }
}
