using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Lab04___2___Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			string[] surname = new string[10] { "Kiratov", "Barenkova", "Kilyatov", "Hirko", "Ivanov", "Oleniv", "Iritan", "Berunkov", "Omelyan", "Kirkorov" };
			int[] id = new int[10] { 3847109, 2856108, 2835710, 3728195, 4736281, 5867372, 3955738, 7561003, 8427364, 2855104 };
			int[] rating = new int[10] { 87, 57, 68, 97, 67, 54, 78, 69, 79, 90 };
			List<Student> students = new List<Student>();
			for (int i = 0; i < 10; i++)
			{
				students.Add(new Student());
				students[i].SetLastName(surname[i]);
				students[i].SetGradebookId(id[i]);
				students[i].SetRating(rating[i]);
			}

			double studAverage = Student.GetAverageRating(students.ToArray());
			int underAverageAmount = Student.GetUnderAverageAmount(students.ToArray());
			Assert.AreEqual(74.6, studAverage);
			Assert.AreEqual(5, underAverageAmount);
		}
	}
}
