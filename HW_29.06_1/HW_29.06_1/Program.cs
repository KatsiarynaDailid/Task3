using System;
using System.IO;


/*  TODO:
   
      1.Help
      2.Testing
      ____________
     1.	Создать консольное приложение, которое будет делать следующее:
a.	Предлагать пользователю ввести имя папки
b.	Создавать папку на диске 
c.	В ней создавать файл, в который копировать первые 20 строк любого другого текстового файла

     
     */

namespace HW_29._06_1
{
    class Program
    {
        static void Main(string[] args)
        {


            String path, newPath, pathToWrite, pathToRead;

            Help();
            path = Data.Path; //считали путь из ресурсного файла
            while (!Directory.Exists(path)) { //проверили путь
                Console.WriteLine("Your path do not exist. You should enter the existing path in resours file.");
                Console.WriteLine("For exit type any key...");
                Console.ReadLine();
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

        public static void Help() {

            Console.WriteLine("This program will help you to rewrite 20 lines from one file to another.\n");

        }
       

    }
}
