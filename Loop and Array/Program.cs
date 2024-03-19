Console.WriteLine("Convert Score to Letter Grade"); 
Console.Write("Enter the numerical score: ");
int score = int.Parse(Console.ReadLine());
if (score <= 100 && score >= 90)
{
    Console.WriteLine("The letter grade for the score is: A");
}
else if (score <= 89 && score >= 75)
{
    Console.WriteLine("The letter grade for the score is:B");
}
else if (score <= 74 && score >= 50)
{
    Console.WriteLine("The letter grade for the score is:C");
}
else if (score <= 49 && score >= 40)
{
    Console.WriteLine("The letter grade for the score is:D");
}
else if (score <= 39 && score >= 0)
{
    Console.WriteLine("The letter grade for the score is:F");
}
else
{
    Console.WriteLine("No grade.");
}
 
