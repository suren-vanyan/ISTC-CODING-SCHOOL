using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateEventHandler
{
    class CountingMashine
    {
        public event MathematicalOperationsEventHandler NewUserInput;

        public void OnNewUserInput(UserInputEventArgs e)
        {
            if (NewUserInput != null)
                NewUserInput.Invoke(e.FirstNumber, e.SecondNumber);
        }
    }
}
