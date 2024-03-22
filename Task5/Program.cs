namespace Task5
{
    //Task5s
    internal class Program
    {
        static void Main(string[] args)
        {
            CelsiusToFahrenheit();
        }

        private static void CelsiusToFahrenheit()
        {
            double celsius = -30d;

            Console.WriteLine("Celsius\t\tFahrenheit");
            do 
            {
                double fahrenheit = ( 9d / 5d ) * celsius + 32d;

                string celPad;
                string fahPad;

                switch (celsius.ToString().Length)
                { 
                    case < 2:
                        celPad = "    ";
                        break;
                    case < 3:
                        celPad = "   ";
                        break;
                    case >= 3:
                        celPad = "  ";
                        break;
                }
                switch (fahrenheit.ToString().Length)
                {
                    case < 2:
                        fahPad = "    ";
                        break;
                    case < 3:
                        fahPad = "   ";
                        break;
                    case >= 3:
                        fahPad = "  ";
                        break;
                }

                Console.WriteLine($"{celPad}{celsius}\t\t{fahPad}{fahrenheit}");

                celsius += 5;

            } while ( celsius <= 50 );

        }
    }
}
