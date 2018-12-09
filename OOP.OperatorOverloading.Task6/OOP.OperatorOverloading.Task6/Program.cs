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
            Point incrementOp = pointOne++;
            //++
            Point decrementOp = pointTwo--;
        }
    }
}
