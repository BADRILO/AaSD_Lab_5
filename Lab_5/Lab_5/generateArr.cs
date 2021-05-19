using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    partial class Program
    {
        static int[] generateArr(int length)
        {
            int[] arr = new int[length];
            Random random = new();

            for (int i = 0; i < length; i++)
            {
                arr[i] = random.Next(9999);
            }
            return arr;
        }
    }
}
