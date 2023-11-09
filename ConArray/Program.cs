using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
              
                int arraySize = 5;

                int[] userArray = InputArrayElements(arraySize);

            
                Console.WriteLine("Array of User-Entered Integers:");
                PrintArray(userArray);

                int sum = CalculateSum(userArray);
                double average = CalculateAverage(userArray);

                Console.WriteLine($"\nSum of the array elements: {sum}");
                Console.WriteLine($"Average of the array elements: {average}");

     
                Console.ReadLine();
            }

            static int[] InputArrayElements(int size)
            {
                int[] array = new int[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter element {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int element))
                    {
                        array[i] = element;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                        i--; 
                    }
                }
                return array;
            }

            static void PrintArray(int[] array)
            {
                foreach (int num in array)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

            static int CalculateSum(int[] array)
            {
                int sum = 0;
                foreach (int num in array)
                {
                    sum += num;
                }
                return sum;
            }

            static double CalculateAverage(int[] array)
            {
                int sum = CalculateSum(array);
                return (double)sum / array.Length;
            }
        }

    }



