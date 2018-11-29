using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateEventHandler
{
    class CountingMashine
    {
        public event MathematicalOperationsEventHandler NewUserInput;

        public string OnNewUserInput(UserInputEventArgs e)
        {
           
            string temp = string.Empty;
            if (NewUserInput != null)
             temp+= NewUserInput.Invoke(e.FirstNumber, e.SecondNumber)+Environment.NewLine;
            return temp;
        }
    }
}
