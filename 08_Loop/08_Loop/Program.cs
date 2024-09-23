// How to get a random number:
Random random = new Random();
int randomNumber = random.Next(1, 11);

// Try.Parse
Console.WriteLine("Give me a number:");
string inputString = Console.ReadLine();

int num = 0;
bool isNumber = int.TryParse(inputString, out num);

if (isNumber)
{
    if (num == randomNumber)
    {
        Console.WriteLine("Congratulations! You guessed right!");
    }
    else
    {
        Console.WriteLine("Luck was not on your side. Try again!");
    }
}
else
{
    Console.WriteLine("Haha, you troll, you should have entered a number.");
}

Console.ReadKey();
