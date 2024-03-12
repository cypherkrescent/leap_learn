        Console.WriteLine("Convert Score to Letter Grade"); 
        Console.Write("Enter the numerical score: ");
        int score = int.Parse(Console.ReadLine());
        char letterGrade;
        if (score >= 90)
        {
            letterGrade = 'A';
        }
        else if (score >= 80)
        {
            letterGrade = 'B';
        }
        else if (score >= 70)
        {
            letterGrade = 'C';
        }
        else if (score >= 60)
        {
            letterGrade = 'D';
        }
        else
        {
            letterGrade = 'F';
        }
        Console.WriteLine($"The letter grade for the score {score} is: {letterGrade}");