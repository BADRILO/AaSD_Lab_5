using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    partial class Program
    {
        static void combinedQuickSort(int[] arr)
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
                        current = arr[i];
                        position = i;

                        while (position != start && arr[position - 1] > current)
                        {
                            arr[position] = arr[position - 1];
                            arr[position - 1] = current;
                            position--;
                        }
                    }
                    return;
                }

                int pivot_index = start;
                int pivot_value = arr[start];

                for (int temp, i = start + 1; i < end; i++)
                {
                    //bring to the left side all items that are smaller than pivot
                    if (arr[i] <= pivot_value)
                    {
                        pivot_index++;
                        temp = arr[pivot_index];
                        arr[pivot_index] = arr[i];
                        arr[i] = temp;
                    }
                }
                //put the pivot in its place
                arr[start] = arr[pivot_index];
                arr[pivot_index] = pivot_value;

                rec(start, pivot_index);
                rec(pivot_index + 1, end);
            }

            rec(0, arr.Length);
        }
    }
}
