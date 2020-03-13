using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApp2
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        internal Student()
        {
        }
        internal Student(int StudentID,string StudentName)
        {
            this.StudentID = StudentID;
            this.StudentName = StudentName;
        }
    }

    class CompareDictionaryObject:IEqualityComparer<KeyValuePair<int,Student>>
    {

        public bool Equals(KeyValuePair<int, Student> x, KeyValuePair<int, Student> y)
        {
            if (x.Key == y.Key && (x.Value.StudentID == y.Value.StudentID) && (x.Value.StudentName == y.Value.StudentName))
                return true;

            return false;

        }

        public int GetHashCode(KeyValuePair<int, Student> obj)
        {
           return obj.Key.GetHashCode();
        }
    }

    class ProgramDict
    {
        public static void Main()
        {
            IDictionary<int, Student> obj = new Dictionary<int, Student>();
           // Console.WriteLine(obj.GetHashCode());
            obj.Add(1,new Student(1,"A"));
            obj.Add(1002, new Student(1, "B"));

            

       Student std = new Student() { StudentID = 2, StudentName = "A" };

            KeyValuePair<int, Student> elementToFind = new KeyValuePair<int, Student>(1, std);
           // bool result = obj.Contains(elementToFind, new CompareDictionaryObject());
            //Console.WriteLine(result);


            Console.ReadKey();


        }
    }
}
