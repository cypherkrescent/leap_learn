//Develop a basic c# console application that computes and shows the grade entered by the user and it should be in lower case and should not pass the range of f grade.
// Show the integer value of the grade.

Console.WriteLine("Enter the grade:");
char gradeScore = char.Parse(Console.ReadLine());
if (gradeScore <= 'f')
{
    Console.WriteLine("Valid grade {0}", gradeScore);
}
else
{
    Console.WriteLine("Invalid grade");
}



