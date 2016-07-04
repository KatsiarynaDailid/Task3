using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UIEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            String ex = null ;
            String choice;
            Coefficient coeff = new Coefficient();
            do
            {
                Console.WriteLine("If you want to solve the linear equation type 0\nIf you want to solve the quadratic equation type 1");
                choice = Console.ReadLine();
                if (choice == "0")
                {               
                    coeff.GetCoffOfLinearEq();

                }
                else if (choice == "1")
                {
                    coeff.GetCoffOfQuadraticEq();

                } else {
               
                    Console.WriteLine("You entered wrong symbol, try again...");
                    continue;
                }

                
                Console.WriteLine("Write \"ex\" if you want to exit. Write any other key to continue");
               ex = Console.ReadLine();

            } while (ex != "ex");
        }



       

    }
}
