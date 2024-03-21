namespace HKR_Assignment2
{
    //Task 1
    internal class Program
    {
        static void Main(string[] args)
        {
            SquareCubeLoop();
        }

        private static void SquareCubeLoop()
        {
            Console.WriteLine("Number\tSquare\tCube");

            for (var i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}\t{Math.Pow(i, 2.0)}\t{Math.Pow(i, 3.0)}");
            }
        }
    }
}
