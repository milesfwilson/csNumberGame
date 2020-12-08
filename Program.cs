using System;

namespace numberGame
{
  class Program
  {
    static void Main(string[] args)
    {
      Random randomizer = new Random();

      bool running = true;
      int randomNumber = randomizer.Next(1, 101);
      while (running)
      {
        System.Console.WriteLine("Guess a number between 1 and 100");
        string userInputStr = Console.ReadLine();
        bool guess = int.TryParse(userInputStr, out int userInput);
        if (!guess)
        {
          System.Console.Clear();
          System.Console.WriteLine("Please enter a number");
        }
        if (userInput > randomNumber && (userInput < 101 && userInput > 0))
        {
          System.Console.Clear();
          System.Console.WriteLine("Guess again, lower");
        }
        else if (userInput < randomNumber && (userInput < 101 && userInput > 0))
        {
          System.Console.Clear();

          System.Console.WriteLine("Guess again, higher");
        }
        else if (userInput > 100 || userInput < 0)
        {
          System.Console.Clear();

          System.Console.WriteLine("Between 1 and 100, please");
        }
        else if (userInput == randomNumber)
        {
          System.Console.Clear();

          System.Console.WriteLine($@"
        You are correct!
        The number was {randomNumber}!
        Do you want to play again Y/N");
          string again = Console.ReadLine();
          switch (again)
          {
            case "Y":
              randomNumber = randomizer.Next(1, 101);

              System.Console.WriteLine("Guess a number between 1 and 100");
              userInput = int.Parse(Console.ReadLine());
              break;
            case "N":
              System.Console.WriteLine("Thank you for playing");
              running = false;
              break;
          }
        }
      }
    }
  }
}
