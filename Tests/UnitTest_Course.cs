using ExamSoftware;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamUnitTests
{
	[TestClass]
	public class UnitTest_Course
	{
		[TestMethod]
		public void CourseCtor()
		{
			Course c = new Course("Linear algebra");
			Assert.AreEqual(c.Name, "Linear algebra");
		}

		[TestMethod]
		public void CourseGrades()
		{
			Course c = new Course("Statistics");
			c.AddGrade(4);
			c.AddGrade(5);
			c.AddGrade(6);

			Assert.AreEqual(c[0], 4);
			Assert.AreEqual(c[1], 5);
			Assert.AreEqual(c[2], 6);
		}

		//Average already tested in the student unit tests.
	}
}
