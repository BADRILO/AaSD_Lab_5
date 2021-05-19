using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;

namespace Lab_5
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new();
            int[] testArr  = generateArr(1000);
            int[] testArr1 = new int[testArr.Length];
            int[] testArr2 = new int[testArr.Length];


            testArr.CopyTo(testArr1, 0);
            testArr.CopyTo(testArr2, 0);
            printArr(testArr);
            printArr(testArr1);
            printArr(testArr2);


            Console.WriteLine("COMBINED QUICK SORT");
            stopwatch.Restart();
            combinedQuickSort(testArr);
            stopwatch.Stop();
            printArr(testArr);
            Console.WriteLine("Elapsed time:" + stopwatch.ElapsedTicks + ";\n\n");



            Console.WriteLine("ORDINARY QUICK SORT");
            stopwatch.Restart();
            ordinaryQuickSort(testArr1);
            stopwatch.Stop();
            printArr(testArr1);
            Console.WriteLine("Elapsed time:" + stopwatch.ElapsedTicks + ";\n\n");



            Console.WriteLine("INSERTION SORT");
            stopwatch.Restart();
            insertionSort(testArr2);
            stopwatch.Stop();
            printArr(testArr2);
            Console.WriteLine("Elapsed time:" + stopwatch.ElapsedTicks + ";\n\n");
        }
    }
}
