/* Assignment 2 for PROG2070
 * A console Application for creating Triangles of various shapes
 * Revision History
 * Created by Anas Mohamed on 2019-02-10
 * Modified on 2019-02-11
 * Modified on 2019-02-12
 * Modified on 2019-02-13
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assign2
{
    class Program
    {
        /// <summary>
        /// Main method that executes on Load
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            string input;

            do
            {
                Console.WriteLine("\n1. Enter Triangle Dimensions: " + "\n" + "2. Exit" + "\n");
                input = Console.ReadLine();

                try
                {

                    if (input == "1")
                    {
                        Console.WriteLine("Enter 3 Numbers" + "\n");

                        Console.WriteLine("Enter First Number: ");
                        a = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Second Number ");
                        b = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Third Number ");
                        c = int.Parse(Console.ReadLine());


                        string answer = TriangleSolver.Analyze(a, b, c);
                        Console.WriteLine(answer);

                    }
                    if (input == "2")
                    {
                        break;
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("The values entered are not valid");
                }

            } while (true);

        }
    }
}
