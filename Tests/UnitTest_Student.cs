using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ExamSoftware;

namespace ExamUnitTests
{
	[TestClass]
	public class UnitTest_Student
	{
		[TestMethod]
		public void	StudentCtor()
		{
			Student student = new Student(123, "John", "Doe", new DateTime(1996, 7, 14));

			Assert.AreEqual(student.FirstName, "John");
			Assert.AreEqual(student.LastName, "Doe");
			Assert.AreEqual(student.BirthDate, new DateTime(1996, 7, 14));
			Assert.AreEqual(student.ID, 123);
		}

		[TestMethod]
		public void StudentGradesAdd()
		{
			Student student = new Student(125, "John", "Doe", new DateTime(1994, 2, 16));
			student.AddCourse(new Course("Calculus III"));
			student[0].AddGrade(5);
			student[0].AddGrade(7);

			Assert.AreEqual(student[0].Average(), 6);
		}

		[TestMethod]
		public void StudentCourses()
		{
			Student student = new Student(1, "dummy", "dummy", new DateTime(2000, 1, 1));
			
			student.AddCourse(new Course("Calculus I"));
			student[0].AddGrade(6);
			student[0].AddGrade(8);

			student.AddCourse(new Course("Calculus II"));
			student[1].AddGrade(4);
			student[1].AddGrade(6);

			student.AddCourse(new Course("Calculus III"));
			student[2].AddGrade(5);
			student[2].AddGrade(7);

			Assert.AreEqual(student[0].Name, "Calculus I");
			Assert.AreEqual(student[1].Name, "Calculus II");
			Assert.AreEqual(student[2].Name, "Calculus III");

			Assert.AreEqual(student.AverageGrade(), 6);
		}
	}
}
