namespace DiceRollGame;

internal class Dice
{
    private int _randomNumber;
    private int _userChoice;
    public static int Counter;

    public void Roll()
    {
        _randomNumber = (new Random()).Next(1, 7);
    }

    public void startGame()
    {
        bool shallExit = false;

        do
        {
            Console.Write("Guess an integer number between 1 and 6 : ");

            string userInput = Console.ReadLine()!;

            bool parseInput = int.TryParse(userInput, out int guessedNumber);

            if (parseInput && isValid(guessedNumber))
            {
                _userChoice = guessedNumber;
                Counter++;
                if (hasWon())
                {
                    Console.WriteLine("You won!");
                    shallExit = true;
                }
                else if (Counter == 3)
                {
                    Console.WriteLine("You lose :( !");
                    shallExit = true;
                }
                else
                {
                    Console.WriteLine($"You have {LeftTries()}, please try again ... ");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        } while (!shallExit && Counter < 3);


    }




    private bool isValid(int number)
    {
        return number >= 1 && number <= 6;
    }


    private bool hasWon()
    {
        return _userChoice == _randomNumber;
    }

    private string LeftTries()
    {
        int leftGames = 3 - Counter;
        return leftGames > 1 ? $"{leftGames} games" : "one game";
    }
}
