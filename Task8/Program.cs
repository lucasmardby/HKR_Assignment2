using Task6;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string readResult;
            bool validInput;

            int first = 0;
            int second = 0;

            Console.WriteLine("Enter your first integer:");
            do
            { 
                validInput = false;

                readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _))
                {
                    first = Convert.ToInt32(readResult);
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Error. Enter a valid integer.");
                }

            } while (validInput == false);

            Console.WriteLine("Enter your second integer:");
            do
            {
                validInput = false;

                readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _))
                {
                    second = Convert.ToInt32(readResult);
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Error. Enter a valid integer.");
                }

            } while (validInput == false);

            Console.WriteLine($"The sum of the two integers is {OverloadedMethod(first, second)}");
            Console.WriteLine();

            double floatOne = 0d;
            double floatTwo = 0d;

            Console.WriteLine("Enter your first float number:");
            do
            {
                validInput = false;

                readResult = Console.ReadLine();
                if (double.TryParse(readResult, out _))
                {
                    floatOne = Convert.ToDouble(readResult);
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Error. Enter a valid float number.");
                }

            } while (validInput == false);

            Console.WriteLine("Enter your second float number:");
            do
            {
                validInput = false;

                readResult = Console.ReadLine();
                if (double.TryParse(readResult, out _))
                {
                    floatTwo = Convert.ToDouble(readResult);
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Error. Enter a valid float number.");
                }

            } while (validInput == false);

            Console.WriteLine($"The sum of the two float numbers is {OverloadedMethod(floatOne, floatTwo)}");
            Console.WriteLine();

            string firstName = "";
            string lastName = "";

            Console.WriteLine("Enter a first name:");
            do
            {
                validInput = false;

                readResult = Console.ReadLine();
                if (readResult.Trim().IsNotNullOrEmpty())
                {
                    firstName = readResult;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Error. Enter a valid name.");
                }

            } while (validInput == false);

            Console.WriteLine("Enter a last name:");
            do
            {
                validInput = false;

                readResult = Console.ReadLine();
                if (readResult.Trim().IsNotNullOrEmpty())
                {
                    lastName = readResult;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Error. Enter a valid name.");
                }

            } while (validInput == false);

            Console.WriteLine($"Your name is {OverloadedMethod(firstName, lastName)}");
            Console.WriteLine();

            int complexOne = 0;
            int complexTwo = 0;
            int imaginaryOne = 0;
            int imaginaryTwo = 0;

            Console.WriteLine("Enter the real part of the first complex number:");
            do
            {
                validInput = false;

                readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _))
                {
                    complexOne = Convert.ToInt32(readResult);
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Error. Enter a valid integer.");
                }

            } while (validInput == false);

            Console.WriteLine("Enter the imaginary part of the first complex number:");
            do
            {
                validInput = false;

                readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _))
                {
                    imaginaryOne = Convert.ToInt32(readResult);
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Error. Enter a valid integer.");
                }

            } while (validInput == false);
            Console.WriteLine("Enter the real part of the second complex number:");
            do
            {
                validInput = false;

                readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _))
                {
                    complexTwo = Convert.ToInt32(readResult);
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Error. Enter a valid integer.");
                }

            } while (validInput == false);

            Console.WriteLine("Enter the imaginary part of the second complex number:");
            do
            {
                validInput = false;

                readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _))
                {
                    imaginaryTwo = Convert.ToInt32(readResult);
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Error. Enter a valid integer.");
                }

            } while (validInput == false);

            Console.WriteLine($"The sum of the two complex numbers is {OverloadedMethod(complexOne, complexTwo, imaginaryOne, imaginaryTwo)}");
            Console.WriteLine();
        }

        private static int OverloadedMethod(int x, int y)
        { 
            return x + y;
        }
        private static double OverloadedMethod(double x, double y)
        {
            return x + y;
        }
        private static string OverloadedMethod(string firstName, string lastName)
        {
            string fullName = $"{firstName} {lastName}";

            return fullName;
        }
        private static string OverloadedMethod(int complexOne, int complexTwo, int imaginaryOne, int imaginaryTwo)
        {
            string complexNumbers = $"{complexOne + complexTwo}+ i{imaginaryOne + imaginaryTwo}";
            return complexNumbers;
        }

    }
}
