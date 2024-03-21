namespace Task3
{
    //Task 3
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadSquare();
        }

        private static void ReadSquare()
        {
            Console.WriteLine("Input a number between 2 and 9 to draw a square of that size.");

            int numberValue = 0;
            bool validInput;

            do
            {
                validInput = false;
                string readResult = Console.ReadLine();

                if (int.TryParse(readResult, out _))
                {
                    numberValue = Convert.ToInt32(readResult);

                    if (numberValue >= 2 && numberValue <= 9)
                    { 
                        validInput = true;
                    }
                }
                else
                {
                    Console.WriteLine("Error. Input a valid number.");
                    validInput = false;
                }
            } while (validInput == false);

            Console.Clear();
            Console.WriteLine();

            for (int i = 0; i < numberValue; i++)
            {
                for (int j = 0; j < numberValue; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
