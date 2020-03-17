using System;
using System.Collections.Generic;
using System.Text;

namespace TDDelegue
{
    class CalculAlgos
    {
        public static int Additionner(int[] data)
        {
            int result = 0;
            foreach (int number in data)
            {
                result += number;
            }
            return result;
        }

        public static int Multiplier(int[] data)
        {
            return (data[0] * data[1]);
        }

    }
}
