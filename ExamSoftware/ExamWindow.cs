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

namespace ExamApp
{
	public partial class ExamWindow : Form
	{
		Exam exam;

		public ExamWindow(string text)
		{
			InitializeComponent();

			exam = Exam.ReadFromFiles(text);

			foreach(ExamQuestion examQuestion in exam.Questions)
			{

			}
		}

		public float Answers = 0;

		private void ExamWindow_Load(object sender, EventArgs e)
		{

		}
	}
}
