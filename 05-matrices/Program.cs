using System.Linq;
using System;
namespace _05_matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[4];

            name[0]= "Alex";
            name[1]= "Thalia";
            name[2]= "Jose";
            name[3]= "Abigail";

            foreach (string i in name)
            {
                Console.WriteLine(i);
            }

            int[] number = {5,1,8,9,10};
            Console.WriteLine(number.Max());  // returns the largest value
            Console.WriteLine(number.Min());  // returns the smallest value
            Console.WriteLine(number.Sum());  // returns the sum of elements

            //Hola k hace
        }
    }
}
