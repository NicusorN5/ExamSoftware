using ExamSoftware;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ExamApp
{
	public partial class TeacherMenu : Form
	{
		public TeacherMenu()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ExamCreator dialog = new ExamCreator();
			var r = dialog.ShowDialog();
			if (r == DialogResult.OK)
			{
				dialog.Exam.SaveExam();
			}
		}

		private void editTest(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				string testName = listView1.Items[listView1.SelectedItems[0].Index].SubItems[0].Text;

				ExamCreator dialog = new ExamCreator(Exam.ReadFromFiles(testName));
				var r = dialog.ShowDialog();
				if(r == DialogResult.OK)
				{
					dialog.Exam.SaveExam();
				}
			}
		}

		private void deleteTest(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				string testName = listView1.Items[listView1.SelectedItems[0].Index].SubItems[0].Text;

				listView1.Items.RemoveAt(listView1.SelectedIndices[0]);

				File.Delete(testName + ".exam");

				//delete all questions
				for (int i = 0; true; i++)
				{
					try
					{
						File.Delete(testName + "_" + i + ".question");
					}
					catch
					{
						break;
					}
				}

				//delete db entry
				List<string> entries = File.ReadAllLines("Exams.database").ToList();
				for(int i = 0; i <  entries.Count; i++)
				{
					if (entries[i] == testName)
					{
						entries.RemoveAt(i);
						break;
					}
				}

				File.WriteAllLines("Exams.database", entries);
			}
		}

		private void seeStudentExams(object sender, EventArgs e)
		{

		}

		private void TeacherMenu_Load(object sender, EventArgs e)
		{
			//load students
			if (File.Exists("Database.users"))
			{
				var data = File.ReadAllLines("Database.users");
				for (int i = 0; i < data.Length; i += 4)
				{
					if (data[i + 3] == "student")
					{
						listView2.Items.Add(new ListViewItem(new string[] { data[i], data[i + 1] }));
					}
				}
			}

			//load exams
			string[] examList = File.ReadAllLines("Exams.database");
			foreach(string examName in examList)
			{
				string[] examData = File.ReadAllLines(examName + ".exam");

				listView2.Items.Add(new ListViewItem(new string[]
				{
					examName,
					examData[0],
					examData.Length - 3 + "",
				}));
			}
		}
	}
}
