using System;
using System.IO;


/*  TODO:
   
      1.Help
      2.Testing
     
     
     */

namespace HW_29._06_1
{
    class Program
    {
        static void Main(string[] args)
        {

            String path, newPath, pathToWrite, pathToRead;
           
            path = Data.Path; //считали путь из ресурсного файла
            while (!Directory.Exists(path)) { //проверили путь
                Console.WriteLine("Your path do not exist. You should enter the existing path in resours file.");
                Environment.Exit(-1);
            }

            Checks checkObj = new Checks();           
            newPath = checkObj.CheckTheExistingOfDirectory(path);

            DirectoryInfo dir = Directory.CreateDirectory(newPath);
            pathToWrite = checkObj.CheckTheExistingOfFile(newPath);


            pathToRead = checkObj.CheckTheFileWithInformation();

            checkObj.WriteInAFile(pathToRead, pathToWrite);
          
                Console.ReadLine();



        }


       

    }
}
