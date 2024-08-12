using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode
{
    /*****************************************************************************
    * 
    * YOU MAY REFACTOR THE PARAMETER NAMES BUT DO NOT CHANGE THE METHOD SIGNATURES
    * 
    * ***************************************************************************/
    public static class SimpleMath
    {
        /// <summary>
        /// This method takes two doubles as parameters and returns the sum
        /// of both
        /// </summary>
        /// <param name="a"> The first double to be added </param>
        /// <param name="b"> The second double to be added </param>
        /// <returns> The sum of both parameters </returns>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// This method takes two doubles as parameters and returns the 
        /// difference of both. (Does not utilize absolute value)
        /// </summary>
        /// <param name="a"> The double to be subtracted from </param>
        /// <param name="b"> The amount to be subtracted </param>
        /// <returns> The difference of both parameters </returns>
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// This method takes two doubles as parameters and returns the 
        /// quotient of both
        /// </summary>
        /// <param name="a"> The first factor </param>
        /// <param name="b"> The second factor </param>
        /// <returns> The quotient of both parameters </returns>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// This method takes two doubles as parameters and returns the 
        /// remainder of both
        /// </summary>
        /// <param name="a"> The first dividend </param>
        /// <param name="b"> The second dividend </param>
        /// <returns> The remainder of both parameters </returns>
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Cannot divide by 0");
            }
            return a / b;
        }
    }
}
