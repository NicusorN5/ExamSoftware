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
		public Exam(string name, string course, int numQuestions, float minReqGrade, float freePoints, List<ExamQuestion> questionList)
		{
			_questions = questionList;
			_numQuestions = questionList.Count;
			GetNextQuestion();
			_finished = false;
			_minimumGrade = minReqGrade;
			_freePoints = freePoints;

			_answers = new List<object>();
			_name = name;
			_course = course;

			_currentIndex = -1;
		}

		int _numQuestions;
		List<ExamQuestion> _questions;
		int _currentIndex;

		int _correctAnswers;
		public int NumCorrectAnswers
		{
			get
			{
				return _correctAnswers;
			}
		}

		int _totalAnswers;

		bool _finished;

		float _minimumGrade;
		public float MinimumGrade
		{
			get
			{
				return _minimumGrade;
			}
		}

		float _freePoints;
		public float FreePoints
		{
			get
			{
				return _freePoints;
			}
		}

		List<object> _answers;

		string _name;
		public string Name
		{
			get
			{
				return _name;
			}
		}

		string _course;
		public string Course
		{
			get
			{
				return _course;
			}
		}

		public int NumQuestions
		{
			get
			{
				return _numQuestions;
			}
		}

		public ExamQuestion GetNextQuestion()
		{
			if (_currentIndex == _questions.Count - 1)
			{
				_finished = true;
				return null;
			}

			return _questions[++_currentIndex];
		}

		public void AnswerQuestion(string answer)
		{
			if (_finished) return;

			bool correct = _questions[_currentIndex].VerifyAnswer(answer);
			if (correct) _correctAnswers++;
			if (_totalAnswers >= _numQuestions) _finished = true;

			_answers.Add(answer);
		}

		public float? Grade()
		{
			if (!_finished) return null;
			return (((float)_correctAnswers / (float)_numQuestions) * (10.0f - _freePoints)) + _freePoints;
		}

		public bool? Passed()
		{
			if (!_finished) return null;

			float g = Grade().Value;
			return g >= _minimumGrade;
		}

		public IEnumerable<ExamQuestion> Questions
		{
			get
			{
				return _questions;
			}
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

		public static Exam ReadFromFiles(string examName)
		{
			string[] data = File.ReadAllLines(examName + ".exam");

			List<ExamQuestion> questions = new List<ExamQuestion>();

			int j = 3;
			for (int i = 0; true; i++, j++)
			{
				try
				{
					string correctAnswersStr = data[j];

					string[] answersStr = correctAnswersStr.Split(' ');
					int[] answers = new int[answersStr.Length];
					for (int k = 0; k < answers.Length; k++)
					{
						if (!string.IsNullOrEmpty(answersStr[k]))
							answers[k] = Convert.ToInt32(answersStr[k]);
						else answers[k] = answers[k - 1];
					}

					string question = File.ReadAllText(examName + "_" + i + ".question");
					questions.Add(
						new ExamQuestion(
						question,
						File.ReadAllLines(examName + "_" + i + ".a"),
						answers
						));
				}
				catch
				{
					break;
				}
			}
			return new Exam(
				examName,
				data[0],
				data.Length - 3,
				Convert.ToInt32(data[1]),
				Convert.ToInt32(data[2]),
				questions
			);
		}

		public void SaveExam()
		{
			List<string> examData = new List<string>
				{
					Course,
					MinimumGrade + "",
					FreePoints + "",
				};

			int i = 0;
			foreach (ExamQuestion q in Questions)
			{
				File.WriteAllText(Name + "_" + i + ".question", q.Question);

				List<string> answers = new List<string>();
				foreach (var answer in q.Answers)
				{
					answers.Add(answer);
				}
				File.WriteAllLines(Name + "_" + i + ".a", answers);

				++i;

				int j = 0;

				string cAnsw = "";
				foreach (int correctAnswer in q.CorrectAnswers)
				{
					cAnsw += correctAnswer + " ";
				}
				examData.Add(cAnsw);
			}

			File.WriteAllLines(Name + ".exam", examData);
			File.AppendAllLines("Exams.database", new string[] { Name });
		}
	}
}
