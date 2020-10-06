using System;

namespace VaronisApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateMatrix calculateMatrix = new CalculateMatrix();

            var test = calculateMatrix.FillMatrix(5);
            for (int i = 0; i < test.GetLength(0); i++)
            {
                for (int j = 0; j < test.GetLength(1); j++)
                {
                    Console.Write($"{test[i, j]}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
