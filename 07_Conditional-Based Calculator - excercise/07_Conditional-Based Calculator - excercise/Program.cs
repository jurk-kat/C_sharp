/*
ADVANCED EXERCISE: Building a Conditional-Based Calculator

Create a simple C# calculator program that performs basic arithmetic operations (+, -, *, /) based on user input. The program should:

1 Prompt the user to enter two numbers.
2 Prompt the user to choose an arithmetic operation (Addition, Subtraction, Multiplication, Division).
3 Use conditional statements to perform the selected operation.
4 Print the result of the operation to the console.
5 Handle division by zero with a specific message.

*/



int num1;
int num2;

Console.WriteLine("Welcome to the Conditional-Based Calculator!" + '\n' + "Please enter a number:");

string inputString1 = Console.ReadLine();
bool isNumber1 = int.TryParse(inputString1, out num1);

Console.WriteLine("Now enter second number:");

string inputString2 = Console.ReadLine();
bool isNumber2 = int.TryParse(inputString1, out num2);

Console.WriteLine("What do you want to calculate?" + '\n' + "1 - Addition" + '\n' + "2 - Subtraction" + '\n' + "3 - Multiplication" + '\n' + "4 - Division");

string inputString3= Console.ReadLine();


//to be continued

//if (isNumber1)
//{
//    Console.WriteLine("Yay! You have entered a number!");
//}
//else
//{
//    Console.WriteLine("Haha, you troll, you should have entered numbers!");
//}

Console.ReadKey();

