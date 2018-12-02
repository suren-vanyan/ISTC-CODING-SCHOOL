using System;
using System.Text;

namespace CalculateEventHandler
{
    internal delegate string MathematicalOperationsEventHandler(float x, float y);

    class Program
    { 
        public static UserInputEventArgs UserInput()
        {
          
            //Console.WriteLine("Please Input first number");
            //bool firstResult = int.TryParse(Console.ReadLine(), out int firstNumber);
            //firstNumber = firstResult ? firstNumber : int.MaxValue; 
           
            //Console.WriteLine("Please Input second number");
            //bool secondResult = int.TryParse(Console.ReadLine(), out int secondNumber);
            //secondNumber = secondResult ? secondNumber : int.MaxValue;

            Console.WriteLine("Please Input first number");
            string firstInput = Console.ReadLine();
            if (firstInput == string.Empty)
            {
                throw new ArgumentNullException();
            }
            int firstNumber = int.Parse(firstInput);

            Console.WriteLine("Please Input second number");
            string secondInput = Console.ReadLine();
            if (secondInput == null)
            {
                throw new ArgumentNullException();
            }

            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > int.MaxValue||firstNumber<int.MinValue || secondNumber < int.MinValue||secondNumber>int.MaxValue)
            {
                throw new OverflowException();              
            }

            UserInputEventArgs user = new UserInputEventArgs(firstNumber, secondNumber);
            return user;
        }
        static void Main(string[] args)
        {
            UserInputEventArgs user = null;

            //The program works as follows:
            // the user first enters the numbers
      
            try
            {
                user = UserInput();
            }
            catch (ArgumentNullException arg)
            {
                Console.WriteLine(arg.Message);
                Console.WriteLine(arg.Source);
                Console.WriteLine(arg.TargetSite);      
            }
            catch (FormatException fm)
            {
                Console.WriteLine(fm);
            }
            catch (OverflowException ov)
            {
                Console.WriteLine(ov);
            }   
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //we have a counting machine,it has a metod OnNewUserInput,
            //which as an argument gets an UserInputEventArgs object
            CountingMashine countingMashine = new CountingMashine();

            //We have a Calculate class,where there are Metods that perform mathematical calculations
            Console.WriteLine("Choose what operation dou you want to perfom");
            string operation = Console.ReadLine();

            //This variable will contain the result of operations
            StringBuilder resultofOperations = new StringBuilder();
            try
            {
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
            }
            catch (NullReferenceException n)
            {
                Console.WriteLine(n.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           

            Console.WriteLine(resultofOperations);
            //Thе  constructor оf this class Calculate  gets object of the class  CountingMashine
            //so we can subscribe to the event of the class Counting Mashine
            //Calculate calculate = new Calculate(countingMashine);


            
        }
    }
}

