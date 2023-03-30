using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExamSoftware
{
	public class Teacher
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

		public Exam this[int i]
		{
			get { return _exams[i]; }
		}

		public void RemoveExam(int i) 
		{
			_exams.RemoveAt(i);
		}
    }
}
