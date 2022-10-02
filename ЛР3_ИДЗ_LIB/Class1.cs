using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР3_ИДЗ_LIB
{
    public class Matrix
    {
        private int m;
        private int n;
        public int[,] numbers;
        public Matrix(int pM, int pN)
        {
            m = pM;
            n = pN;
            numbers = new int[n,m];
            Console.WriteLine("Введите значение матрицы");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Matrix[" + (i+1) + "," + (j+1) + "]: ");
                    numbers[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public static void PrintMatrix(Matrix matrix)
        {
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    Console.Write(matrix.numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void GetSrArif(Matrix matrix)
        {
            int[] arif = new int[matrix.m];
            for (int i = 0; i < matrix.m; i++)
            {
                for (int j = 0; j < matrix.n; j++)
                {
                    arif[i] += matrix.numbers[j, i];
                }
                Console.Write(arif[i] + " ");
            }
            Console.WriteLine();
        }

        public static void PrintResultMatrix(Matrix matrix)
        {
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    if ((matrix.numbers[i, j] % 2) == 1)
                    {
                        Console.Write(0 + " ");
                    }
                    else
                    {
                        Console.Write(1 + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
