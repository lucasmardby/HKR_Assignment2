using System.Transactions;

namespace Task7
{
    //Task7
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateSmallestNumber();
        }

        private static void CalculateSmallestNumber()
        {
            List<int> numbers = new List<int>();
            string readResult;
            bool stopApplication;

            Console.WriteLine("Enter any number of whole numbers.");
            Console.WriteLine("If you enter 0, your smallest number will be displayed.");
            Console.WriteLine();

            Console.Write("Write a number:");

            do
            {
                stopApplication = false;
                readResult = Console.ReadLine();

                if (int.TryParse(readResult, out _))
                {
                    if (readResult.Trim() == "0")
                    {
                        stopApplication = true;
                    }
                    else
                    {
                        numbers.Add(int.Parse(readResult));
                        numbers.Sort();

                        Console.Write("Write another number:");
                    }
                }
                else
                {
                    Console.WriteLine("Error. Enter a valid number.");
                }

            } while (stopApplication == false);

            bool listIsEmpty = !numbers.Any();
            if (!listIsEmpty)
            {
                var smallestNumber = numbers.First();
                Console.WriteLine($"The smallest number you've written is {smallestNumber}");
            }

        }
    }
}
