using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CallBubbleSort();
            Console.ReadKey();
        }

        public static void CallBubbleSort()
        {
            Console.WriteLine("Enter integers separated by comma");
            var numbers = Console.ReadLine();
            Console.WriteLine($"Numbers Entered {numbers}");
            var array = numbers.Split(',');
            int[] intArray = Array.ConvertAll(array, s => int.Parse(s));


            Console.WriteLine($"Sorted Array: ");
            foreach (var item in  BubbleSort.Sort(intArray))
            {
                Console.Write($"{item} ;");
            }
            

        }
    }
}
