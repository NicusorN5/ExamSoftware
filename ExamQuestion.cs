using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSoftware
{
	class ExamQuestion
	{
		/// <summary>
		/// The question formatted in Markdown format.
		/// </summary>
		public string Question
		{
			get { return _question; }
		}
		string _question;

		/// <summary>
		/// Gets the list of answers.
		/// </summary>
		public string[] Answers
		{
			get { return _answers; }
		}
		string[] _answers; 

		//Can be either a int, int[] or string.
		public object CorrectAnswer
		{
			get
			{
				return _correctAnswer;
			}
		}
		//something like std::variant<int, std::span<int>, std::string>.
		object _correctAnswer;

		public ExamQuestion(string question, string[] answers, string CorrectAnswer)
		{
			_question = question;
			_answers = answers;
			_correctAnswer = CorrectAnswer;
		}	
		public ExamQuestion(string question, string[] answers, int correctAnswer) 
		{
			_question = question;
			_answers = answers;
			_correctAnswer = correctAnswer;
		}
		public ExamQuestion(string question, string[] answers, int[] correctAnswers)
		{
			_question = question;
			_answers = answers;
			_correctAnswer = correctAnswers;
		}

		public bool VerifyAnswer(object answer) 
		{
			return answer == _correctAnswer;
		}
	}
}
