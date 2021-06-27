﻿using System;

namespace PerfectSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SquareDigits(0));
        }

        public static int SquareDigits(int n)
        {
            //Welcome.In this kata, you are asked to square every digit
            //of a number and concatenate them.
            //For example, if we run 9119 through the function,
            //811181 will come out, because 92 is 81 and 12 is 1.
            double square = 0;
            string answer="";
            if (n == 0) return 0;
            while (n > 0)
            {
                square = Math.Pow(n%10,2);
                n /= 10;
                answer = square.ToString()+answer;
            }
            return Convert.ToInt32(answer);
        }

        public static bool IsSquare(int n) //Perfect square or not?
        {
            if (n < 0)
            {
                return false;
            }
            double buf;
            buf = Math.Sqrt(n);
            if (((int)buf * (int)buf) == n)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
