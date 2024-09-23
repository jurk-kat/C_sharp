// Try.Parse
Console.WriteLine("Give me a number:");
string inputString = Console.ReadLine();

int num = 0;
bool isNumber = int.TryParse(inputString, out num);

if (isNumber)
{
    Console.WriteLine("Yay! You have entered a number!");
}
else
{
    Console.WriteLine("Haha, you troll, you should have entered a number.");
}

// Optional: Uncomment if needed for testing
// num++;
// Console.WriteLine($"User entered number +1 {num}");

Console.ReadKey();





