using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort_Implementation
{
    class HeapSort
    {
        public void Sort(int[] elements)
        {
            SortAscending(elements);
        }

        public void SortAscending(int[] elements)
        {
            sortInternal(elements, true);
        }

        public void SortDescending(int[] elements)
        {
            sortInternal(elements, false);
        }

        private void sortInternal(int[] elements, bool ascending)
        {
            int n = elements.Length;

            // Build heap (rearrange array) 
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                if (ascending)
                {
                    buildMaxHeap(elements, n, i);
                } else
                {
                    buildMinHeap(elements, n, i);
                }
            }

            // One by one extract an element from heap 
            for (int i = n - 1; i > 0; i--)
            {
                // Move current root to end
                swap(elements, 0, i);

                // Build another max heap using the reduced array 
                if (ascending)
                {
                    buildMaxHeap(elements, i, 0);
                } else
                {
                    buildMinHeap(elements, i, 0);
                }
            }
        }

        /**
         * Build Max heap
         */
        private void buildMaxHeap(int[] elements, int n, int i)
        {
            // Initialize largest as root 
            int largest = i; 

            // get left element
            int leftElement = getLeftElement(elements, i); 

            // get right element
            int rightElement = getRightElement(elements, i);

            // If left child is larger than root 
            if (leftElement < n && elements[leftElement] > elements[largest])
            {
                largest = leftElement;
            }

            // If right child is larger than largest so far 
            if (rightElement < n && elements[rightElement] > elements[largest])
            {
                largest = rightElement;
            }

            // If largest is not root, swap and 
            // recursively build max heap using sub-tree 
            if (largest != i)
            {
                swap(elements, i, largest);               
                buildMaxHeap(elements, n, largest);
            }
        }

        /**
         * Build Min heap
         */
        private void buildMinHeap(int[] elements, int n, int i)
        {
            // Initialize largest as root 
            int smallest = i;

            // get left element
            int leftElement = getLeftElement(elements, i);

            // get right element
            int rightElement = getRightElement(elements, i);

            // If left child is larger than root 
            if (leftElement < n && elements[leftElement] < elements[smallest])
            {
                smallest = leftElement;
            }

            // If right child is larger than largest so far 
            if (rightElement < n && elements[rightElement] < elements[smallest])
            {
                smallest = rightElement;
            }

            // If largest is not root, swap and 
            // recursively build max heap using sub-tree 
            if (smallest != i)
            {
                swap(elements, i, smallest);
                buildMinHeap(elements, n, smallest);
            }
        }

        /**
         * Swaps the contents of two array elements. Element positions
         * are identified by i, and j. Since elements array is passed by reference,
         * the function has void return.
         */
        private void swap(int[] elements, int i, int j)
        {
            int swap = elements[i];
            elements[i] = elements[j];
            elements[j] = swap;
        }
        private int getLeftElement(int[] elements, int i)
        {
            return getParent(elements, i) + 1;
        }

        private int getRightElement(int[] elements, int i)
        {
            return getParent(elements, i) + 2;
        }

        private int getParent(int[] elements, int i)
        {
            return 2 * i;
        }
    }
}
