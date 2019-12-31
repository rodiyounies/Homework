using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCD_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Base 10 number: ");
            int num = int.Parse(Console.ReadLine());
            convertToBCD(num);
        }

        private static void convertToBCD(int num)
        {
            Stack myStack = new Stack();
            while(num != 0)
            {
                int result = num % 10;
                myStack.Push(result);
                num = num / 10;
            }

            Console.Write("BCD Result: ");
            foreach (int obj in myStack)
            {
                string result = Convert.ToString(obj, 2).PadLeft(4, '0');
                Console.Write(result);
                Console.Write(" ");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
