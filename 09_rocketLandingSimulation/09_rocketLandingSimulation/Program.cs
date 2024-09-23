﻿/* Challenge: Rocket Landing Simulation

In this task, you'll create a fun and interactive console application in C# that simulates a rocket landing. Here are your objectives:

1. String Representation: Start with a string that represents the rocket. This string will include line breaks and slashes to create a simple rocket shape.

2. Console Display: Your goal is to display this rocket string in the console and make it appear as though the rocket is descending step by step.

3. Console Clear: Use the `Console.Clear()` method to clear the console at each step of the descent. This will make the movement of the rocket smooth and continuous.

4. Descent Mechanism: Implement a mechanism to add an empty line above the rocket for each iteration. This will simulate the rocket descending.

5. Final Message: Once the rocket has landed, display a message such as "The rocket has landed. Woohoo! Another successful landing!"

Remember, the key part of this challenge is to ensure the rocket descends smoothly, giving the appearance of a controlled landing. You might need to experiment with adding empty lines and clearing the console to achieve the desired effect.

Good luck, and have fun with your rocket landing simulation!
We will go over how WE build this in the next lecture!
See you there!

*/

string rocket = "        |\r\n       / \\\r\n      / _ \\\r\n     |.o '.|\r\n     |'._.'|\r\n     |     |\r\n   ,'|  |  |`.\r\n  /  |  |  |  \\\r\n  |,-'--|--'-.|";

Console.WriteLine(rocket);


for (int i = 10; i >= 0; i--)
{
    Console.Clear();
    Console.Write("Landing in " + i);
    Console.WriteLine('\n');
    Console.WriteLine(rocket);
    rocket = "\r\n" + rocket;
    Thread.Sleep(1000);
}

Console.WriteLine("The rocket has landed. Woohoo! Another successful landing!");
