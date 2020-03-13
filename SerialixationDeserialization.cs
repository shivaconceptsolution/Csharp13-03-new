using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using System.Collections;
namespace ConsoleApp2
{
    [Serializable]
    class Emp
    {
       public static int EmpId;
       [NonSerialized]
       public string EmpName;
       public Emp(int EmpId, string EmpName)
        {
            Emp.EmpId = EmpId;
            this.EmpName = EmpName;
        }

    }
    class SerializationDeserialization
    {

        static void Main()
        {
            FileStream obj = new FileStream("D://abc.txt", FileMode.OpenOrCreate);
            BinaryFormatter bi = new BinaryFormatter();
            Emp e = new Emp(1001, "XYZ");
            bi.Serialize(obj,e);
            obj.Close();
            obj = new FileStream("D://abc.txt", FileMode.OpenOrCreate);
            Emp e1 = null;
            e1 =(Emp) bi.Deserialize(obj);
          Console.WriteLine(Emp.EmpId + " " + e1.EmpName);
            obj.Close();

            Console.ReadKey();


        }
    }
}
