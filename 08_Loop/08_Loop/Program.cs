//LOOPS

//// For loop
//// count up

//for (int i=1; i<10; i++) // i ++ is the same as i = i+1
//{
//    Console.WriteLine("i is " + i);
//}
//Console.WriteLine("End of program");
//Console.ReadKey();

//// count down
//for (int i = 10; i >= 5; i--)
//{
//    Console.WriteLine("i is " + i);
//}
//Console.WriteLine("End of program");
//Console.ReadKey();

////nasobky 2
//for (int i = 2; i <= 20; i = i + 2)
//{
//    Console.WriteLine("i is " + i);
//}
//Console.WriteLine("End of program");
//Console.ReadKey();

////mocniny 2
//for (int i = 2; i <= 1000; i = i * 2)
//{
//    Console.WriteLine("i is " + i);
//}
//Console.WriteLine("End of program");
//Console.ReadKey();

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


