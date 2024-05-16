using System;
using System.IO;
using System.IO.Compression;
using System.Text;
namespace Task2

{
    class ViewFile
    {
      public static void ViewFileContent(string filePath)
        {
            FileStream fl = null;
            StreamReader sr = null;
            try
            {
                fl = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fl,Encoding.UTF8);
                Console.WriteLine($"вміст файлу{filePath}");
                Console.WriteLine(sr.ReadToEnd());

            }
            finally
            {
                if( fl != null ) fl.Close();
                if( sr != null ) sr.Close();
            }

        }
        public static void Archive(string filePath)
        {
            var compresFile=$"{filePath}.zip";
            FileStream origininalFile = null ;
            FileStream copyOriginal=null ;
            ZipArchive ziparchive= null ;
            try
            {
                origininalFile = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                copyOriginal = new FileStream(compresFile, FileMode.Create);
                ziparchive = new ZipArchive(copyOriginal, ZipArchiveMode.Create);
                var entry = ziparchive.CreateEntry(Path.GetFileName(filePath));
                using (var entryStream = entry.Open())
                {
                    origininalFile.CopyTo(entryStream);
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Помилка при стисканні файла: {ex.Message}");
            }
            finally
            {

                if (ziparchive != null) ziparchive.Dispose();
                if (origininalFile != null) origininalFile.Close();
                if( copyOriginal != null ) copyOriginal.Close();
                
            }

        }
    }
}
