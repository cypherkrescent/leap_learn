//Develop a basic c# console application that computes and shows the grade entered by the user and it should be in lower case and should not pass the range of f grade.
// Show the integer value of the grade.
Console.Write("Enter the grade:");
char gradeScore = char.Parse(Console.ReadLine());
int gradeNum;
if(gradeScore <= 'f')
{
    gradeNum = gradeScore;
    Console.WriteLine("Valid grade {0}", gradeNum);
}
else
{
    Console.WriteLine("Invalid grade");
}
//Develop a basic C# console application that computes and shows the CGPA entered by the user.
Console.Write("Enter the CGPA: ");
decimal cgPa = decimal.Parse(Console.ReadLine());
// I used a decimal datatype over the double datatype because i wanted the cgpa to be more precise.


