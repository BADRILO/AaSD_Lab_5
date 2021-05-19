using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    partial class Program
    {
        static void printArr(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write($"{item,-4} ");
            }
            Console.WriteLine("\n");
        }
    }
}
