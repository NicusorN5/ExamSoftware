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
	public class UnitTest_ExamQuestion
	{
		[TestMethod]
		public void QuestionCtor()
		{
			ExamQuestion q = new ExamQuestion("1+1 = ?", new string[] { "101", "1", "2" }, new int[] { 2 });
			
			Assert.AreEqual(q.Question, "1+1 = ?");
			Assert.AreEqual(q.CorrectAnswers[0], "2");
			CollectionAssert.AreEqual(q.Answers, new string[] { "101", "1", "2" });
		}

		[TestMethod]
		public void QuestionAnswers()
		{
			ExamQuestion q = new ExamQuestion("2+2 = ?", new string[] { "4", "5", "2" }, new int[] { 0 });

			Assert.AreEqual(q.VerifyAnswer("2"), false);
			Assert.AreEqual(q.VerifyAnswer("4"), true);
			Assert.AreEqual(q.VerifyAnswer("5"), false);
		}
	}
}
