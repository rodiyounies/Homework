using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61.Operatii_cu_numere_mari
{
    // 61. Operatii cu numere mari. Se dau 2 numere mari stocate intr-un vector. 
    // Fiecare element al vectorului stocheaza o cifra zecimala.
    // Calculati suma, diferenta si produsul acestor numere. (ex: un vector cu 1000 elem (cifre); avem doi vectori )
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Size of Vector: ");
            int count = int.Parse(Console.ReadLine());

            int[] v = ReadVector("Vector #1: ", count);
            int[] t = ReadVector("Vector #2: ", count);
            PrintVector("Vector #1: ", v);
            PrintVector("Vector #2: ", t);

            int[] sum = AddVectors(v, t);
            PrintVector("Sum of Two Vectors: ", sum);

            int[] newt = copyArray(t);
            int[] diff = DiffVectors(v, newt);
            PrintVector("Difference of Two Vectors: ", diff);

            int[] multiplication = MultipleVectors(v, t);
            PrintVector("Multiplication of Two Vectors: ", multiplication);

            Console.ReadKey();

        }

        private static int[] AddVectors(int[] v, int[] t)
        {
            int carry = 0;
            int[] res = new int[v.Length + 1];
            for(int i = v.Length - 1; i >= 0; i--)
            {
                int s = v[i] + t[i] + carry;
                if(s > 9)
                {
                    res[i+1] = s % 10;
                    carry  = s / 10;                    
                } else
                {
                    res[i+1] = s;
                    carry = 0;
                }
            }
            res[0] = carry;
            if (res[0] == 0)
                return RemoveAt(res, 0);
            else
                return res;
        }

        private static int[] DiffVectors(int[] v, int[] t)
        {
            int[] v1, v2;
            bool negativeResult = false;
            if(v[0] > t[0])
            {
                v1 = v;
                v2 = t;
            } else
            {
                v1 = t;
                v2 = v;
                negativeResult = true;
            }

            int[] res = new int[v.Length];
            for (int i = v.Length - 1; i >= 0; i--)
            {
                int s = v1[i] - v2[i];
                if (s >= 0)
                {
                    res[i] = v1[i] - v2[i];
                }
                else
                {
                    res[i] = (v1[i] + 10) - v2[i];
                    v1[i-1] = v1[i-1] - 1;
                }
            }

            // add negative if needed
            if (negativeResult)
            {
                if (res[0] == 0)
                {
                    res[1] = -1 * res[1];
                } else
                {
                    res[0] = -1 * res[0];
                }
            }

            // Remove leading left zero
            int[] finalRes = res;
            if (res[0] == 0)
            {
                finalRes = RemoveAt(res, 0);
            }
            return finalRes;
        }

        private static int[] MultipleVectors(int[] v, int[] t)
        {
            int shiftLeft = 0;
            int resultsSize = v.Length + t.Length;
            int[] res = new int[resultsSize];          
            for (int i = t.Length - 1; i >= 0; i--)
            {
                int carry = 0;
                int[] rowRes = new int[v.Length + 1];
                for (int j = v.Length - 1; j >= 0; j--)
                {
                   int s = (t[i] * v[j]) + carry;
                    if (s > 9 )
                    {
                        rowRes[j+1] = s % 10;
                        carry = s / 10;
                    }
                    else
                    {
                        rowRes[j+1] = s;
                        carry = 0;
                    }
                }
                rowRes[0] = carry;
                
                // add row results to final results
                carry = 0;
                int n = 0;
                for (int k = rowRes.Length - 1; k >= 0; ++n, k--)
                {
                    int index = (resultsSize - 1) - shiftLeft - n;
                    int s = res[index] + rowRes[k] + carry;
                    if (s > 9)
                    {
                        res[index] = s % 10;
                        carry = s / 10;
                    }
                    else
                    {
                        res[index] = s;
                        carry = 0;
                    }
                }

                ++shiftLeft;
            }

            // Remove leading left zero
            int[] finalRes = res;
            if (res[0] == 0)
            {
                finalRes = RemoveAt(res, 0);
            }
            return finalRes;
        }

        private static int[] ReadVector(string msg, int count)
        {
            int[] v = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write(msg + "Enter element No. {0}: ", (i + 1));
                v[i] = int.Parse(Console.ReadLine());
            }

            return v;
        }

        private static void PrintVector(string msg, int[] v)
        {
            Console.Write(msg);
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i]);
            }
            Console.WriteLine();
        }

        private static int[] RemoveAt(int[] IndicesArray, int RemoveAt)
        {
            int[] newIndicesArray = new int[IndicesArray.Length - 1];

            int i = 0;
            int j = 0;
            while (i < IndicesArray.Length)
            {
                if (i != RemoveAt)
                {
                    newIndicesArray[j] = IndicesArray[i];
                    j++;
                }

                i++;
            }

            return newIndicesArray;
        }

        private static int[] copyArray(int[] v)
        {
            int[] t = new int[v.Length];

            for(int i = 0; i< v.Length; i++)
            {
                t[i] = v[i];
            }

            return t;
        }
    }
}
