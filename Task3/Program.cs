using System.Text;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            var directoryName = @"C:\TESTDIR";
            try
            {
                Directory.CreateDirectory(directoryName);
                for (int i = 0; i < 101; i++)
                {
                    var folderName = $"folder_{i}";
                    var folderPath = Path.Combine(directoryName, folderName);
                    Directory.CreateDirectory(folderPath);
                    Console.WriteLine($"Створено директорію: {folderPath}");
                }
                if (Directory.Exists(directoryName))
                {
                    if (directoryName != null)
                    {
                        Directory.Delete(directoryName, true);
                        Console.WriteLine($"Видалено батьківську директорію та всі дочірні директорії");
                    }

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сталася помилка: {ex.Message}");
            }
        }
    }
}        
    
