using System;

namespace ArrayPractice2
{
    //// Program to find the average of n numbers using arrays
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calc = new Calculation();

            //prints array
            int[] arr = calc.UserInput();
            calc.PrintArray(arr);

            //sort array list
            Array.Sort(arr);
            calc.PrintArray(arr);

            //print average
            calc.Average(arr);
        }
    }
}
