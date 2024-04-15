using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCodeDiary
{
    /// <summary>
    ///  This class is use to try an error handling.
    ///  Also when using try catch is it best done when dealing external file, database and network.
    /// </summary>
    using System;
    public class ErrorHandlingDiary
    {
        public void PerformDivision()
        {
            bool continueRunning = true;
            while (continueRunning)
            {
                Console.WriteLine("Enter the numerator:");
                string inputNumerator = Console.ReadLine();

                Console.WriteLine("Enter the denominator:");
                string inputDenominator = Console.ReadLine();

                try
                {
                    int numerator = int.Parse(inputNumerator);
                    int denominator = int.Parse(inputDenominator);

                    int result = checked(numerator / denominator); // This might throw DivideByZeroException or OverflowException
                    Console.WriteLine($"Result: {result}");

                    continueRunning = false; // Exit loop after successful operation
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: Cannot divide by zero. Please try again.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter valid integers. Please try again.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: Numeric overflow. Please enter smaller numbers.");
                }
                catch (Exception ex) // Generic exception handler for any other unforeseen exceptions
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }
            }
        }
    }


}
