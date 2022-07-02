using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {

        // Taks 1

        public static Boolean isPalindrome(String text)
        {

            char[] charArrayOfText = text.ToCharArray();
            Array.Reverse(charArrayOfText);
            return text == new string(charArrayOfText);

        }



        // Task 4

        public static Boolean isProperly(String sequence)
        {

            int idx = 0;
            char[] stack = new char[sequence.Length];

            for (int i = 0; i < sequence.Length; i++)
            {
                char c = sequence[i];
                if (c == '(')
                {
                    stack[idx++] = c;
                }
                else
                {
                    if (idx == 0)
                    {
                        return false;
                    }
                    char c1 = stack[idx - 1];
                    if (c1 == '(' && c == ')')
                    {
                        idx--;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (idx != 0)
            {
                return false;
            }
            return true;

        }




        // Task 5 

        public static int countVariants(int n, int m)
        {
            int[] res = new int[n + 1];
            int temp = 0;
            res[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                int s = i - m - 1;
                int e = i - 1;
                if (s >= 0)
                {
                    temp -= res[s];
                }
                temp += res[e];
                res[i] = temp;
            }
            return res[n];
        }


        static void Main(string[] args)
        {

            // 1
            Console.WriteLine(isPalindrome("beeb"));
            Console.WriteLine(isPalindrome("Dell"));



            // 4
            Console.WriteLine(isProperly("())("));
            Console.WriteLine(isProperly("(()())"));




            // 5
            int n = 12, m = 10;
            Console.WriteLine("Number of variants = " + countVariants(n, m));


            Console.ReadLine();

        }
    }
}
