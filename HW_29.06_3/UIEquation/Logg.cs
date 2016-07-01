using System;
using System.Globalization;
using System.IO;

namespace UIEquation
{

    class Logg
    {

        public string CheckThePath()
        {
            String path;
            path = FilePath.Path;
            //считали путь из ресурсного файла
            while (!File.Exists(path))
            { //проверили путь
                Console.WriteLine("Your path do not exist. You should enter the existing path in resours file.");
                Console.WriteLine("Enter any key to exit...");
                Console.ReadLine();
                Environment.Exit(-1);
            }
            return path;
        }

        public  void WriteInAFile(String line)
        {
            String path = CheckThePath();    
           
            using (StreamWriter sw = File.AppendText(path))
            {
                  sw.WriteLine("_____________________\r\n");
                  sw.WriteLine(DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff ", CultureInfo.InvariantCulture) + line);                                                                    
            }
        }

    }
}
