using System;
using System.Numerics;

namespace ComplexNumber
{
    class HelperClass
    {
        public Complex ComplexSubtraction(Complex x,Complex y)
        {
            return new Complex(x.RealNumber - y.RealNumber, y.RealNumber - y.ImaginaryUnit);
        }

        public Complex ComplexAddition(Complex x, Complex y)
        {
            return new Complex(x.RealNumber + y.RealNumber, y.RealNumber + y.ImaginaryUnit);
        }

        public Complex ComplexMultiplication(Complex x, Complex y)
        {
            return new Complex(x.RealNumber * y.RealNumber - x.ImaginaryUnit * y.ImaginaryUnit,
                x.RealNumber * y.ImaginaryUnit + y.RealNumber * x.ImaginaryUnit);
           
        }

        public Complex ComplexDivision(Complex x, Complex y)
        {
            //  a + bi       a·c+b·d          bc-ad
            //  ------   =  ---------    +  ---------*i
            //  c+di        c′2 + d′2       c′2 + d′2 

            double divReal = (x.RealNumber * y.RealNumber + x.ImaginaryUnit * y.ImaginaryUnit) /  //a·c+b·d  
                (y.RealNumber * y.RealNumber + y.ImaginaryUnit * y.ImaginaryUnit);// c′2 + d′2
            double divImaginary = (  x.ImaginaryUnit* y.RealNumber - x.RealNumber * y.ImaginaryUnit) / //bc-ad
                (y.RealNumber * y.RealNumber + y.ImaginaryUnit * y.ImaginaryUnit);
            return new Complex(divReal, divImaginary);
        }
    }

    struct Complex
    {
        private readonly double _realNumber;
        private readonly double _imaginaryUnit;
        public Complex(double realNumber,double imaginaryUnit)
        {
            _realNumber = realNumber;
            _imaginaryUnit = imaginaryUnit;
        }
      
        public double ImaginaryUnit { get { return _imaginaryUnit; }  }

        public double RealNumber { get { return _realNumber; }  }

        public override string ToString()
        {
            return $"{_realNumber} {_imaginaryUnit}i";
        }
    }
    class Program
    {        
        static void Main(string[] args)
        {
            HelperClass helper = new HelperClass();

            Complex one = new Complex(1, 2);
            Console.WriteLine(one);
            Complex two = new Complex(3, -5);
            Console.WriteLine(two);

            Complex complex = helper.ComplexAddition(one, two);
            Console.WriteLine(complex);
   
        }
    }
}


