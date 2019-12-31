using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_secvente_pe_32_biti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a float: ");
            float num = float.Parse(Console.ReadLine());
            convertFloatToBinary(num);
        }

        private static void convertFloatToBinary(float num)
        {
            Console.WriteLine("Converting float [" + num +"] to 32 bits");

            Stack myStack = new Stack();
            byte[] result = BitConverter.GetBytes(num);
            for(int i = 0; i < result.Length; i++)
            {
                string s = Convert.ToString(result[i], 2).PadLeft(8, '0');
                myStack.Push(s);
            }

            Console.Write("Result: ");
            foreach (string obj in myStack)
            {
                Console.Write(obj);
                Console.Write(" ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
