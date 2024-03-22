namespace Task6
{
    //Task6
    internal class Program
    {
        static void Main(string[] args)
        {
            GradeDefinitions();
        }

        private static void GradeDefinitions()
        {
            bool exitApplication;

            Console.WriteLine("Enter your grade, from A to F");
            Console.WriteLine("Enter 'G' to exit the application");

            do
            {
                Console.WriteLine();
                Console.WriteLine("Your grade:");
                exitApplication = false;
                string readResult = Console.ReadLine();

                if (readResult.IsNotNullOrEmpty())
                {
                    readResult = readResult.Trim().ToLower();

                    switch (readResult)
                    {
                        case "a":
                            Console.WriteLine("A: Excellent - Outstanding performance with only minor errors.");
                            break;
                        case "b":
                            Console.WriteLine("B: Very Good - Above the average standard but with some errors.");
                            break;
                        case "c":
                            Console.WriteLine("C: Good - Generally sound work with a number of notable errors.");
                            break;
                        case "d":
                            Console.WriteLine("D: Satisfactory - Faior but with significant shortcomings.");
                            break;
                        case "e":
                            Console.WriteLine("E: Sufficient - Performance meets the minimum criteria.");
                            break;
                        case "fx":
                            Console.WriteLine("Fx: Fail - Some more work required before the credit can be awarded.");
                            break;
                        case "f":
                            Console.WriteLine("F: Fail - Considerable further work is required.");
                            break;
                        case "g":
                            exitApplication = true;
                            break;
                        default:
                            Console.WriteLine("Error. Please enter a correct grade value.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error. Please enter a correct grade value.");
                }

            } while (exitApplication == false);

            if (exitApplication == true)
            {
                Console.WriteLine("Exiting application");
                Console.ReadLine();
            }

        }
    }
}
