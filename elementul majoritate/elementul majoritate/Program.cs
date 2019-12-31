using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elementul_majoritate
{
    class Program
    {
        public static void Main()
        {

            int[] a = { 3, 1, 3, 3, 3, 2, 5, 3 };
            int size = a.Length;
            printMajorityMehtod1(a);
            printMajorityMethod2(a);
        }

        static void printMajorityMehtod1(int[] a)
        {
            Dictionary<int, int> monitors = new Dictionary<int, int>(a.Length);

            // initialize collections
            for (int i = 0; i < a.Length; i++)
            {
                int key = a[i];
                monitors[key] = 0;
            }

            //scan elements for majority
            bool found = false;
            for (int i = 0; i<a.Length; i++)
            {
                int key = a[i];
                int count = monitors[key];

                ++count;
                monitors[key] = count;
                monitors[a[i]] = count;

                if(count > (a.Length/2))
                {
                    Console.WriteLine("Majority: " + a[i]);
                    found = true;
                }
            }

            if (found == false)
            {
                Console.WriteLine("No Majority Found");
            }
        }

        /* 
         * Function to print Majority Element 
         */
        static void printMajorityMethod2(int[] a)
        {
            int size = a.Length;
            /* Find the candidate for Majority*/
            int cand = findCandidate(a, size);

            /* Print the candidate if it is Majority*/
            if (isMajority(a, size, cand))
                Console.WriteLine("Majority: " + cand);
            else
                Console.Write("No Majority Element");

            Console.ReadKey();
        }

        /* 
         * Function to find the candidate for Majority 
         */
        static int findCandidate(int[] a, int size)
        {
            int maj_index = 0, count = 1;
            int i;
            for (i = 1; i < size; i++)
            {
                if (a[maj_index] == a[i])
                    count++;
                else
                    count--;

                if (count == 0)
                {
                    maj_index = i;
                    count = 1;
                }
                //Console.WriteLine("a[maj_index] = {0}, count = {1}, a[i] = {2}", a[maj_index], count, a[i]);
            }
            return a[maj_index];
        }

        // Function to check if the candidate  
        // occurs more than n/2 times 
        static bool isMajority(int[] a, int size, int cand)
        {
            int i, count = 0;
            for (i = 0; i < size; i++)
            {
                if (a[i] == cand)
                    count++;
            }
            if (count > size / 2)
                return true;
            else
                return false;
        }
    }
}

