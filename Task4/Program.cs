using System.Globalization;

namespace Task4
{
    //Task4
    internal class Program
    {
        static void Main(string[] args)
        {
            PopulationCalculator();
        }

        private static void PopulationCalculator()
        {
            var year = 2024;
            double growth = 1.014d;

            double populationValue = 6500000000;
            string worldPopulation = populationValue.ToString("#,#", CultureInfo.InvariantCulture);

            Console.WriteLine($"From the year {year}, the world population is {worldPopulation}.");
            Console.WriteLine($"Assuming the population grows by 1,4% every year,");

            while ( populationValue < 10000000000)
            {
                populationValue = populationValue * growth;
                year = year + 1;
            }


        }
    }
}
