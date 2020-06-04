using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04___2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("How many students do you want to enter?");
			int studentAmount = Convert.ToInt32(Console.ReadLine());

			Student[] students = new Student[studentAmount];
			for (int i = 0; i < studentAmount; i++)
			{
				students[i] = new Student();

				Console.WriteLine("Enter student's surname, gradebook id and rating:");
				students[i].SetLastName(Console.ReadLine());
				students[i].SetGradebookId(Convert.ToInt32(Console.ReadLine()));
				students[i].SetRating(Convert.ToInt32(Console.ReadLine()));
			}

			Student.Sort(students);
			Student.Output(students);
			double studAverage = Student.GetAverageRating(students);
			int underAverageAmount = Student.GetUnderAverageAmount(students);

			Console.WriteLine();
			Console.WriteLine("Average rating is {0} with {1} students under average rating.", studAverage, underAverageAmount);

			Console.ReadKey();
		}
	}
}
