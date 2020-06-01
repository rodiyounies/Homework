using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort_Implementation
{
    class TraverseArray
    {
        public static void Print(int[] elements)
        {
            for (int i = 0; i < elements.Length; ++i)
            {
                Console.Write(elements[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
