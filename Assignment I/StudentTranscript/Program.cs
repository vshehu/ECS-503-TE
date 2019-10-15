using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentTranscript
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = new List<string>();
            List<string> grades = new List<string>();
            List<int> credits = new List<int>();
            int currentIndex = 0;
            string input;
            int max;
            string grade;
            string credit;
            string IN = "-1";
            Console.WriteLine("Please enter 1 to start or 0 to quit");
            input = Console.ReadLine();
            if (input == "0")
            {
                goto exit;
            } 
            else
            {
                Console.WriteLine("How many courses you will enter");

               max = Convert.ToInt32(Console.ReadLine());
            }
                for (int i = 0; i < max; i++)
                {
                   Console.WriteLine("Please enter the name of the course " + i); 
                   courses.Add(Console.ReadLine());
           again:  Console.WriteLine("Please enter the grade of the course " + i);
                   grade = Console.ReadLine();
                switch (grade)
                {
                    case "in": grades.Add(IN); goto next; break;
                    case "nr": grades.Add(IN); goto next; break;
                    case "IN": grades.Add(IN); goto next; break;
                    case "NR": grades.Add(IN); goto next; break;
                    case "5":  grades.Add(grade); goto next; break;
                    case "6":  grades.Add(grade); goto next; break;
                    case "7":  grades.Add(grade); goto next; break;
                    case "8":  grades.Add(grade); goto next; break;
                    case "9":  grades.Add(grade); goto next; break;
                    case "10": grades.Add(grade); goto next; break;
                    default:
                        Console.WriteLine("Your grade must be from 5 to 10 or IN or NR");
                        goto again;
                        break;
                }
         next: Console.WriteLine("Please enter the credits of the course " + i);
                  credit = Console.ReadLine();
                int temp1 = Convert.ToInt32(credit);
                if (temp1 >= 1 && temp1 <= 10)
                {
                    credits.Add(temp1);
                }
                else
                {
                    Console.WriteLine("Please enter numbers from 1 to 10!");
                    goto next;
                }
            }
            Console.WriteLine("             C O U R S E S");
            Console.WriteLine("========================================");
            Console.WriteLine("Course " + "\t" + "Credits " + "\t" + "Grade ");
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine(courses[i] + "\t" + credits[i] + "\t" + grades[i].ToString());
            }
            Console.WriteLine("========================================");
            int vkupno = credits.Sum(x => Convert.ToInt32(x));
            Console.WriteLine("             R E S U L T");
            Console.WriteLine("========================================");
            Console.WriteLine("Number of courses: " + max);
            Console.WriteLine("Credits atempted: " + vkupno);

            //konvertiraj ja listata grades vo tip integer
            List<int> igrades = grades.ConvertAll(int.Parse);

            //presmetka na GPA i dodeleni krediti
            double sum = 0, sumOfCredits = 0;
            for (int i = 0; i < max; i++)
            {
                if ((igrades[i] >= 6 && igrades[i] <= 10) && (credits[i] >= 1 && credits[i] <= 10))
            {
                sumOfCredits += credits[i];
                sum += igrades[i] * credits[i];
            }
            }
            double gpa = sum / sumOfCredits;
            Console.WriteLine("Credits awarded: " + sumOfCredits);
            Console.WriteLine("Your GPA: " + gpa.ToString("0.00"));
            Console.WriteLine("========================================");
            Console.ReadLine();
        exit: Console.WriteLine("Thank you, Bye Bye!");
            Console.ReadLine();
        }
    }
}