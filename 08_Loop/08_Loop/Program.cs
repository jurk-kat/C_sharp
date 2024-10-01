//LOOPS

/*

// FOR LOOP

// count up

for (int i = 1; i < 10; i++) // i ++ is the same as i = i+1
{
    Console.WriteLine("i is " + i);
}
Console.WriteLine("End of program");
Console.ReadKey();

// count down
for (int i = 10; i >= 5; i--)
{
    Console.WriteLine("i is " + i);
}
Console.WriteLine("End of program");
Console.ReadKey();

//nasobky 2
for (int i = 2; i <= 20; i = i + 2)
{
    Console.WriteLine("i is " + i);
}
Console.WriteLine("End of program");
Console.ReadKey();

//mocniny 2
for (int i = 2; i <= 1000; i = i * 2)
{
    Console.WriteLine("i is " + i);
}
Console.WriteLine("End of program");
Console.ReadKey();

// escape characters r and n, Thread.Sleep

string myString = "Hi\r\nHi"; // in strings \ is an escape character, the char aftere it has a special function

// \n - new line - works fine on Linux
// \r - carriage return - \r\n works fine on Mac, Windows

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("the counter \"i\" is " + i); // here \ has the function of saying that " is not end of the string
    Console.WriteLine(myString);
    Thread.Sleep(1000); // pauses the program for 1000 ms = 1s do not really use in production
}
Console.WriteLine("End of program");
Console.ReadKey();


// WHILE LOOP

for (int i = 1; i < 10; i++)
{
    Console.WriteLine(i);
}

//the code bellow works same as the for loop above

int counter = 0;
while (counter < 10) // condition, when the while will be running
{
    Console.WriteLine(counter);
    counter++; //there HAS to be a way out. without a case where the condition is not true we are in an infinite loop
}



int counter = 0;
while (counter <= 10) // condition, when the while will be running
{
    Console.WriteLine(counter);
    counter += 5;
}


// how to use the while loop correctly:
// with bool

bool isGood = true;

while (isGood)
{
    Console.WriteLine("life is good");
    isGood = false;
}

// It can be done also with bool or without

Console.WriteLine("Go or stay?");

string userChoice = Console.ReadLine();

while (userChoice == "go")
{
    Console.WriteLine("Go for a mile. Wanna keep going?");
    userChoice = Console.ReadLine();
}


// DO WHILE LOOP
// runs at least once and then checks the conditions. While first checkes the conditions, then runs.
// while loop:      pre-test
// do while loop:   post-test

int i = 0;

do
{
    i++;
    Console.WriteLine(i);
} while (i < 10);

do
{
    Console.WriteLine(i);
    i++;
} while (i < 10);


// this will still run once:
int i = 15;

do
{
    Console.WriteLine(i);
    i++;
} while (i < 10);

*/

//useful when we need a user input

int number;

do
{
    Console.WriteLine("User, enter a whole positive number");
    number = int.Parse(Console.ReadLine());
}
while (number <= 0);

Console.WriteLine("Finally!");

Console.ReadLine();
