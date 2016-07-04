using System;
using System.Configuration;
using SolvingEquation;
using System.Collections.Generic;
using System.IO;

namespace UIMatrix
{
    public class Program
    {

        /*4.	Добавить в библиотеку из Задания 3 метод который будет умножать две матрицы (не обязательно квадратные).
                    a.	Данные считать из файла.
                    b.	Имя файла хранить в конфигурационном файле.
                    c.	Реализовать вывод результата на консоль в формате до 2 знаков после запятой.
        */

        static void Main(string[] args)
        {

            Help();
            String path = CheckThePath();     //проверили путь
            Matrix matr = new Matrix();       //создали экземпляр класса Матрица
            List<Matrix> matrixs = null;
            try
            {
                matrixs = matr.AddMatrixToTheList(path);//считали в коллекцию матрицы из файла
            } catch (Exception ex) {
                Console.WriteLine("Check, is format of entered matrices corresponds to the correct format?");
                Console.WriteLine("For exit type any key...");
                Console.ReadLine();
                Environment.Exit(-1);
            }
            Console.WriteLine("First matrix from the file: ");
            Print.PrintMatrix(matrixs[0]);
            Console.WriteLine("Second matrix from the file: ");
            Print.PrintMatrix(matrixs[1]);

            Matrix resultMatrix = new Matrix();
            try
            {
               resultMatrix = matr.MultiplyMatrixs(matrixs[0], matrixs[1]); // перемножили матрицы
            } catch(Exception ex)
            {
                Console.WriteLine("Matrices cannot be multiplied together because the number of columns in the first matrix does not equal the number of rows in the second.");
                Console.WriteLine("For exit type any key...");
                Console.ReadLine();
                Environment.Exit(-1);
            }
            Console.WriteLine("The result of multiplication:");
            Print.PrintMatrix(resultMatrix);  //вывели на экран
            Console.WriteLine("For exit type any key...");
            Console.ReadLine();



        }

        public static string CheckThePath( )
        {
            String path;
            path = ConfigurationManager.AppSettings["Path"];
            //считали путь из ресурсного файла
            while (!File.Exists(path))
            { //проверили путь
                Console.WriteLine("Your path do not exist. You should enter the existing path in configuration file.");
                Console.WriteLine("Enter any key to exit...");
                Console.ReadLine();
                Environment.Exit(-1);
            }
            return path;
        }

        public static void Help()
        {
            Console.WriteLine("This program multiply two matrices.\nYou should write them in a file.\nPath to the file you should write in resours file.\n" +
                
                "The matrix in a file should be in the following format: \n"+
                "2 3 //the dimensions of matrix\n"+
                "2 3 6 //the body of the matrix\n"+
                "5 6 9\n"+
                "//epmty line, that divide two matrices\n"+
                "//second matrix as shown above.");

        }
    }
}
