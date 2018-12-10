using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyExtensionMethods
{
    static class MyExtensions
    {
        
        //the first parameter of an extension method represents the type being extended.
        public static int ReverseNumber(this int i)
        {
            char[] digits = i.ToString().ToCharArray();
            Array.Reverse(digits);

            string newDigits = new string(digits);
            int result = Convert.ToInt32(newDigits);
            return result;
        }

        public static int ConvertToInt(this string str)
        {
            bool result = int.TryParse(str, out int x);
            x = result ? x : int.MaxValue;
            return x;
        }
        public static void Print(this IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
              
            }
        }


    }
}
