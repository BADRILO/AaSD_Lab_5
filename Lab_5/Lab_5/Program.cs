using System;
using System.Collections.Generic;

namespace Lab_5
{
    class Program
    {
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
            List<int> testList = new() { 6, 5, 3, 1, 8, 7, 2, 4 };
            printList(testList);

            insertionSort(testList);
            printList(testList);
        }
    }
}
