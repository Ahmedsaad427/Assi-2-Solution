using System;

namespace Demo
{
    // Define a new class to hold Sum and Mul values
    public class NewData
    {
        public int Sum { get; set; }
        public int Mul { get; set; }
    }

    internal class Program
    {
        // Method to sum elements of an array
        static int SumArray(int[] Arr)
        {
            int Sum = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }

        // Method that takes X and Y and calculates both sum and multiplication by reference
        static void SumMul(int X, int Y, out int Sum, out int Mul)
        {
            Sum = X + Y;
            Mul = X * Y; // Fixed the typo here
        }

        // Method that returns an object containing sum and multiplication
        static NewData SumMul(int X, int Y)
        {
            NewData data = new NewData();
            data.Sum = X + Y;
            data.Mul = X * Y;
            return data;
        }

        // Method that returns an array containing sum and multiplication
        static int[] SumMulArray(int X, int Y)
        {
            int[] Result = { X + Y, X * Y }; // Corrected method name and added proper return
            return Result;
        }

        // Method to print a shape pattern (example)
        static void PrintShape(int count = 10, string pattern = "*")
        {
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine(pattern);
            }
        }

        // Method to sum two numbers
        static int SumNumbers(int Number01, int Number02)
        {
            return Number01 + Number02;
        }

        // Method to swap two values by reference
        static void SWAP(ref int X, ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }

        static void Main(string[] args)
        {
            #region OneDArray
            int[] Numbers = new int[5];
            // Fill the array manually if needed
            Numbers[0] = 12;
            Numbers[1] = 6;
            Numbers[2] = 7;
            Numbers[3] = 11;
            Numbers[4] = 19;

            Console.WriteLine("One-Dimensional Array:");
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine($"Numbers[{i}] = {Numbers[i]}");
            }
            Console.WriteLine($"Array Length: {Numbers.Length}");
            Console.WriteLine($"Array Rank: {Numbers.Rank}");
            Console.WriteLine($"Array Type: {Numbers.GetType()}");
            #endregion

            #region 2DArray
            // Two-Dimensional Array
            int[,] Marks = new int[3, 3];
            Marks[0, 0] = 99;
            Marks[0, 1] = 99;
            Marks[0, 2] = 99;
            Marks[1, 0] = 80;
            Marks[1, 1] = 98;
            Marks[1, 2] = 97;
            Marks[2, 0] = 88;
            Marks[2, 1] = 78;
            Marks[2, 2] = 47;

            Console.WriteLine("\nTwo-Dimensional Array:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Marks[{i},{j}] = {Marks[i, j]}");
                }
            }
            #endregion

            #region JaggedArray
            // Jagged Array (Array of Arrays)
            int[][] JaggedMarks = new int[3][];
            JaggedMarks[0] = new int[] { 1, 2, 3 };
            JaggedMarks[1] = new int[] { 1, 2 };
            JaggedMarks[2] = new int[] { 1, 2, 3, 4 };

            Console.WriteLine("\nJagged Array:");
            for (int i = 0; i < JaggedMarks.Length; i++)
            {
                for (int j = 0; j < JaggedMarks[i].Length; j++)
                {
                    Console.WriteLine($"JaggedMarks[{i},{j}] = {JaggedMarks[i][j]}");
                }
            }
            #endregion

            #region Functions
            // Calling Functions
            int sum = SumNumbers(2, 3);
            Console.WriteLine($"Sum of 2 and 3: {sum}");
            #endregion

            #region Passing Param
            // Passing By Reference
            int A = 4, B = 5;
            Console.WriteLine($"Before Swap: A = {A}, B = {B}");
            SWAP(ref A, ref B);
            Console.WriteLine($"After Swap: A = {A}, B = {B}");
            #endregion

            #region EX1
            int[] Numbers1 = { 1, 2, 3 };
            int result = SumArray(Numbers1);
            Console.WriteLine($"Sum of Array: {result}");
            #endregion

            #region EX2
            // Passing Parameter Reference Type
            int[] Numbers2 = { 1, 2, 3 };
            Console.WriteLine($"Sum of Array: {SumArray(Numbers2)}");
            #endregion

            #region PassByOut
            int sumOut, mulOut;
            SumMul(4, 5, out sumOut, out mulOut);
            Console.WriteLine($"Sum: {sumOut}, Mul: {mulOut}");
            #endregion

            #region PARAMS
            Console.WriteLine($"Sum of Params: {SumArray(1, 2, 3, 4, 5)}");
            #endregion
        }
    }
}
