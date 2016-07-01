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


            String path = CheckThePath();     
            Matrix matr = new Matrix();       
            List<Matrix> matrixs = matr.AddMatrixToTheList(path);
            Matrix resultMatrix = matr.MultiplyMatrixs(matrixs[0], matrixs[1]);
            Print.PrintMatrix(resultMatrix);
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

    }
}
