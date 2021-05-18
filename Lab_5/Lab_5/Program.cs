using System;
using System.Collections.Generic;

namespace Lab_5
{
    class Program
    {
        static void ordinaryQuickSort(List<int> list)
        {
            void rec(int start, int end)
            {
                if (end - start < 2)
                {
                    return;
                }

                int pivot_index = start;

                for (int temp, i = start + 1; i < end; i++)
                {
                    if (list[i] <= list[pivot_index])
                    {
                        temp = list[i];
                        list.RemoveAt(i);
                        list.Insert(pivot_index++, temp);
                    }
                }
                
                rec(start, pivot_index);
                rec(pivot_index + 1, end);
            }

            rec(0, list.Count);
        }

        static void insertionSort(List<int> list)
        {
            int current;
            int insert_position;

            for (int i = 1; i < list.Count; i++)
            {
                current = list[i];
                insert_position = i;
                
                while(insert_position != 0 && current < list[insert_position - 1])
                {
                    insert_position--;
                }

                list.RemoveAt(i);
                list.Insert(insert_position, current);
            }

        }

        static List<int> generateList(int length)
        {
            List<int> list = new(length);
            Random random = new();

            for (int i = 0; i < length; i++)
            {
                list.Add(random.Next(1000));
            }
            return list;
        }

        static void printList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write($"{item, -3} ");
            }
            Console.WriteLine("\n");
        }

        //65318724
        static void Main(string[] args)
        {
            List<int> testList = generateList(100);
            printList(testList);

            ordinaryQuickSort(testList);
            printList(testList);
        }
    }
}
