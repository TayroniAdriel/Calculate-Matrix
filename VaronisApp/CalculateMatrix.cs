using System;
using System.Collections.Generic;
using System.Text;

namespace VaronisApp
{
    public class CalculateMatrix
    {
        public int[,] FillMatrix(int n)
        {
            // get the lenght of matrix
            int length = n + (n - 1);
            //  creating matrix
            int[,] matrix = new int[length, length];

            int firstCol = 0, lastCol = length - 1;
            int firstLine = 0, lastLine = length - 1;
            int number = n;

            while (firstLine <= lastLine && firstCol <= lastCol)
            {
                //filling the first line
                for (int i = firstCol; i <= lastCol; i++)
                {
                    matrix[firstLine, i] = number;
                }
                firstLine++;

                //filling the last colmn
                for (int i = firstLine; i <= lastLine; i++)
                {
                    matrix[i, lastCol] = number;
                }
                lastCol--;

                //filling the last line
                 for (int i = lastCol; i >= firstCol; i--)
                  {
                     matrix[lastLine, i] = number;
                 }
                
                lastLine--;

                //filling the first colmn
                  for (int i = lastLine; i >= firstLine; i--)
                  {
                     matrix[i, firstCol] = number;
                  }
                
                firstCol++;

                number--;

            }
            return matrix;
        }
    }
}



