using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;

            Console.WriteLine("введіть повний шлях до файлу");
            var filePath= Console.ReadLine();
            if(File.Exists(filePath))
            {
                Console.WriteLine("файл знайдено ");
                ViewFile.ViewFileContent(filePath);
                Console.WriteLine("Бажаєте стиснути файл? (yes/not)");
                if (Console.ReadLine().ToLower() == "yes")
                {
                    ViewFile.Archive(filePath);
                    Console.WriteLine($"Файл '{filePath}' був стиснутий.");
                }
                else
                {
                    Console.WriteLine($"Файл '{filePath}' не був стиснутий.");
                }
            }
            else
            {
                Console.WriteLine($"Файл '{filePath}' не знайдено.");
            }

            Console.WriteLine("Програма завершила роботу.");

        }
    }
}
