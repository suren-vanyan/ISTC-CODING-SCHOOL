﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateEventHandler
{
    class Calculate
    {
        //public Calculate(CountingMashine e)
        //{
        //    e.NewUserInput += Add;
        //    e.NewUserInput += Subtract;
        //    e.NewUserInput += Divide;
        //    e.NewUserInput += Multiplicate;
        //}

        public static string Add(float x, float y)
        {
            Console.WriteLine("add the numbers");

            return (x + y).ToString();
        }

        public static string Subtract(float x, float y)
        {
            Console.WriteLine("Subtract the numbers");
            return (x - y).ToString();
        }

        public static string Divide(float x, float y)
        {
            Console.WriteLine("Divide the numbers");
            double temp = 0;
            try
            {
                temp = x / y;
                return temp.ToString();
            }
            catch (DivideByZeroException e)
            {
                return e.Message.ToString();
            }

        }

        public static string Multiplicate(float x, float y)
        {
            Console.WriteLine("Multiplicate the numbers");
            return (x * y).ToString() ;
        }
    }
}
