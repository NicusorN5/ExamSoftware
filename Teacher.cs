using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSoftware
{
	class Teacher
	{
		public Teacher(string name)
		{
			_name = name;
			_exams = new List<Exam>();
		}

		public string _name;
		public string Name { get { return _name; } }

		List<Exam> _exams;

		public void AddExam(Exam exam)
		{
			_exams.Add(exam);
		}
		void a()
		{

		}
	}
}
