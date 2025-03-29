namespace Prac_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TotalCoffee = 0;

            Start:
            Console.WriteLine("Please buy a coffee: ");
            Console.WriteLine("Select size: 1.Tall 2.Grande 3.Tallest");
            int UserNum = int.Parse(Console.ReadLine());

            switch (UserNum)
            {
                case 1:
                    TotalCoffee += 1;
                    break;
                case 2:
                    TotalCoffee += 2;
                    break;
                case 3:
                    TotalCoffee += 3;
                    break;
                default:
                    Console.WriteLine("Invalid input, please enter correct coffee size: ");
                    goto Start;
            }


           Decision:
            Console.WriteLine("Do you want to continue buying coffee(Yes/No)?");
            string decision = Console.ReadLine().ToLower();
            switch (decision)
            {
                case "yes":
                    goto Start;
                case "no":
                    Console.WriteLine("Thank you for buying Coffee");
                    Console.WriteLine($"Billing Amount: {TotalCoffee}");
                    break;
                default:
                    Console.WriteLine("Invalid Choice.");
                    goto Decision;
            }
        }
    }
}
