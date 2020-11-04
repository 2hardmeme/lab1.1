using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavdannya_z_pdf
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("введiть кiлькiсть рядкiв масиву: ");
                int rows = int.Parse(Console.ReadLine());

                int[][] array = new int[rows][];
                int[][] massFromMetod = CreateRandom(array, rows);

                Console.WriteLine("введений масив: ");
                ShowArray(array);
                Console.WriteLine();

                Console.WriteLine("вiдсортований масив за зростанням: ");
                SortAscendingOrder(array);
                ShowArray(array);
                Console.WriteLine();

                Console.WriteLine("вiдсортований масив за спаданням: ");
                SortIndescendingOrder(array);
                ShowArray(array);
                Console.WriteLine();

                Console.WriteLine("iнвертований масив з найбiльших елементiв кожного рядка матрицi:");
                int[] invarr = InvertedArray(array);
                for (int i = 0; i < invarr.Length; i++)
                {
                    Console.Write(invarr[i] + " ");
                }
            }
            Console.Read();
        }
        public static int[][] CreateRandom(int[][] array, int rows)
        {
            int count = 1;
            Random r = new Random();
            for (int g = 0; g < rows; g++)
            {
                Console.Write("введiть кiлькiсть стовпчикiв {0}-го рядку: ", count);
                int s = int.Parse(Console.ReadLine());
                array[g] = new int[s];

                for (int i = 0; i < s; i++)
                {
                    array[g][i] = r.Next(0, 100);
                }
                Console.WriteLine();
                count++;
            }
            return array;
        }
        static void ShowArray(int[][] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void SortAscendingOrder(int[][] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Array.Sort(array[i]);
            }
        }
        public static void SortIndescendingOrder(int[][] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Array.Sort(array[i]);
                Array.Reverse(array[i]);
            }
        }
        public static int[] InvertedArray(int[][] array)
        {
            int[] numbers= new int [array.GetLength(0)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int max = array[i][0];
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] > max) 
                    {
                        max = array[i][j];
                        
                    }
                }
                numbers[i] = max;
                Console.WriteLine();
            }
            Array.Reverse(numbers);
            return numbers;
        }
    }
}