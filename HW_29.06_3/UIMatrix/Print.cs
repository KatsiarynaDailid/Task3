using SolvingEquation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIMatrix
{
    class Print
    {

        public static void PrintMatrix(Matrix matrix)
        {

            for (int i = 0; i < matrix.row; i++)
            {               
                for (int j = 0; j < matrix.col; j++)
                {
                    Console.Write(matrix.matrix[i, j].ToString("0.00").Trim() + "\t");
                }
                Console.WriteLine();
            }

        }


    }
}
