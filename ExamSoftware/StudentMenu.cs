using ExamApp;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamSoftware
{
	public partial class StudentMenu : Form
	{
		Student _student;

		public StudentMenu(Student student)
		{
			InitializeComponent();

			_student = student;
		}

		string resultsFile(string examName)
		{
			return _student.FirstName + " " + _student.LastName + " " + examName + ".results";
		}

		private void StudentMenu_Load(object sender, EventArgs e)
		{
			string[] examList = File.ReadAllLines("Exams.database");
			foreach (string examName in examList)
			{
				string[] examData = File.ReadAllLines(examName + ".exam");

				string grade = "-";
				string numCorrectQ = "-";

				if (File.Exists(resultsFile(examName)))
				{
					string[] examResults = File.ReadAllText(resultsFile(examName)).Split(' ');
					numCorrectQ = examResults[0];
					grade = examResults[1];
				}

				listView1.Items.Add(new ListViewItem(new string[]
				{
					examName,
					examData[0],
					examData.Length - 3 + "",
					numCorrectQ,
					grade
				}));
			}
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(listView1.SelectedItems.Count == 1)
			{
				string examName = listView1.SelectedItems[0].Text;
				ExamWindow examWindow = new ExamWindow(examName);
				var r = examWindow.ShowDialog();
				if(r == DialogResult.OK)
				{
					
				}
				else
				{
					File.WriteAllText(resultsFile(examName), "0 0");
				}
			}
		}
	}
}
