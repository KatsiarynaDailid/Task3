using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_29._06_3
{
    public class Solving
    {

        //Discriminant

        private double coefficientA;
        private double coefficientB;
        private double coefficientC;

        
        public double discriminant
        {
            set { discriminant = value; }
            get { return coefficientB * coefficientB - 4 * coefficientA * coefficientC; }

        }

        public Solving(double coefficientA, double coefficientB, double coefficientC)
        {
            this.coefficientA = coefficientA;
            this.coefficientB = coefficientB;
            this.coefficientC = coefficientC;

        }


        public String FindRoots()
        {

            double firstRoot;
            double secondRoot;
            String answer;
            if (coefficientA == 0 && coefficientB == 0 && coefficientC == 0)
            {
                answer = "The solving is any number.";
                return answer;
            }
            else if (coefficientA == 0 && coefficientB == 0)
            {
                answer = "There is no roots";
                return answer;
            }
            else if (coefficientA == 0)
            {
                firstRoot = -coefficientC / coefficientB;
                answer = "The equation has only one root " + firstRoot.ToString("0.00");
                return answer;
            }

            if (discriminant < 0) {
                answer = "No roots. Discriminant is less than 0.";
                return answer;

            }

            if (discriminant == 0)
            {

                firstRoot = -coefficientC / coefficientB;
                answer = "The equation has two equal roots: " + firstRoot.ToString("0.00") + " and " + firstRoot.ToString("0.00");
                return answer;
            }
            else
            {

                firstRoot = (-coefficientB + Math.Sqrt(discriminant)) / (2 * coefficientA);
                secondRoot = (-coefficientB - Math.Sqrt(discriminant)) / (2 * coefficientA);
                answer = "The equation has two roots: " + firstRoot.ToString("0.00") + " and " + secondRoot.ToString("0.00");
                return answer;

            }

        }


    }
}
