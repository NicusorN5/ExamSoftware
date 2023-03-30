
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
	public class UnitTest_Teacher
	{
		[TestMethod]
		public void TeacherCtor()
		{
			Teacher t = new Teacher("John Doe");
			Assert.AreEqual(t.Name, "John Doe");
		}
	}
}
