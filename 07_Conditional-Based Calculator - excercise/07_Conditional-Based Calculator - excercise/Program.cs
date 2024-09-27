/*
ADVANCED EXERCISE: Building a Conditional-Based Calculator

Create a simple C# calculator program that performs basic arithmetic operations (+, -, *, /) based on user input. The program should:

1 Prompt the user to enter two numbers.
2 Prompt the user to choose an arithmetic operation (Addition, Subtraction, Multiplication, Division).
3 Use conditional statements to perform the selected operation.
4 Print the result of the operation to the console.
5 Handle division by zero with a specific message.

*/

//1 Prompt the user to enter first number
Console.WriteLine("Welcome to the Conditional-Based Calculator!" + '\n' + "Please enter a (whole) number:");

string inputString1 = Console.ReadLine();
int num1 = 0;
bool isNumber1 = int.TryParse(inputString1, out num1);

// I can use the while loop here. If the inserted is not number, I can let the user repeat it until they enter an int.

while (isNumber1 == false)
{
    Console.WriteLine("Something went wrong. Are you sure you entered a whole number? Please, try again:");
    inputString1 = Console.ReadLine();
    isNumber1 = int.TryParse(inputString1, out num1);
}

//1 Prompt the user to enter second number
Console.WriteLine("Now enter second number:");

string inputString2 = Console.ReadLine();
int num2 = 0;
bool isNumber2 = int.TryParse(inputString2, out num2);

while (isNumber2 == false)
{
    Console.WriteLine("Something went wrong. Are you sure you entered a whole number? Please, try again:");
    inputString2 = Console.ReadLine();
    isNumber2 = int.TryParse(inputString2, out num2);
}

//2 Prompt the user to choose an arithmetic operation (Addition, Subtraction, Multiplication, Division).
Console.WriteLine("What do you want to calculate?" + '\n' + "1 - Addition" + '\n' + "2 - Subtraction" + '\n' + "3 - Multiplication" + '\n' + "4 - Division");

string inputString3 = Console.ReadLine();

// 3 Use conditional statements to perform the selected operation. + 4 Print the result of the operation to the console.

if (inputString3 == "1")
{
    int result = num1 + num2;
    Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + result);
}
else if (inputString3 == "2")
{
    int result = num1 - num2;
    Console.WriteLine("The substraction of " + num1 + " and " + num2 + " is " + result);
}
else if (inputString3 == "3")
{
    int result = num1 * num2;
    Console.WriteLine("The multiplication of " + num1 + " and " + num2 + " is " + result);
}
else if (inputString3 == "4")
{
    if (num2 == 0) //5 Handle division by zero with a specific message.
    {
        Console.WriteLine("You cannot divide by zero!");
    }
    else
    {
        int result = num1 / num2;
        Console.WriteLine("The division of " + num1 + " and " + num2 + " is " + result);
    }
}
else
{
    Console.WriteLine("That is unknown operation."); // this will be possible to rewrite better also with the use of while
}

Console.ReadKey();

