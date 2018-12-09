using System;

namespace OOP.OperatorOverloading.Task6
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Point pointOne = new Point(new Random().Next(1,20),new Random().Next(1,30));
            Point pointTwo = new Point(new Random().Next(1, 40), new Random().Next(1, 50));
           // Print(pointOne, pointTwo);

           //+
            Point additionPoints = pointOne + pointTwo;
            additionPoints = additionPoints + 2;

            var point = new Point
            {
                XCoord = pointOne.XCoord + pointTwo.XCoord,
                YCoord = pointOne.YCoord + pointTwo.YCoord

            };

            //-
            Point subtractPoints = pointOne - pointTwo;
            subtractPoints = subtractPoints - 2;


            // In terms of C#, the shorthand assignment operators are automatically simulated if a type overloads the related binary operator.
            //+=
            Point ShortAssOpOne = pointOne += pointTwo;
            //-=
            Point ShortAssOptwo = pointOne += pointTwo;



            //Unary Operators  --
            Point PostfixIncrement = pointOne++;
            Point PrefixIncrement = ++pointOne;
            //++
            Point postfixDecrement = pointTwo--;
            Point prefixDecrement = --pointTwo;


            //==
            bool result = pointOne == pointTwo;
            Console.WriteLine(result);
            //!=
            bool result2 = pointOne != pointTwo;
            Console.WriteLine(result2);

            //>,<,>=,<=
            result = pointOne > pointTwo;
            result = pointOne <= pointTwo;

            //  Custom Type Conversions explicit and implicit keywords
            Rectangle rectangle = new Rectangle(10, 4);
            Console.WriteLine(rectangle);
            rectangle.Draw();

            Square square = (Square)rectangle;
        }
    }
}
