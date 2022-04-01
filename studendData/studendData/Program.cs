using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studendData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            path += @"\student.txt";
            StreamWriter streamWriter = new StreamWriter(path);
            {
                
                streamWriter.WriteLine("Name : ridi \t rollno : 102 \t  sec:A");
                streamWriter.WriteLine("Name : iraa \t rollno : 103 \t  sec:A");
                streamWriter.WriteLine("Name : pragya \t rollno : 104 \t  sec:A");
                streamWriter.WriteLine("Name : pritu \t rollno : 105 \t  sec:A");
                streamWriter.WriteLine("Name : preeti \t rollno : 106 \t  sec:A");
                streamWriter.WriteLine("Name : arya \t rollno : 107 \t  sec:A");
                streamWriter.WriteLine("Name : salmim \t rollno : 1018 \t  sec:A");
                streamWriter.WriteLine("Name : hana \t rollno : 109 \t  sec:A");
                streamWriter.WriteLine("Name : isha \t rollno : 110 \t  sec:A");
                streamWriter.WriteLine("Name : aana \t rollno : 111 \t  sec:A");
                streamWriter.WriteLine("Name : ali \t rollno : 112 \t  sec:A");
                streamWriter.Close();
                Console.WriteLine("File successfully written");
            }
            Console.ReadLine();
        }
    }
}
