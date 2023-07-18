using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSoftware
{
	public class ExamQuestion
	{
		/// <summary>
		/// The question formatted in Markdown format.
		/// </summary>
		public string Question { get; private set; }

		/// <summary>
		/// Gets the list of answers.
		/// </summary>
		public string[] Answers { get; private set; }

		public int[] CorrectAnswers { get; private set; }

		public ExamQuestion(string question, string[] answers, int[] correctAnswers)
		{
			Question = question;
			Answers = answers;
			CorrectAnswers = correctAnswers;
		}

		public bool VerifyAnswer(string answer) 
		{
			foreach(string qanswer in Answers)
			{
				if (qanswer == answer) return true;
			}
			return false;
		}
	}
}
