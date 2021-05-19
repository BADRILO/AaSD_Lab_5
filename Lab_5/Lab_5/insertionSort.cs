using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    partial class Program
    {
        static void insertionSort(int[] arr)
        {
            int current;         //item to be inserted
            int position;        //position of this item

            for (int i = 1; i < arr.Length; i++)
            {
                current = arr[i];
                position = i;

                while (position != 0 && arr[position - 1] > current)
                {
                    //swap
                    arr[position] = arr[position - 1];
                    arr[position - 1] = current;
                    position--;
                }
            }
        }
    }
}
