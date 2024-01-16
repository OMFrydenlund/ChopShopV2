namespace ChopShopV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            CarInspectionPrompt();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the shop!");
            Console.ReadKey();
        }

        private static void CarInspectionPrompt()
        {
            Console.Clear();
            Console.WriteLine("Would you like your car looked at?");
            Console.WriteLine("Press Y or N: ");
            GetInspectionResponse();
        }

        private static void GetInspectionResponse()
        {
            var userInput = Console.ReadLine();
            if (userInput == null || userInput.ToUpper() != "Y" && userInput.ToUpper() != "N")
            {
                Console.WriteLine("\nThat isn't a valid option, press any button to continue...");
                Console.ReadKey();
                CarInspectionPrompt();
            }
            else if (userInput.ToUpper() == "Y")
            {
                Console.WriteLine("\nAlright let's take a look at your car.");
                //add actions for health check and repairs
            }
            else if (userInput.ToUpper() == "N")
            {
                Console.WriteLine("\nAaaaalright then. Thanks for stopping by! >:)");
            }
        }
    }
}
