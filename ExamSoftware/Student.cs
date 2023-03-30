using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSoftware
{
	public class Student
	{
		public Student(int id, string fName, string lName, DateTime birthTime)
		{
			_id = id;
			_firstName = fName;
			_lastName = lName;
			_birthDate = birthTime;
			_courses = new List<Course>();
		}

		string _firstName;
		public string FirstName
		{
			get => _firstName;
		}

		string _lastName;
		public string LastName
		{
			get => _lastName;
		}

		DateTime _birthDate;
		public DateTime BirthDate
		{
			get => _birthDate;
		}

		List<Course> _courses;

		public Course this[int i]
		{
			get
			{
				return _courses[i];
			}
		}

		/// <summary>
		/// Returns shallow copies of the courses.
		/// </summary>
		/// <returns></returns>
		public IEnumerable<Course> GetCourses()
		{
			for(int i= 0; i < _courses.Count; i++) 
			{
				yield return _courses[i];
			}
		}
		public void AddCourse(Course course)
		{
			_courses.Add(course);
		}

		public float AverageGrade()
		{
			float g = 0;

			int l = _courses.Count;
			for (int i = 0; i <  l; i++) 
			{
				g += _courses[i].Average() / l;
			}
			return g;
		}

		int _id;
		public int ID
		{
			get { return _id; }
		}
	}
}
