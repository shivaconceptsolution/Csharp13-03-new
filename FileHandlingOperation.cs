using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp2
{
    class FileHandlingOperation
    {
        static void Main()
        {
            FileStream fs = new FileStream("hello.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            String s = "hello";
            //char [] arr = s.ToCharArray();
            byte [] arr = new byte[s.Length];
            fs.Write(Encoding.ASCII.GetBytes(s), 0, s.Length);
            fs.Position = 0;
          /*  for(int i=0;i<s.Length;i++)
            {
                arr[i] =(byte)fs.ReadByte();
                Console.WriteLine(arr[i]);
               // Console.Write(fs.ReadByte());
            }*/
            fs.Read(arr,0,s.Length);
           Console.WriteLine(Encoding.ASCII.GetString(arr));
            fs.Close();
            Console.ReadKey();
         }
    }
}
