using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;

namespace Lab_5
{
    class Program
    {
        static void combinedQuickSort(List<int> list)
        {
            void rec(int start, int end)
            {
                //recursion base
                if (end - start < 10)
                {
                    int current;         //item to be inserted
                    int position;        //position of this item

                    for (int i = start + 1; i < end; i++)
                    {
                        current = list[i];
                        position = i;

                        while (position != start && list[position - 1] > current)
                        {
                            list[position] = list[position - 1];
                            list[position - 1] = current;
                            position--;
                        }
                    }
                    return;
                }

                int pivot_index = start;
                int pivot_value = list[start];

                for (int temp, i = start + 1; i < end; i++)
                {
                    //bring to the left side all items that are smaller than pivot
                    if (list[i] <= pivot_value)
                    {
                        pivot_index++;
                        temp = list[pivot_index];
                        list[pivot_index] = list[i];
                        list[i] = temp;
                    }
                }
                //put the pivot in its place
                list[start] = list[pivot_index];
                list[pivot_index] = pivot_value;

                rec(start, pivot_index);
                rec(pivot_index + 1, end);
            }

            rec(0, list.Count);
        }

        static void ordinaryQuickSort(List<int> list)
        {
            void rec(int start, int end)
            {
                //recursion base
                if (end - start < 2)
                {
                    return;
                }


                int pivot_index = start;        
                int pivot_value = list[start];

                for (int temp, i = start + 1; i < end; i++)
                {
                    //bring to the left side all items that are smaller than pivot
                    if (list[i] <= pivot_value)
                    {
                        pivot_index++;
                        temp = list[pivot_index];
                        list[pivot_index] = list[i];
                        list[i] = temp;
                    }
                }
                //put the pivot in its place
                list[start] = list[pivot_index];
                list[pivot_index] = pivot_value;
                
                rec(start, pivot_index);
                rec(pivot_index + 1, end);
            }

            rec(0, list.Count);
        }

        static void insertionSort(List<int> list)
        {
            int current;         //item to be inserted
            int position;        //position of this item

            for (int i = 1; i < list.Count; i++)
            {
                current = list[i];  
                position = i;
                
                while(position != 0 && list[position - 1] > current)
                {
                    //swap
                    list[position] = list[position - 1];
                    list[position - 1] = current;
                    position--;
                }
            }
        }

        static List<int> generateList(int length)
        {
            List<int> list = new(length);
            Random random = new();

            for (int i = 0; i < length; i++)
            {
                list.Add(random.Next(9999));
            }
            return list;
        }

        static void printList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write($"{item, -4} ");
            }
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new();
            List<int> testList = generateList(1000);
            List<int> testList1 = new();
            List<int> testList2 = new();

            testList1.AddRange(testList);
            testList2.AddRange(testList);
            printList(testList);
            printList(testList1);
            printList(testList2);


            Console.WriteLine("COMBINED QUICK SORT");
            stopwatch.Start();
            combinedQuickSort(testList);
            stopwatch.Stop();
            printList(testList);
            Console.WriteLine("Elapsed time:" + stopwatch.ElapsedTicks + ";\n\n");



            Console.WriteLine("ORDINARY QUICK SORT");
            stopwatch.Restart();
            ordinaryQuickSort(testList1);
            stopwatch.Stop();
            printList(testList1);
            Console.WriteLine("Elapsed time:" + stopwatch.ElapsedTicks + ";\n\n");



            Console.WriteLine("INSERTION SORT");
            stopwatch.Restart();
            insertionSort(testList2);
            stopwatch.Stop();
            printList(testList2);
            Console.WriteLine("Elapsed time:" + stopwatch.ElapsedTicks + ";\n\n");
        }
    }
}
