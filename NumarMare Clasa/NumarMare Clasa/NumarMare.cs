using System;
namespace NumarMare_Clasa
{
    // Folosim clasa Factorial astfel: 
    // Factorial fact = new Factorial();
    // NumarMare nm = fact.GetFactorial(14);
    // nm.PrintSimple();
    class Factorial
    {
        public Factorial()
        {

        }

        public NumarMare GetFactorial(int term)
        {
            NumarMare a = null;
            NumarMare result = new NumarMare("1");

            for (int i = 0; i < term; i++)
            {
                a = new NumarMare(""+(i+1));
                result = result.Multiply(a);
            }

            return result;
        }
    }

    // Folosim clasa Fibonacci astfel:
    // int term = 100;
    // NumarMare nm = f.GetTerm(term);
    // Console.Write("Fibonacci " + term + "th term is: ");
    // nm.PrintSimple();
    class Fibonacci
    {
        public Fibonacci()
        {
        }

        public NumarMare GetTerm(int term)
        {
            NumarMare a, b, c;
            a = new NumarMare("0");
            b = new NumarMare("1");
            c = null;

            for (int i = 2; i < term; i++)
            {
                c = a.Add(b);

                a = b;
                b = c;
            }

            return c;
        }

        /* Output:
         * Fibonacci: 0 1 1 2 3 5 8 13 21 34 55 89 144 233 377 610 987 1597 2584 4181 6765 10946 17711 28657 46368 75025 121393 196418 317811 514229 832040 1346269 2178309 3524578 5702887 9227465 14930352 24157817 39088169 63245986 102334155 165580141 267914296 433494437 701408733 1134903170 1836311903 2971215073 4807526976 7778742049 12586269025 20365011074 32951280099 53316291173 86267571272 139583862445 225851433717 365435296162 591286729879 956722026041 1548008755920 2504730781961 4052739537881 6557470319842 10610209857723 17167680177565 27777890035288 44945570212853 72723460248141 117669030460994 190392490709135 308061521170129 498454011879264 806515533049393 1304969544928657 2111485077978050 3416454622906707 5527939700884757 8944394323791464 14472334024676221 23416728348467685 37889062373143906 61305790721611591 99194853094755497 160500643816367088 259695496911122585 420196140727489673 679891637638612258 1100087778366101931 1779979416004714189 2880067194370816120 4660046610375530309 7540113804746346429 12200160415121876738 19740274219868223167 31940434634990099905 51680708854858323072 83621143489848422977 135301852344706746049 218922995834555169026
         * */
        public void generate(int term)
        {
            NumarMare a, b, c;
            a = new NumarMare("0");
            b = new NumarMare("1");

            Console.Write("Fibonacci: ");
            
            a.PrintSimple();
            Console.Write(" ");
            
            b.PrintSimple();
            Console.Write(" ");

            for (int i = 2; i < term; i++)
            {
                c = a.Add(b);
                c.PrintSimple();
                Console.Write(" ");

                a = b;
                b = c;
            }

            Console.WriteLine();
        }
    }

    class NumarMare
    {
        private int[] tablou;

        public NumarMare()
        {
            this.tablou = null;

        }

        public NumarMare(String text)
        {
            tablou = new int[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                tablou[i] = int.Parse(text.Substring(i,1));
            }
        }
        public NumarMare(int[] tablou)
        {           
            this.tablou = tablou;
           
        }
        
        public void Init(int count)
        {
            Random rnd = new Random();
            tablou = new int[count];
            for (int i = 0; i < count; i++)
            {
                tablou[i] = rnd.Next(10);
            }
        }

        public void Print()
        {        
            for (int i = 0; i < tablou.Length; i++)
            {
                Console.Write(tablou[i] + " ");
            }
            Console.WriteLine();
        }

        public void PrintSimple()
        {
            for (int i = 0; i < tablou.Length; i++)
            {
                Console.Write(tablou[i]);
            }
        }

        public NumarMare Add(NumarMare nm)
        {
            int[] NmData = nm.GetData();
            int ResultSize;
            if(NmData.Length > tablou.Length)
            {
                ResultSize = NmData.Length;
            } else
            {
                ResultSize = tablou.Length;
            }
            ++ResultSize;

            int carry = 0;
            int[] res = new int[ResultSize];
            int i = tablou.Length - 1;
            int j = NmData.Length - 1;
            int k = ResultSize - 1;
            for ( ; k >= 0; i--, j--, k--)
            {
                int s = carry;
                if(i >= 0)
                {
                    s += tablou[i];
                }

                if (j >= 0)
                {
                    s += NmData[j];
                }

                if (s > 9)
                {
                    res[k] = s % 10;
                    carry = s / 10;
                    //res[k - 1] = carry;
                }
                else
                {
                    res[k] = s;
                    carry = 0;
                }
            }
            
            if (res[0] == 0)
            {
                res = RemoveAt(res, 0);
            }

            return new NumarMare(res);
        }

        private int[] RemoveAt(int[] IndicesArray, int RemoveAt)
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

        public NumarMare Multiply(NumarMare nm)
        {
            int[] v = nm.GetData();
            int[] t = tablou;
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
                    if (s > 9)
                    {
                        rowRes[j + 1] = s % 10;
                        carry = s / 10;
                    }
                    else
                    {
                        rowRes[j + 1] = s;
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
            return new NumarMare(finalRes);
        }

        public int[] GetData()
        {
            return tablou;
        }

        public override string ToString()
        {
            return string.Format("[Numarul {0} cu {1}] cifre", tablou, tablou.Length);
        }
    }
}