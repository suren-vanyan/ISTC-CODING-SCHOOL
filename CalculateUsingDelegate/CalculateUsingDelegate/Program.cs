using System;

namespace CalculateUsingDelegate
{
    internal delegate double CalculateHandler(double x, double y);
    class Program
    {
        public static double Add(double x, double y)
        {
            Console.WriteLine("add the numbers");
            return x + y;
        }

        public static double Subtract(double x, double y)
        {
            Console.WriteLine("Subtract the numbers");
            return x - y;
        }

        public static double Divide(double x, double y)
        {
            Console.WriteLine("Divide the numbers");
            return x / y;
        }

        public static double Multiplicate(double x, double y)
        {
            Console.WriteLine("Multiplicate the numbers");
            return x * y;
        }

        public static double Module(double x, double y)
        {
            Console.WriteLine("Calculate Module");
            return x % y;
        }

        static void Main(string[] args)
        {
            CalculateHandler calculate = null;
            CalculateHandler _add = new CalculateHandler(Add);
            CalculateHandler _sub = Subtract;
            CalculateHandler _mul = Multiplicate;
            CalculateHandler _div = Divide;
            CalculateHandler _mod = Module;

            
            Console.WriteLine(_add.Invoke(50, 10.2)+"\n");
            Console.WriteLine(_mul.Invoke(80, 5)+"\n");
           //and so on

            calculate = _add; //(CalculateHandler)Delegate.Combine(_add);
            calculate += _sub;//when i use + = the following happens,called Delegate.Combine like next

            calculate = (CalculateHandler)Delegate.Combine(calculate, _mul,_div,_mod);//use params
            calculate.Invoke(15, 7);

          
            double result = calculate(10.5, 6.3); // the return value is returned from the last method, all the other values is dropped
            Console.WriteLine(result+"\n");

            //Alternatie versions Anonymous Metods and lambda expressions
            CalculateHandler add = null;
            CalculateHandler sub = null;
            CalculateHandler div = null;
            CalculateHandler mul = null;
            CalculateHandler mod = null;

            add = new CalculateHandler(delegate (double x, double y) { return x + y; });
            sub = delegate (double x, double y) { return x - y; }; //Anonymous Metods C#2.0
            div = (double x, double y) => { return x / y; };
            mul = (x, y) => x * y; //lambda expressions C# 3.0
            mod = (double x, double y) => { return x % y; };

           
            Console.WriteLine(add.Invoke(10, 3));
            Console.WriteLine(sub.Invoke(50, 12.3));
            Console.WriteLine(div(30.15, 5));
            //and so on

            CalculateHandler handler = null;
            handler = (CalculateHandler)Delegate.Combine(add, sub, div, mul, mod);//handler=add+sub+div+mul+mod
             // handler += add + sub + div + mul + mod;//10 Metod

            //to keep all the values that the methods returned
            Delegate[] arrayHnadler = handler.GetInvocationList();

            double[] KepReturnValues = new double[arrayHnadler.Length];

            for (int i = 0; i < KepReturnValues.Length; i++)
            {
                foreach (CalculateHandler item in arrayHnadler)
                {
                    KepReturnValues[i] = item.Invoke(30, 15);
                }
            }
            
                     
        }      
    }
}
