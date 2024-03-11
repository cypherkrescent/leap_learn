//Develop a basic c# console application that computes and shows the grade entered by the user and it should be in lower case and should not pass the range of f grade.
// Show the integer value of the grade.
Console.Write("Enter the grade:");
int gradeScore = Console.Read();
int gradeNum;
if (gradeScore <= 'f')
{
    gradeNum = gradeScore;
    Console.WriteLine("Valid grade {0}", gradeNum);
}
else
{
    Console.WriteLine("Invalid grade");
}



