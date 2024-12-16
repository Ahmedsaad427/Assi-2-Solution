using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment_2
{
    internal class Program
    {
        #region Question1 - Passing by Value and Reference
        static void ChangeValue(int value)
        {
            value = 10; // This change won't affect the original variable
        }

        static void ChangeValueByRef(ref int value)
        {
            value = 10; // This change will affect the original variable
        }
        #endregion

        #region Question2 - Reference Type Behavior
        class MyClass
        {
            public int Value;
        }

        static void ChangeObject(MyClass obj)
        {
            obj.Value = 10; // This affects the original object
        }

        static void ReassignObject(ref MyClass obj)
        {
            obj = new MyClass { Value = 20 }; // This changes the original reference
        }
        #endregion

        #region Question3 - Summation and Subtraction
        static (int sum, int diff) Calculate(int num1, int num2, int num3, int num4)
        {
            int sum = num1 + num2 + num3 + num4;
            int diff = (num1 + num2) - (num3 + num4);
            return (sum, diff);
        }
        #endregion

        #region Question4 - Sum of Digits
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        #endregion

        #region Question5 - Prime Check
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        #endregion

        #region Question6 - Min and Max in Array
        static void MinMaxArray(int[] arr, out int min, out int max)
        {
            min = arr[0];
            max = arr[0];
            foreach (int num in arr)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
        }
        #endregion

        #region Question7 - Factorial Calculation
        static int Factorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
        #endregion

        #region Question8 - Modify Character in String
        static string ChangeChar(string input, int position, char newChar)
        {
            char[] chars = input.ToCharArray();
            chars[position] = newChar;
            return new string(chars);
        }
        #endregion

        #region Question9 - Identity Matrix
        static void PrintIdentityMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(i == j ? "1 " : "0 ");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Question10 - Sum of Array Elements
        static int SumArray(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }
        #endregion

        #region Question11 - Merge Arrays
        static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] merged = arr1.Concat(arr2).OrderBy(x => x).ToArray();
            return merged;
        }
        #endregion

        #region Question12 - Count Frequency of Array Elements
        static void CountFrequency(int[] arr)
        {
            var frequencies = arr.GroupBy(x => x)
                                 .Select(group => new { Value = group.Key, Frequency = group.Count() })
                                 .OrderBy(x => x.Value);
            foreach (var item in frequencies)
            {
                Console.WriteLine($"Value {item.Value} occurs {item.Frequency} times");
            }
        }
        #endregion

        #region Question13 - Find Maximum and Minimum Element in Array
        static void MaxMinElement(int[] arr)
        {
            int max = arr.Max();
            int min = arr.Min();
            Console.WriteLine($"Maximum: {max}, Minimum: {min}");
        }
        #endregion

        #region Question14 - Find the Second Largest Element
        static int SecondLargest(int[] arr)
        {
            int[] uniqueArr = arr.Distinct().ToArray();
            Array.Sort(uniqueArr);
            return uniqueArr.Length > 1 ? uniqueArr[uniqueArr.Length - 2] : -1;
        }
        #endregion

        #region Question15 - Longest Distance Between Equal Cells
        static int LongestDistance(int[] arr)
        {
            Dictionary<int, int> positions = new Dictionary<int, int>();
            int maxDistance = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (positions.ContainsKey(arr[i]))
                {
                    maxDistance = Math.Max(maxDistance, i - positions[arr[i]]);
                }
                else
                {
                    positions[arr[i]] = i;
                }
            }
            return maxDistance;
        }
        #endregion

        #region Question17 - Reverse the Order of Words
        static string ReverseWords(string sentence)
        {
            var words = sentence.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
        #endregion

        #region Question18 - Multidimensional Arrays and Copy Elements
        static void CopyArray()
        {
            int[,] array1 = new int[2, 2];
            int[,] array2 = new int[2, 2];

            Console.WriteLine("Enter values for the first array:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    array1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Array.Copy(array1, array2, array1.Length);

            Console.WriteLine("\nSecond Array after copy:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(array2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Question19 - Reverse a One-Dimensional Array
        static void PrintArrayReverse(int[] arr)
        {
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
        #endregion

        #region Question18 - Array Manipulation (Reverse)
        static void ReverseArrayManipulation()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Array.Reverse(arr);
            Console.WriteLine("Reversed Array: " + string.Join(", ", arr));
        }
        #endregion

        #region Question19 - Find Missing Number in Array
        static int FindMissingNumber(int[] arr, int size)
        {
            int total = (size + 1) * (size + 2) / 2;
            int sum = arr.Sum();
            return total - sum;
        }
        #endregion

        static void Main(string[] args)
        {
            #region Question1 - Passing by Value and Reference
            int First_Number = 5;
            Console.WriteLine("Original Value: " + First_Number);

            // Pass by value
            ChangeValue(First_Number);
            Console.WriteLine("After ChangeValue: " + First_Number);

            // Pass by reference
            ChangeValueByRef(ref First_Number);
            Console.WriteLine("After ChangeValueByRef: " + First_Number);
            #endregion

            #region Question2 - Reference Type Behavior
            MyClass myObj = new MyClass { Value = 5 };
            Console.WriteLine("\nOriginal Value in MyClass: " + myObj.Value);

            ChangeObject(myObj);
            Console.WriteLine("After ChangeObject: " + myObj.Value);

            ReassignObject(ref myObj);
            Console.WriteLine("After ReassignObject: " + myObj.Value);
            #endregion

            #region Question3 - Summation and Subtraction
            Console.WriteLine("Question 3: Summation and Subtraction");
            Console.Write("Enter four numbers separated by space: ");
            var inputs = Console.ReadLine().Split();
            int num1 = int.Parse(inputs[0]);
            int num2 = int.Parse(inputs[1]);
            int num3 = int.Parse(inputs[2]);
            int num4 = int.Parse(inputs[3]);
            var result = Calculate(num1, num2, num3, num4);
            Console.WriteLine($"Summation: {result.sum}, Subtraction: {result.diff}");
            #endregion

            #region Question4 - Sum of Digits
            Console.WriteLine("\nQuestion 4: Sum of Digits");
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"The sum of the digits of the number {number} is: {SumOfDigits(number)}");
            #endregion

            #region Question5 - Check Prime
            Console.WriteLine("\nQuestion 5: Check Prime");
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Is {number} prime? {IsPrime(number)}");
            #endregion

            #region Question6 - Min and Max in Array
            Console.WriteLine("\nQuestion 6: Min and Max in Array");
            int[] numbers = { 10, 20, 5, 40, 15 };
            MinMaxArray(numbers, out int min, out int max);
            Console.WriteLine($"Minimum: {min}, Maximum: {max}");
            #endregion

            #region Question7 - Factorial Calculation
            Console.WriteLine("\nQuestion 7: Factorial Calculation");
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Factorial of {number} is: {Factorial(number)}");
            #endregion

            #region Question8 - Modify Character in String
            Console.WriteLine("\nQuestion 8: Modify Character in String");
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();
            Console.Write("Enter the position of the character to modify: ");
            int position = int.Parse(Console.ReadLine());
            Console.Write("Enter the new character: ");
            char newChar = Console.ReadLine()[0];
            Console.WriteLine($"Modified string: {ChangeChar(inputString, position, newChar)}");
            #endregion

            #region Question9 - Identity Matrix
            Console.WriteLine("\nQuestion 9: Identity Matrix");
            Console.Write("Enter a number for the size of the identity matrix: ");
            int n = int.Parse(Console.ReadLine());
            PrintIdentityMatrix(n);
            #endregion

            #region Question10 - Sum of Array Elements
            Console.WriteLine("\nQuestion 10: Sum of Array Elements");
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"The sum of the array elements is: {SumArray(arr)}");
            #endregion

            #region Question11 - Merge Arrays
            Console.WriteLine("\nQuestion 11: Merge Arrays");
            int[] arr1 = { 1, 5, 8 };
            int[] arr2 = { 3, 7, 2 };
            Console.WriteLine("Merged and Sorted Arrays: ");
            Console.WriteLine(string.Join(", ", MergeArrays(arr1, arr2)));
            #endregion

            #region Question12 - Count Frequency of Array Elements
            Console.WriteLine("\nQuestion 12: Count Frequency of Array Elements");
            int[] arrFrequency = { 1, 2, 2, 3, 3, 3, 4 };
            CountFrequency(arrFrequency);
            #endregion

            #region Question13 - Find Max and Min in Array
            Console.WriteLine("\nQuestion 13: Find Max and Min in Array");
            MaxMinElement(arr);
            #endregion

            #region Question14 - Second Largest Element in Array
            Console.WriteLine("\nQuestion 14: Find the Second Largest Element in Array");
            Console.WriteLine($"Second Largest Element: {SecondLargest(arr)}");
            #endregion

            #region Question15 - Longest Distance Between Equal Cells
            Console.WriteLine("\nQuestion 15: Longest Distance Between Equal Cells");
            int[] arrWithDuplicates = { 1, 2, 3, 2, 1 };
            Console.WriteLine($"Longest Distance: {LongestDistance(arrWithDuplicates)}");
            #endregion

            #region Question17 - Reverse the Order of Words
            Console.WriteLine("\nQuestion 17: Reverse the Order of Words");
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            Console.WriteLine($"Reversed Words: {ReverseWords(sentence)}");
            #endregion

            #region Question18 - Multidimensional Array Copy
            Console.WriteLine("\nQuestion 18: Multidimensional Array Copy");
            CopyArray();
            #endregion

            #region Question19 - Reverse a One-Dimensional Array
            Console.WriteLine("\nQuestion 19: Reverse a One-Dimensional Array");
            PrintArrayReverse(arr);
            #endregion
        }
    }
}
