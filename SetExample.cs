using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Collections;
namespace ConsoleApp2
{
    class MyStu : KeyedCollection<int, Student>
    {

        protected override int GetKeyForItem(Student item)
        {
            return item.StudentID;
        }
    }
    class SetExample
    {
        static void Main()
        {
             MyStu obj = new MyStu();
             obj.Add(new Student(1001, "manish"));
             obj.Add(new Student(1002, "manish"));
             obj.Add(new Student(1003, "manish")); 
            foreach(Student s in obj)
            {
                Console.WriteLine(s.StudentID + " " + s.StudentName);
            }
          
           // Dic
           // HybridDictionary
            OrderedDictionary obj1 = new OrderedDictionary();
            obj1.Add("A", "1001");
            obj1.Add("C", "1003");
            IDictionaryEnumerator obj2 = obj1.GetEnumerator();
            while (obj2.MoveNext())
            {
                Console.WriteLine(obj2.Key+" "+obj2.Value);
            }
           // SortedSet<String> obj = new SortedSet<string>();
           
           /* LinkedList<String> obj = new LinkedList<String>();
            obj.AddFirst("Java");
            obj.AddLast("CPP");
            obj.AddFirst("CPP");
            obj.AddFirst("C");
            obj.AddLast(".NET");
            obj.RemoveFirst();
            obj.RemoveLast();
            Console.WriteLine(obj.Count);
            foreach (String s in obj)
            {
                Console.WriteLine(s);
            }*/
            Console.ReadKey();
        }
    }
}
