using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedjaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Declaration and Initialization

            int[][] matrix = new int[3][]
            {
            new int[] { 1, 2, 3, 4 },
            new int[] { 5, 6 },
            new int[] { 7, 8, 9 }
            };

            // Task 2: Accessing and Display

            int element = matrix[0][1];
            Console.WriteLine($"The second element in the first row of the matrix is {element}.");

            foreach (int[] row in matrix)
            {
                foreach (int item in row)
                {
                    Console.Write($"{item} ");
                }

                Console.WriteLine();
            }

            // Task 3: Modification

            //matrix[1][2] = 15;
            Array.Resize(ref matrix[1], matrix[1].Length + 1);
            matrix[1][matrix[1].Length - 1] = 15;

            // Display the modified matrix
            Console.WriteLine("*****");
            Console.WriteLine("Displaying modified Matrix");
            foreach (int[] row in matrix)
            {
                foreach (int item in row)
                {
                    Console.Write($"{item} ");
                }

                Console.WriteLine();
            }

            // Task 4: Advanced Concepts

            object[][] objectMatrix = new object[][]
            {
            new object[] { 1, "Hello", 3.14 },
            new object[] { true, 'A', new DateTime(2023, 11, 10) }
            };

            // Display the contents of the objectMatrix

            foreach (object[] row in objectMatrix)
            {
                foreach (object item in row)
                {
                    Console.WriteLine($"{item.GetType().Name}: {item}");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
