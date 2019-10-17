using System;

namespace bd27128
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace Homework01
    {
        class StudentTranscript
        {
            static void Main(string[] args)
            {
                List<string> courses = new List<string>();
                List<int> credits = new List<int>();
                List<string> grades = new List<string>();

                int i = 0;
                while (true)
                {
                    string courseName;

                    Console.WriteLine("Please enter new course. After you finish, type '0' to continue forward!");
                    courseName = Console.ReadLine();
                    if (courseName == "0")
                    {
                        break;
                    }
                    courses.Add(courseName);

                    string grade;
                    int credit;

                    Console.WriteLine($"Please enter a grade for {courseName}.");
                    grade = Console.ReadLine().ToUpper();
                    if (int.TryParse(grade, out _))
                    {
                        if (Convert.ToInt32(grade) >= 5 && Convert.ToInt32(grade) <= 10)
                        {
                            grades.Add(grade);
                        }
                        else
                        {
                            Console.WriteLine("Enter a valid grade.");
                            break;
                        }
                    }
                    else if (grade.Equals("IN") || grade.Equals("NR"))
                    {
                        grades.Add(grade);
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid grade.");
                        break;
                    }

                    Console.WriteLine($"Please enter credits for {courseName}.");
                    credit = Convert.ToInt32(Console.ReadLine());
                    if (credit < 1 || credit > 10)
                    {
                        Console.WriteLine("Enter a valid amount of credits.");
                        break;
                    }
                    credits.Add(credit);

                    i++;
                }

                Console.WriteLine(" \t \t \t \t \t \t LIST OF COURSES \t \t \t \t \t \t \t ");
                Console.WriteLine("========================================================================================================================");
                Console.WriteLine("COURSE NAME \t \t \t \t \t \t GRADE \t \t \t \t \t CREDITS");
                Console.WriteLine("========================================================================================================================");

                double sum = 0, sumOfCreditsAttempted = 0, sumOfCreditsAwarded = 0, sumOfClasses = 0;
                string sumFailed = "0";
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine($"{courses[j]} \t \t \t \t \t \t \t {grades[j]}  \t \t \t \t \t {credits[j]}");

                    if (grades[j] == "5" || grades[j] == "IN" || grades[j] == "NR")
                    {
                        sumFailed += 5 * sumOfCreditsAwarded;

                        grades.Add(sumFailed);
                    }
                    else
                    {
                        grades.Remove(sumFailed);

                        sumOfCreditsAwarded += credits[j];
                        sum += Convert.ToInt32(grades[j]) * credits[j];
                    }
                    sumOfCreditsAttempted += credits[j];
                }

                double gpa = sum / sumOfCreditsAwarded;
                sumOfClasses = courses.Count();

                Console.WriteLine("========================================================================================================================");
                Console.WriteLine($"Credits attempted: {sumOfCreditsAttempted}");
                Console.WriteLine($"Credits Awarded: {sumOfCreditsAwarded}");
                Console.WriteLine($"Number of Courses: {sumOfClasses}");
                Console.WriteLine($"GPA: {gpa.ToString("0.00")}");
            }
        }
    }
}