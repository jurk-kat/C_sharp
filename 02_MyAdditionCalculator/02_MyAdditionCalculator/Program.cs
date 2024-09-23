////Calculator

//Console.WriteLine("Write a whole number:");

////input of a number

//string userInput = Console.ReadLine();

//Console.WriteLine($"You entered {userInput}. Now enter another whole number:");
//int firstNumber = int.Parse(userInput);

//// input of a second number

//int secondNumber = int.Parse(Console.ReadLine());

//// calculating the result
//int result = firstNumber + secondNumber;

////string concatination
////Console.WriteLine("The sum of " + firstNumber + " and " + secondNumber + " is " + result);

////string interpolation
//Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {result}.");

//Console.ReadKey();



// calc with doubles

double number1 = 0;
double number2 = 0;

Console.WriteLine("Write a number:");
string userInput = Console.ReadLine();
number1 = double.Parse(userInput, System.Globalization.CultureInfo.InvariantCulture);

Console.WriteLine("Write a number:");
userInput = Console.ReadLine();
number2 = double.Parse(userInput, System.Globalization.CultureInfo.InvariantCulture);

double sum = number1 + number2;
sum = Math.Round(sum, 2);

Console.WriteLine($"The sum of {number1.ToString(System.Globalization.CultureInfo.InvariantCulture)} and {number2.ToString(System.Globalization.CultureInfo.InvariantCulture)} is {sum.ToString(System.Globalization.CultureInfo.InvariantCulture)}.");

Console.ReadKey();