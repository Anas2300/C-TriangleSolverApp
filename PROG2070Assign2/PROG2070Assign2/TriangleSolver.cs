using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assign2
{
    public static class TriangleSolver
    {
        /// <summary>
        /// Analyze method that takes input from the user and forms a Triangle if applicable
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static string Analyze(int a, int b, int c)
        {
            try
            {

                string answer = null;

                if (a == b && b == c)
                {
                    answer = "Your Triangle is Equilateral";
                }
                if (a != b & b != c)
                {
                    answer = "Your Triangle is Scalene";
                }
                if (a == b & b != c || b == c & c != a || a == c & c != b)
                {
                    answer = "Your Triangle is Isoceles";
                }
                if (a == 0 || b == 0 || c == 0)
                {
                    answer = "This does not form a triangle";
                }
                if (a < 0 || b < 0 || c < 0)
                {
                    answer = "Negative values cannot be computed";
                }
                if (a > 1000 || b > 1000 || c > 1000)
                {
                    answer = "Values cannot exceed 1000";
                }

                return answer;
            }
            catch (Exception)
            {
                return "The Values Entered Do Not Form a Valid Triangle";
            }
          
        }
        
    }
}

