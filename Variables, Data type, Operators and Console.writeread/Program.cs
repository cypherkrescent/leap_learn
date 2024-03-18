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
//2. Develop a basic C# console application that computes and shows the CGPA entered by the user.

Console.WriteLine("Calculate CGPA");
Console.Write("Enter the grade (A, B, C, D, F): ");
char grade = char.ToUpper(Console.ReadKey().KeyChar);
Console.Write("Enter the credit hours: ");
int credits = int.Parse(Console.ReadLine());
// Calculate grade points for the course
double gradePoints = 0;
switch (grade)
{
    case 'A': gradePoints = 4.0; break;
    case 'B': gradePoints = 3.0; break;
    case 'C': gradePoints = 2.0; break;
    case 'D': gradePoints = 1.0; break;
    case 'F': gradePoints = 0.0; break;
    default:
        Console.WriteLine("Invalid grade. Defaulting to 0.0 grade points.");
        break;
}
double cgpa = gradePoints * credits;
Console.WriteLine($"\nYour CGPA is: {cgpa}");



