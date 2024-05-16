using System;
using System.IO;
using System.Text;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            var directory = new DirectoryInfo(@"C:\TESTDIR");
            if(!directory.Exists )
            {
                directory.Create();
            }

            var file = Path.Combine(directory.FullName, "text1.txt");
            var file1 = new FileStream(file, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            var streamWriter = new StreamWriter(file1,Encoding.UTF8);

            streamWriter.WriteLine("привіт підстрижись");
            streamWriter.WriteLine("hellooo");
            streamWriter.Write("\n");
            streamWriter.Close();
           

            Console.WriteLine("Файл Text.txt створено та в нього записаний текст.");
            var file3=new FileStream(file,FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(file3,Encoding.UTF8);
            string input;
            while((input = reader.ReadLine()) != null)
            {
                Console.WriteLine($"{input}");
            }
            reader.Close();
            Console.ReadKey();
        }
    }
}
