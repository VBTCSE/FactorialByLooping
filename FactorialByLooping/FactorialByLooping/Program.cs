using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialByLooping
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculates the value of m! (m-factorial)
            // Which is equal to 1 * 2 * 3 * ... * m, if m > 0
            // and is equal to 1, if m = 0.

            int factorial = 1;  // Initialize the result value.
            


            // Get input from the user.
            int m = ConsoleIO.getNumber();



            if (m < 0)
            {
                ConsoleIO.showError();

                ConsoleIO.waitForKeypress();
            }
            else if (m == 0)
            {
                ConsoleIO.showResult(m, factorial);

                ConsoleIO.waitForKeypress();
            }
            else
            {
                // Add code here to loop over integers to calculate
                // factorial = 1 * 2 * 3 * ... * m, where you know that m > 0.
                // Reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for
                // and https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/multiplication-operator

                //vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
                // Add your code here.
                //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^


                ConsoleIO.showResult(m, factorial);

                ConsoleIO.waitForKeypress();
            }

        }
    }
}
