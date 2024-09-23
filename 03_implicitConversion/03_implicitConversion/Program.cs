//// implicit conversion

////int myInt = 13;
////double myDouble = myInt;

//var num1 = 10;
//var num2 = 20;

//Console.WriteLine("concatination" + num1 + num2); // concatination1020
//Console.WriteLine("concatination" + (num1 + num2)); // concatination30
//Console.ReadKey();

//// excercise
//char myChar1 = '\t';
//char myChar2 = '\n';

//Console.WriteLine($"Hello {myChar2} {myChar1} World");
//Console.ReadKey();

////
//bool itIsSunny = true; //tzn it is not raining
//bool iHaveUmbrella = false;

//if (itIsRaining || iHaveUmbrella)
//{
//    Console.WriteLine("I will not get wet");
//}

//else
//{
//    Console.WriteLine("I will get wet");
//}

//Console.ReadKey();

////
//bool itIsRaining = true;
//bool iHaveUmbrella = false;

//if (!itIsRaining || iHaveUmbrella)
//{
//    Console.WriteLine("I will not get wet");
//}

//else
//{
//    Console.WriteLine("I will get wet");
//}

////Console.ReadKey();

////relational operators< <= > >= == !=

//// if, else if, else - similar to how I know it from Python



// switch:

Console.WriteLine("Write the number of the month:");

var month = int.Parse(Console.ReadLine());
string monthName;

switch (month)
{
    case 1:
        monthName = "January";
        break;
    case 2:
        monthName = "February";
        break;
    case 3:
        monthName = "March";
        break;
    default:
        monthName = "Unknown";
        break;
}

Console.WriteLine($"The month is {monthName}");
Console.ReadKey();