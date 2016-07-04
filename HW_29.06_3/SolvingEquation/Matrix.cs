using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SolvingEquation
{
    public class Matrix

    { 
        public int row { get; set; }
        public int col { get; set; }

        public int counter;

        public List<Matrix> listOfMatrix { get; set; }
        public double[,] matrix { get; set; }

        public Matrix() { }

        public Matrix(double[,] matrix, int row, int col) {

            this.col = col;
            this.row = row;
            this.matrix = matrix;
            
        }

        public List<Matrix> AddMatrixToTheList(String path) {

            counter = 0;

            listOfMatrix = new List<Matrix>();
            for (int i = 0; i < 2; i++)
            {
                Matrix matrix = ReadMatrix(path, counter);
                listOfMatrix.Add(matrix);
                counter += (matrix.row + 2);
            }

            return listOfMatrix;
        }


        public Matrix ReadMatrix(String path, int conter)
        {

          
            using (StreamReader reader = new StreamReader(path))
            {
              
                List<string> lines = new List<string>();

                String str = reader.ReadLine();
                for (int i = 0; i < counter; i++)
                {
                    str = reader.ReadLine();

                }
            
                string[] dementions = str.Split(new char[] { ' ' }); //считываем размерность

                row = Int32.Parse(dementions[0]);
                col = Int32.Parse(dementions[1]);
                matrix = new double[row, col];
              //  Console.WriteLine(row + " " + col);
                for (int i = 0; i < row; i++)
                {
                    str = reader.ReadLine();
                    string[] cols = str.Split(new char[] { ' ' });
                    for (int j = 0; j < col; j++)
                    {

                        matrix[i, j] = Double.Parse(cols[j]);
                       // Console.WriteLine(cols[j]);
                    }
        }
            }            
    

           return new Matrix(matrix, row, col);
        }


        public Matrix MultiplyMatrixs(Matrix firstMatrix, Matrix secondMatrix) {

            int n1 = firstMatrix.row;
            int m1 = firstMatrix.col;     
            int n2 = secondMatrix.row;
            int m2 = secondMatrix.col;

            if (m1 != n2 && m2 != n1 ) {

                throw new Exception();
            }


            matrix = new double[row, col];
            Matrix resultMatrix = new Matrix(matrix, n1,m2);

            for (int row = 0; row < n1; row++)
            {
                for (int col = 0; col < m2; col++)
                {
                    for (int inner = 0; inner < m1; inner++)
                    {
                        resultMatrix.matrix[row, col] += firstMatrix.matrix[row, inner] * secondMatrix.matrix[inner, col];
                    }
                   // Console.WriteLine(resultMatrix.matrix[row, col] + "  ");
                }
             //   Console.WriteLine("\n");
            }

            return resultMatrix ;

        }

    }
}
