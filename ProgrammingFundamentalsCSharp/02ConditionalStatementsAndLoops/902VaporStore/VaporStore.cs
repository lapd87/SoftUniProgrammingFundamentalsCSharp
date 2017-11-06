using System;

class VaporStore
{
    static void Main()
    {
        double balance = double.Parse(Console.ReadLine());

        double gamePrice = 0;
        double spent = 0;

        while (balance != 0)
        {
            string game = Console.ReadLine();

            if (game == "Game Time")
            {
                Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${balance:f2}");
                break;
            }

            switch (game)
            {
                case "OutFall 4":
                case "RoverWatch Origins Edition":
                    gamePrice = 39.99;
                    break;
                case "CS: OG":
                    gamePrice = 15.99;
                    break;
                case "Zplinter Zell":
                    gamePrice = 19.99;
                    break;
                case "Honored 2":
                    gamePrice = 59.99;
                    break;
                case "RoverWatch":
                    gamePrice = 29.99;
                    break;
                default:
                    Console.WriteLine("Not Found");
                    continue;
            }

            if (balance - gamePrice < 0)
            {
                Console.WriteLine("Too Expensive");
            }
            else if (balance - gamePrice == 0)
            {
                Console.WriteLine("Bought " + game);
                Console.WriteLine("Out of money!");
                break;
            }
            else
            {
                balance -= gamePrice;
                spent += gamePrice;
                Console.WriteLine("Bought " + game);
            }
        }
    }
}
