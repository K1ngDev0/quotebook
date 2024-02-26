namespace quotebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kies van welke persoon quotes je wil");
            Console.WriteLine("1. Dave");
            Console.WriteLine("2. Gert");
            Console.WriteLine("3. Quinten");
            Console.WriteLine("4. Lars");
            Console.WriteLine("5. Nick");
            Console.WriteLine("6. Colin");
            Console.WriteLine("7. Joan");
            Console.WriteLine("8. Krist");
            Console.WriteLine("9. Alle quotes");
            Console.WriteLine("X. Exit");
            
            string userInput = Console.ReadLine();

            Dictionary<string, string> daveQuotes = new Dictionary<string, string>
                    {
                        {"bol.cum", "24/10/2023"},
                        {"2", "Ik ben een developer"},
                        {"3", "Ik ben een gamer"},
                        {"4", "Ik ben een student"}
                    };



            switch (userInput)
            {
                case "1":
                    
                    break;
                case "2":
                    Console.WriteLine("Gert");
                    break;
                case "3":
                    Console.WriteLine("Quinten");
                    break;
                case "4":
                    Console.WriteLine("Lars");
                    break;
                case "5":
                    Console.WriteLine("Nick");
                    break;
                case "6":
                    Console.WriteLine("Colin");
                    break;
                case "7":
                    Console.WriteLine("Joan");
                    break;
                case "8":
                    Console.WriteLine("Alle quotes");
                    break;
                case "X":
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Geen geldige input");
                    break;
            }


















        }
    }
}
