using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poorGradeLimit = int.Parse(Console.ReadLine());
            string taskName = Console.ReadLine();

            double currentGrade = 0;
            double averageScore = 0;
            int taskNumber = 0;
            int poorGradesNumber = 0;
            string lastTaskName = String.Empty; 
            
            while (taskName != "Enough")
            {                
                currentGrade = int.Parse(Console.ReadLine());

                if (currentGrade <= 4)
                {
                    poorGradesNumber++;
                }                
                if (poorGradesNumber >= poorGradeLimit)
                {
                    Console.WriteLine($"You need a break, {poorGradesNumber} poor grades.");
                    break;
                }

                averageScore += currentGrade;
                taskNumber++;
                lastTaskName = taskName;
                taskName = Console.ReadLine();
            }
            averageScore /= taskNumber;
            if (taskName == "Enough")
            {
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {taskNumber}");
                Console.WriteLine($"Last problem: {lastTaskName}");
            }
        }
    }
}
