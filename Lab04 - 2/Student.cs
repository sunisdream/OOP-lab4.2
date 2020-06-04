using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04___2
{
	class Student
	{
		private string lastName;
		private int gradebookId;
		private int rating;
		public Student() { }
		public string GetLastName() { return lastName; }
		public int GetGradebookId() { return gradebookId; }
		public int GetRating() { return rating; }
		public void SetLastName(string surname) { lastName = surname; }
		public void SetGradebookId(int id) { gradebookId = id; }
		public void SetRating(int r) 
		{
			if (r <= 100 && r >= 0)
			{
				rating = r;
			}
			else 
			{
				throw new Exception("Wrong rating");
			}
		}

		public static void Sort(Student[] students)
		{
			int size = students.Length;
			Student temp;
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size - i - 1; j++)
				{
					if (students[j].rating < students[j + 1].rating)
					{
						temp = students[j];
						students[j] = students[j + 1];
						students[j + 1] = temp;
					}
				}
			}
		}

		public static double GetAverageRating(Student[] students)
		{
			double average = 0;
			int size = students.Length;
			
			for (int i = 0; i < size; i++)
			{
				average += students[i].rating;
			}
			average /= size;
			
			return average;
		}

		public static int GetUnderAverageAmount(Student[] students)
		{
			int amount = 0;
			int size = students.Length;
			double average = GetAverageRating(students);

			for (int i = 0; i < size; i++)
			{
				if (students[i].rating < average)
				{
					amount++;
				}
			}

			return amount;
		}

		public static void Output(Student[] students)
		{
			int size = students.Length;
			for (int i = 0; i < size; i++)
			{
				Console.WriteLine();
				Console.WriteLine("Student #{0}:", i + 1);
				Console.WriteLine("Last name: {0}", students[i].lastName);
				Console.WriteLine("Gradebook ID: {0}", students[i].gradebookId);
				Console.WriteLine("Rating: {0}", students[i].rating);
			}
		}
	}
}
