using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 22, 112, 65, 90, 67, 0, 87, 34, 50, 32, 11, 51, 63, 71, 5, 13, 6 };

            Console.WriteLine("data before sorting");
            TraverseArray.Print(data);

            HeapSort heapsort = new HeapSort();
            heapsort.Sort(data);

            Console.WriteLine("data after ascending sorting");
            TraverseArray.Print(data);

            heapsort.SortDescending(data);

            Console.WriteLine("data after descending sorting");
            TraverseArray.Print(data);

            Console.WriteLine("Press any key to continue...");
            Console.Read();
        } 
    }
}
