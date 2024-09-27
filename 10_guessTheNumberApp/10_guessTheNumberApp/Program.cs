// Guess the number Application

Random random = new Random();

int secretNumber = random.Next(1, 101);
int userGuess = 0;
int counter = 0;

Console.WriteLine("Write a number I am thinking of between 1 and 100");

while (userGuess != secretNumber)
{
    counter++;
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
        Console.WriteLine("Congratulations! You guessed the number correctly! It took you " + counter + " tries.");
    }
}

Console.ReadLine();


