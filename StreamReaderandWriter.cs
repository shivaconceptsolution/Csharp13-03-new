using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp2
{
    class StreamReaderandWriter
    {
        static void Main()
        {
            FileInfo fi = new FileInfo(@"D:\DummyFile.txt");

            //open DummyFile.txt for read operation
            FileStream fsToRead = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            //open DummyFile.txt for write operation
            FileStream fsToWrite = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            //get the StreamReader
            StreamWriter sw = new StreamWriter(fsToWrite);
            //write some text using StreamWriter
            sw.WriteLine("Another line from streamwriter");
            sw.Close();
            StreamReader sr = new StreamReader(fsToRead);
            //read all texts using StreamReader object
            string fileContent = sr.ReadToEnd();
            Console.WriteLine(fileContent);
            sr.Close();
           

            //close all Stream objects
            fsToRead.Close();
            fsToWrite.Close();
            Console.ReadKey();

        }
    }
}
