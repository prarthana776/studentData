using System;
using System.IO;


namespace studendData
{
    internal class studentRead
    {
        static void Main()
        {
            string path = Directory.GetCurrentDirectory();
            path += @"\student.txt";
            StreamReader streamReader = new StreamReader(path);
            {
                string str = streamReader.ReadToEnd();
                Console.WriteLine(str);

            }
            Console.ReadLine();

        }



    }
}
