int currentScore;
int sum = 0;
int numOfTries = 0;
int average;

do
{
    Console.WriteLine("Teacher, enter your student score, enter 0 to finish");
    currentScore = int.Parse(Console.ReadLine());
    if (currentScore != 0)
    {
        sum = sum + currentScore;
        numOfTries++;
    }
}
while (currentScore != 0);

average = sum / numOfTries;

Console.WriteLine($"The average is {average}");

Console.ReadLine();

