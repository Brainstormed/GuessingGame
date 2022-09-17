namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string promptText = "Please enter a number from 1 to 10: ";

            Random random = new Random();
            string randInt = random.Next(1, 11).ToString();

            Console.ResetColor();

            Console.Write(promptText);
            string guess = Console.ReadLine();

            string[] acceptedInput = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};

            while (guess != randInt)
            {
                if (acceptedInput.Contains(guess))
                {
                    Console.WriteLine("Oops! you are wrong! Let's go again!!\n");
                    Console.Write(promptText);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nInvalid input!\n");
                    Main(args);
                    _ = Console.ReadLine();

                }
                guess = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nYou win!\n");

            Console.Write("Enter r/R to play again!! ");

            string replay = Console.ReadLine();

            if (replay == "r" || replay == "R")
            {
                Console.WriteLine();
                Main(args);
            }
        }
    }
}