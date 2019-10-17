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
				Console.WriteLine("Please enter course name or enter '0' to continue!");
				courseName = Console.ReadLine();
				if (courseName == "0")
				{
					break;
				}
				courses.Add(courseName);
				int grade, credit;
				Console.WriteLine("Please register the grade for course:  " + courseName);
				grade = Convert.ToInt32(Console.ReadLine());
				
                while (grade < 5 && grade > 10 && (grade != -2 || grade != -1))
				{
					Console.WriteLine("Grade should be in the range of 5-10 for course: " + courseName);
					grade = Convert.ToInt32(Console.ReadLine());

				}

				Console.WriteLine("Please register the credits for course:  " + courseName);
				credit = Convert.ToInt32(Console.ReadLine());
				while (credit < 1 || credit > 10)
				{
					Console.WriteLine("Credits should be from 1 till 10 for the course:  " + courseName);
					credit = Convert.ToInt32(Console.ReadLine());
				}

				credits.Add(credit);
				grades.Add(grade);
				currentIndex++;
			}

			Console.WriteLine("            LIST OF COURSES");
			Console.WriteLine("========================================");
			Console.WriteLine("COURSE NAME \t CREDITS \t GRADE");
			Console.WriteLine("========================================");

			double sum = 0, sumOfCredits = 0, creditsPass = 0;
			for (int i = 0; i < currentIndex; i++)
			{
				if (grades[i] < 0)
				{
					if (grades[i] == -1)
						Console.WriteLine(courses[i] + "\t" + credits[i] + "\t" + "IN");
					else
						Console.WriteLine(courses[i] + "\t" + credits[i] + "\t" + "NR");
				}
				else
					Console.WriteLine(courses[i] + "\t" + credits[i] + "\t" + grades[i]);
				if (grades[i] > 5)
				{
					creditsPass += credits[i];
					sum += grades[i] * credits[i];
				}
				sumOfCredits += credits[i];

			}
			double gpa = sum / creditsPass;

			Console.WriteLine("=====================================");
			Console.WriteLine("Credits attempted: " + sumOfCredits);
			Console.WriteLine("Credits awarded: " + creditsPass);
			Console.WriteLine("Number of courses: " + currentIndex);
			Console.WriteLine("GPA: " + gpa.ToString("F2"));

			Console.ReadLine();
		}
	}
}