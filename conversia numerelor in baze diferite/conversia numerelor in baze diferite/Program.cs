using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversia_numerelor_in_baze_diferite
{ 
    /*
     * convertim nr din baza  x intr-o alta baza y
     * input number1
     * input baza numarului
     * input baza tinta  
     * output baza tinta 
     */
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Introduceti un numar: ");
            string num = Console.ReadLine();

            Console.Write("Baza numarului este: ");
            string inputBase = Console.ReadLine();

            Console.Write("Baza tinta este: ");
            string targetBase = Console.ReadLine();

            //check base
            string base10number = num;
            if (!inputBase.Equals("10"))
            {
                int convertireBaza=  convertNumberBaseToDecimalBase(num, inputBase);
                Console.WriteLine("in baza 10 numarul este: " + convertireBaza);

                base10number = "" + convertireBaza;
            }

            // invoke conversion...
            string result = convertNumberToOctalOrBinary(base10number, targetBase);

            Console.WriteLine();
            Console.WriteLine("Convertim [" + num + "] din baza [" + inputBase + "] in baza [" + targetBase + "]");
            Console.WriteLine("Rezultat: [" + result + "]");
            Console.ReadLine();
        }

        static int convertNumberBaseToDecimalBase(string text, string inputBase)
        {
            int max = text.Length - 1;
            int iBase = int.Parse(inputBase);

            int result = 0 ;
            for(int i = 0; i< text.Length; i++)
            {
                int n = int.Parse(text.Substring(i, 1));
                result = result + (int) (n * Math.Pow(iBase, max-i));
            }
                        
            return result;
        }

        static string convertNumberToOctalOrBinary(string text, string targetBase) {
            int num = int.Parse(text);
            int tbase = int.Parse(targetBase);

            int s = num;
            string result = "";
            do {
                if(s<tbase)
                {
                    result = result + convertToHexChar(s);
                } else
                {
                    result = result + convertToHexChar((s % tbase));
                }

                s = s / tbase;
            } while (s>0);
            
            return reverseString(result);
        }

        static string convertToHexChar(int num)
        {
            string hexValue = "";

            switch(num)
            {
                case 10: 
                    hexValue = "A";
                    break;
                case 11:
                    hexValue = "B";
                    break;
                case 12:
                    hexValue = "C";
                    break;
                case 13:
                    hexValue = "D";
                    break;
                case 14:
                    hexValue = "E";
                    break;
                case 15:
                    hexValue = "F";
                    break;
                default:
                    hexValue = "" + num;
                    break;
            }
                        
            return hexValue;
        }

        static string reverseString(string text)
        {
            char[] textChars = text.ToCharArray();
            Array.Reverse(textChars);
            
            return new string(textChars);
        }
    }
}
