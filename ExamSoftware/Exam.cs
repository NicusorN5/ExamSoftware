using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSoftware
{
	public class Exam
	{
		/// <summary>
		/// Represents a test or exam that has a collections of questions that can be answered by a student.
		/// </summary>
		/// <param name="numQuestions">number of total possible questions</param>
		/// <param name="minReqGrade">minimal grade requires to pass the exam</param>
		/// <param name="freePoints">cate puncte din din oficiu</param>
		/// <param name="questionList">question list</param>
		public Exam(int numQuestions, float minReqGrade, float freePoints, List<ExamQuestion> questionList)
		{
			_questions = questionList;
			_numQuestions = numQuestions;
			GetNextQuestion();
			_finished = false;
			_minimumGrade = minReqGrade;
			_freePoints = freePoints;

			_answers = new List<object>();
		}

		int _numQuestions;
		List<ExamQuestion> _questions;
		int _currentIndex;

		int _correctAnswers;
		int _totalAnswers;

		bool _finished;

		float _minimumGrade;
		float _freePoints;

		List<object> _answers;

		public ExamQuestion GetNextQuestion()
		{
			if (_finished) return null;

			Random r = new Random();
			int i = r.Next(0, _questions.Count);

			_currentIndex = i;
			return _questions[i];
		}

		public void AnswerQuestion(object answer)
		{
			if(_finished) return;

			bool correct = _questions[_currentIndex].VerifyAnswer(answer);
			if (correct) _correctAnswers++;
			if (_totalAnswers >= _numQuestions) _finished = true;

			_answers.Add(answer);
		}

		public float? Grade()
		{
			if(!_finished) return null;
			return (((float)_correctAnswers / (float)_numQuestions) * 10.0f) + _freePoints;
		}

		public bool? Passed()
		{
			if(!_finished) return null;

			float g = Grade().Value;
			return g >= _minimumGrade;
		}

		public IEnumerable<object> Answers
		{
			get
			{
				if (!_finished)
				{
					yield return null;
					yield break;
				}
				for (int i = 0; i < _answers.Count; i++)
				{
					yield return _answers[i];
				}
			}
		}
	}
}
