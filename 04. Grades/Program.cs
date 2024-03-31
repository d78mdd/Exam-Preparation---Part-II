using System;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            double numberOfFailedStudents = 0;
            double numberOfAverageStudents = 0;
            double numberOfGoodStudents = 0;
            double numberOfExcellentStudents = 0;

            double totalResult = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                
                totalResult += grade;

                if (grade < 3)
                {
                    numberOfFailedStudents++;
                }
                else if (grade < 4)
                {
                    numberOfAverageStudents++;
                }
                else if (grade < 5)
                {
                    numberOfGoodStudents++;
                }
                else
                {
                    numberOfExcellentStudents++;
                }
            }

            double totalNumberOfStudents = numberOfFailedStudents + numberOfAverageStudents + numberOfGoodStudents + numberOfExcellentStudents;

            double percentOfFailedStudents = numberOfFailedStudents * 100 / totalNumberOfStudents;
            double percentOfAverageStudents = numberOfAverageStudents * 100 / totalNumberOfStudents;
            double percentOfGoodStudents = numberOfGoodStudents * 100 / totalNumberOfStudents;
            double percentOfExcellent = numberOfExcellentStudents * 100 / totalNumberOfStudents;

            double averageGrade = totalResult / totalNumberOfStudents;

            Console.WriteLine($"Top students: {percentOfExcellent:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentOfGoodStudents:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentOfAverageStudents:F2}%");
            Console.WriteLine($"Fail: {percentOfFailedStudents:F2}%");
            Console.WriteLine($"Average: {averageGrade:F2}");
        }
    }
}
