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

		public Exam Exam
		{
			get
			{
				return exam;
			}
		}

		public ExamWindow(string text)
		{
			InitializeComponent();

			exam = Exam.ReadFromFiles(text);
			SetNextQuestion();
		}

		int currentIndex;

		public int NumCorrectAnswers
		{
			get
			{
				return exam.NumCorrectAnswers;
			}
		}

		ExamQuestion currentQuestion;

		void SetNextQuestion()
		{
			currentQuestion = exam.GetNextQuestion();
			if (currentQuestion == null) return;

			questionTb.Text = currentQuestion.Question;

			answersTb.Items.Clear();
			foreach (var answer in currentQuestion.Answers)
			{
				answersTb.Items.Add(answer);
			}
		}

		public float Answers = 0;

		private void ExamWindow_Load(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int c = 0;
			foreach(string item in answersTb.SelectedItems)
			{
				exam.AnswerQuestion(item);
			}
				
			SetNextQuestion();

			if (currentQuestion == null)
			{
				exam.Grade();
				
				DialogResult = DialogResult.OK;
				Close();
			}
		}
	}
}
