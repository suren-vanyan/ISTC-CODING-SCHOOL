using System;

namespace CalculateEventHandler
{
    internal delegate string MathematicalOperationsEventHandler(float x, float y);

    class Program
    {  
        public static void CountingMashine()
        {

        }

        static void Main(string[] args)
        {
                     
            while (Console.ReadKey().KeyChar=='a')
            {
                Console.WriteLine("Please Input first number");
                bool firstResult = int.TryParse(Console.ReadLine(), out int firstNumber);
                firstNumber = firstResult ? firstNumber : int.MaxValue;

                Console.WriteLine("Please Input second number");
                bool secondResult = int.TryParse(Console.ReadLine(), out int secondNumber);
                secondNumber = secondResult ? secondNumber : int.MaxValue;

                if (firstNumber == int.MaxValue || secondNumber == int.MaxValue)
                {
                    Console.WriteLine("Try Again");
                    return;
                }

                //The program works as follows:

               // the user first enters the numbers
                UserInputEventArgs user = new UserInputEventArgs(firstNumber,secondNumber);

                //we have a counting machine,it has a metod OnNewUserInput,
                //which as an argument gets an UserInputEventArgs object
                CountingMashine countingMashine = new CountingMashine();

                //We have a Calculate class,where there are Metods that perform mathematical calculations
                //Thе  constructor оf this class Calculate  gets object of the class  CountingMashine
                //so we can subscribe to the event of the class Counting Mashine
                Calculate calculate = new Calculate(countingMashine);
                countingMashine.OnNewUserInput(user);

                //մնումա տեսնեմ թե ինչեմ անում մեթոդների վերադարձրած արժեքների հետ
            }
        }
    }
}
