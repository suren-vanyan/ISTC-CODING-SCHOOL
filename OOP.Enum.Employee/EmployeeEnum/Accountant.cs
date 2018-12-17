using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeEnum
{
    class Accountant
    {
        public bool AskForBonus(WorkPositions worker,int hour)
        {

            if (hour < (int)worker)
            {
                return false;
            }
            else
                return true;
        }
    }
}
