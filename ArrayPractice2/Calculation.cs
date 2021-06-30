using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayPractice2
{
    class Calculation
    {
        // Taking input from user
        public int[] UserInput()
        {
            Console.WriteLine("Input 5 numbers :");
            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }

        // Printing values on output
        public void PrintArray(int[] array)
        {
            Console.Write("[");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("]");
        }

        // Calculating average
        public void Average(int[] array)
        {
            int avg = 0;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            avg = sum / 5;
            Console.WriteLine(avg);
        }
    }
}
