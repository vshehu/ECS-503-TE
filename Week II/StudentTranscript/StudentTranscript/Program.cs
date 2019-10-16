using System;
using System.Collections.Generic;

namespace StudentTranscript
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = new List<string>();
            List<int> credits = new List<int>();
            List<int> grades = new List<int>();
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
                courses.Add(courseName);

                int grade, credit;
                string IN;
                Console.WriteLine("Please register the grade for course:  " + courseName);
                Console.WriteLine("If " + courseName + " is Incomplete (IN) enter -1");
                Console.WriteLine("If " + courseName + " is Not Registered (NR) enter -2");
                grade = Convert.ToInt32(Console.ReadLine());
                if (grade == -1 || grade == -2)
                {
                    grades.Add(grade);
                }
                else
                {
                    while (grade < 5 || grade > 10)
                    {
                        Console.WriteLine("You have entered invalid grade, please enter a grade 6-10!");
                        grade = Convert.ToInt32(Console.ReadLine());
                    }
                    grades.Add(grade);
                }

                Console.WriteLine("Please register the credits for course:  " + courseName);
                credit = Convert.ToInt32(Console.ReadLine());
                while (credit < 1 || credit > 10)
                {
                    Console.WriteLine("You have entered invalid credit for the course " + courseName);
                    Console.WriteLine("Please register the credits for course:  " + courseName);
                    credit = Convert.ToInt32(Console.ReadLine());
                }
                credits.Add(credit);


                currentIndex++;
            }

            Console.WriteLine("            LIST OF COURSES");
            Console.WriteLine("=====================================");
            Console.WriteLine("COURSE NAME \t CREDITS \t GRADE");
            Console.WriteLine("=====================================");

            double sum = 0, sumOfCredits = 0, sumOfPassed = 0;
            for (int i = 0; i < currentIndex; i++)
            {
                if (grades[i] == -1)
                {
                    Console.WriteLine(courses[i] + "            \t" + credits[i] + "        \t" + "IN");
                }
                else if (grades[i] == -2)
                {
                    Console.WriteLine(courses[i] + "            \t" + credits[i] + "        \t" + "NR");
                }
                else
                {
                    Console.WriteLine(courses[i] + "            \t" + credits[i] + "        \t" + grades[i]);
                }
                sumOfCredits += credits[i];
                if (grades[i] > 5)
                {
                    sumOfPassed += credits[i];
                    sum += grades[i] * credits[i];
                }
            }
            double gpa = sum / sumOfCredits;
            Console.WriteLine("Number of coursess: " + currentIndex);
            Console.WriteLine("Credits attempted: " + sumOfCredits);
            Console.WriteLine("Credits awarded: " + sumOfPassed);
            Console.WriteLine("=====================================");
            Console.WriteLine("GPA: " + gpa.ToString("0.00"));

            Console.ReadLine();
        }
    }
}
