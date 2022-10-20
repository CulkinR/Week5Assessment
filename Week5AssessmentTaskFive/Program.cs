// See https://aka.ms/new-console-template for more information

using static System.Console;

// Vars
int grade;
int finalGrade;

WriteLine("Enter grade you with to adjust by 15%");
Write("> ");
grade = Int32.Parse(ReadLine());
finalGrade = gradeAdjust(grade);
WriteLine($"Final Grade is {finalGrade}");


// If grade + 15% is less than 100 allow to run
int gradeAdjust(int grade)
{
    if (grade + 15 <= 100)
    {
        grade += 15;
    }
    else
    {
        WriteLine("Grade is already too high - Exiting");
    }
    return grade;
}