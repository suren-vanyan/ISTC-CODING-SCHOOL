using System;
using System.Text;

namespace CalculateEventHandler
{
    internal delegate string MathematicalOperationsEventHandler(float x, float y);

    class Program
    {
        public static UserInputEventArgs UserInput()
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
                UserInput();
            }

            UserInputEventArgs user = new UserInputEventArgs(firstNumber, secondNumber);
            return user;
        }
        static void Main(string[] args)
        {
            UserInputEventArgs user = null;

            //The program works as follows:
            // the user first enters the numbers
            user = UserInput();


            //we have a counting machine,it has a metod OnNewUserInput,
            //which as an argument gets an UserInputEventArgs object
            CountingMashine countingMashine = new CountingMashine();

            //We have a Calculate class,where there are Metods that perform mathematical calculations
            Console.WriteLine("Choose what operation dou you want to perfom");
            string operation = Console.ReadLine();

            //This variable will contain the result of operations
            StringBuilder resultofOperations = new StringBuilder();

            switch (operation)
            {
                case "+":
                    countingMashine.NewUserInput += Calculate.Add;
                    resultofOperations.AppendFormat(countingMashine.OnNewUserInput(user));
                    break;
                case "-":
                    countingMashine.NewUserInput += Calculate.Subtract;
                    resultofOperations.AppendFormat(countingMashine.OnNewUserInput(user));
                    break;
                case "*":
                    countingMashine.NewUserInput += Calculate.Multiplicate;
                    resultofOperations.AppendFormat(countingMashine.OnNewUserInput(user));
                    break;
                case "/":
                    countingMashine.NewUserInput += Calculate.Divide;
                    resultofOperations.AppendFormat(countingMashine.OnNewUserInput(user));
                    break;
                default:
                    countingMashine.NewUserInput += Calculate.Add;                 
                    countingMashine.NewUserInput += Calculate.Subtract;                  
                    countingMashine.NewUserInput += Calculate.Multiplicate;               
                    countingMashine.NewUserInput += Calculate.Divide;
                    resultofOperations.AppendFormat(countingMashine.OnNewUserInput(user));
                    //only contains return value of last Metod,its a very bad
                    break;
            }

            Console.WriteLine(resultofOperations);
            //Thе  constructor оf this class Calculate  gets object of the class  CountingMashine
            //so we can subscribe to the event of the class Counting Mashine
            //Calculate calculate = new Calculate(countingMashine);


            
        }
    }
}

