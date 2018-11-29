using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateEventHandler
{
    class UserInputEventArgs
    {
        private readonly float _firstNumber;
        private readonly float _secondNumber;

        public UserInputEventArgs(float firstNumber, float secondNumber)
        {

            _firstNumber = firstNumber;
            _secondNumber = secondNumber;

        }
        public float FirstNumber => _firstNumber;

        public float SecondNumber => _secondNumber;
    }
}
