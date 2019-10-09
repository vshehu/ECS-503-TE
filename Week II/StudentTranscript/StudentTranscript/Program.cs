using System;

namespace StudentTranscript
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] courses = new string[10];
            int[] credits = new int[10];
            int[] grades = new int[10];
            int currentIndex = 0;
            while (true)
            {
                string courseName;
                Console.WriteLine("Please enter course name or  type '0' to continue!");
                courseName = Console.ReadLine();
                if (courseName == "0")
                {
                    break;
                }
                courses[currentIndex] = courseName;
                int grade, credit;
                Console.WriteLine("Please register the grade for course:  " + courseName);
                grade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please register the credits for course:  " + courseName);
                credit = Convert.ToInt32(Console.ReadLine());

                credits[currentIndex] = credit;
                grades[currentIndex] = grade;
                currentIndex++;
            }

            Console.WriteLine("            LIST OF COURSES");
            Console.WriteLine("=====================================");
            Console.WriteLine("COURSE NAME \t CREDITS \t GRADE");
            Console.WriteLine("=====================================");

            double sum = 0, sumOfCredits = 0;
            for (int i = 0; i < currentIndex; i++)
            {
                Console.WriteLine(courses[i] + "\t" + credits[i] + "\t" + grades[i]);

                sumOfCredits += credits[i];
                sum += grades[i] * credits[i];
            }
            double gpa = sum / sumOfCredits;

            Console.WriteLine("=====================================");
            Console.WriteLine("GPA: " + gpa.ToString("0.00"));

            Console.ReadLine();
        }
    }
}
