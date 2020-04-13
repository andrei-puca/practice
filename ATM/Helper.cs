using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class Validation
    {
        public bool pinAttempts(int countWrongPin)
        {
            if (countWrongPin == 3)
            {
                Console.WriteLine("You are banned from this ATM, muhahahahahaah ");
                return true;
            }
            return false;
        }
    }
}
