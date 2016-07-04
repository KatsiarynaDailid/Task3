using System;
using HW_29._06_3;
using System.Text.RegularExpressions;
using System.Globalization;

namespace UIEquation
{
    class Coefficient
    {


        public  void GetCoffOfLinearEq()
        {

            Console.WriteLine("You chose the linear type of equation and you should enter two coefficients, a and d (integer or real numbers):\n" +
               "ax+b=0");
            Console.WriteLine("Enter the first coefficient: ");
            double b = CheckTheDouble();

            Console.WriteLine("Enter the second coefficient: ");
            double c = CheckTheDouble();

            Solving trySolve = new Solving(0, b, c);
            String solving = trySolve.FindRoots();

            Logg log = new Logg(); 
            String line = "The user chose the linear type of equation and entered following coefficients:\r\n"+
                $"a={b} and b = {c}\r\nThe equation: {b}x+{c}=0\r\nThe result is: " + solving;

            log.WriteInAFile(line);

            Console.WriteLine(solving);

        }


        public  void GetCoffOfQuadraticEq()
        {
            Console.WriteLine("You chose the quadratic type of equation and you should enter three coefficients, a, d and c (integer or real numbers):\n" +
               "ax^2+bx+c=0");
            Console.WriteLine("Enter the first coefficient: ");
            double a = CheckTheDouble();

            Console.WriteLine("Enter the second coefficient: ");
            double b = CheckTheDouble();

            Console.WriteLine("Enter the third coefficient: ");
            double c = CheckTheDouble();

            Solving trySolve = new Solving(a, b, c);
            String solving = trySolve.FindRoots();
            Logg log = new Logg();

            String line = "The user chose the quadratic type of equation and entered following coefficients:\r\n" +
                $"a={a}, b = {b} and c = {c}\r\nThe equation: {a}x^2+{b}x+{c}=0\r\nThe result is: " + solving;

            log.WriteInAFile(line);


            Console.WriteLine(solving);

        }
        public Boolean MatchDoubleRegEx(String str)
        {
             String separator = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
            var reg = new Regex(@"\s*[0-9]*\" + separator + "[0-9]+");
            return reg.IsMatch(str);
        }

        public double CheckTheDouble()
        {
            String str = Console.ReadLine();
            int coeff;
            while (!MatchDoubleRegEx(str) && !Int32.TryParse(str, out coeff)) {
                Logg log = new Logg();

                String line = $"The user entered wrong type of coefficient: {str}";

                log.WriteInAFile(line);
                Console.WriteLine("Enter the valid coefficient(integer or real number): ");
                str = Console.ReadLine();

            }
            double coef = Double.Parse(str);
     
            return coef;
        }
    }
}
