namespace Task2
{
    //Task 2
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadSphereRadius();
        }

        private static void ReadSphereRadius()
        {
            Console.WriteLine("--SPHERE READER--");
            Console.WriteLine("Input a whole number.");

            int radius = 0;
            bool validInput;

            do
            {
                string readResult = Console.ReadLine();

                if (int.TryParse(readResult, out _))
                {
                    validInput = true;
                    radius = Convert.ToInt32(readResult);
                }
                else
                {
                    Console.WriteLine("Error. Input a valid number.");
                    validInput = false;
                }
            } while (validInput == false);

            for (int i = 1; i <= radius; i++)
            {
                var volume = 4/3 * Math.PI * Math.Pow(i, 3.0);

                Console.WriteLine($"A sphere with radius {i} is {volume}");
            }

        }
    }
}
