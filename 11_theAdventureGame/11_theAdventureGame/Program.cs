// The adventure game

Console.WriteLine("Welcome to the Adventure game!");
Console.WriteLine("Enter your character's name:");

string characterName = Console.ReadLine();

Console.WriteLine("\r\nChoose your character type:\r\nWarrior\r\nWizard\r\nArcher");
string characterType = Console.ReadLine();

Console.WriteLine($"\r\nYou, {characterName} the {characterType} find yourself at the edge of a forest. What do you want to do?\r\nEnter the forest - write Enter\r\nCamp outside - write Camp");

string choice1 = Console.ReadLine();

if (choice1.ToLower() == "enter")
{
    Console.WriteLine("you bravely enter the forest");
}
else
{
    Console.WriteLine("you camp outside");
}

bool gameContinues = true;

while (gameContinues)
{
    Console.WriteLine("you come to a crossroad. Where will you go?");
    string direction = Console.ReadLine();
    if (direction.ToLower() == "right")
    {
        Console.WriteLine("you found a treasure. Congratulations!");
        gameContinues = false;
    }
    else
    {
        Console.WriteLine("You encountered a bandit. will you run or fight?");
        string decision = Console.ReadLine();
        if (decision.ToLower() == "fight")
        {
            Random random = new Random();
            int luck = random.Next(1, 10);
            if (luck > 5)
            {
                Console.WriteLine("you won the fight and killed the bandid. He dropped a trasure.");
            }
            else
            {
                Console.WriteLine("The bandit was stronger and killed you.");
                gameContinues = false;
            }
        }
        else
        {
            Console.WriteLine("The bandid shot you to the back. You died.");
            gameContinues = false;
        }
    }
}

Console.WriteLine("Game over!");
Console.WriteLine("Thank you for playing!");

Console.ReadKey();