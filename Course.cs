using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamSoftware
{
	public class Course
	{
		public Course(string name)
		{
			_name = name;
			Grades = new List<float>();
		}

		/// <summary>
		/// Course name.
		/// </summary>
		public string Name
		{
			get
			{
				return _name;
			}
		}
		string _name;

		List<float> Grades;

		public void AddGrade(float grade)
		{
			Grades.Add(grade);
		}

		/// <summary>
		/// Gets the i-th grade.
		/// </summary>
		/// <param name="i">Grade index.</param>
		/// <returns>i-th grade</returns>
		public float this[int i]
		{
			get { return Grades[i]; }
		}

		public float Average()
		{
			return Grades.Average();
		}
	}
}
