// Guess the number Application

int secretNumber = 42;
int userGuess = 0;

Console.WriteLine("Write a number I am thinking of between 1 and 100");

while (userGuess != secretNumber)
{
    Console.WriteLine("Enter your guess");
    userGuess = int.Parse(Console.ReadLine());

    if (userGuess < secretNumber)
    {
        Console.WriteLine("Too low! Try again!");
    }
    else if (userGuess > secretNumber)
    {
        Console.WriteLine("Too high! Try again!");
    }
    else
    {
        Console.WriteLine("Congratulations! You guessed the number correctly!");
    }
}

Console.ReadLine();


