// break
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 3)
    {
        Console.WriteLine("I have had enough");
        break; // gets out of this loop. Useful if we need for example a user input and it will decide depending on that
    }

}

// continue
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 3)
    {
        continue; // does not stop the loop, but the rest of the code in the for loop will not be executed
    }
    Console.WriteLine("Only if not continued");

}