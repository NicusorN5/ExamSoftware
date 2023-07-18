using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ExamSoftware;

namespace ExamApp
{
	public partial class ExamCreator : Form
	{
		public ExamCreator()
		{
			InitializeComponent();

			questions = new List<ExamQuestion>(5);
			questions.Add(null);

			correctAnswers = new List<int>();
		}

		public ExamCreator(Exam exam)
		{
			examNameTextbox.Text = exam.Name;
			courseName.Text = exam.Course;
			minimalScoreTb.Text = exam.MinimumGrade + "";
			freePointsTb.Text = exam.FreePoints + "";

			questions = (List<ExamQuestion>?)exam.Questions;

			loadQuestion(0);
		}

		public Exam Exam { get; private set; }

		public List<ExamQuestion> questions;
		public List<int> correctAnswers;

		int _numQuestions = 1;

		int currentQuestionIndex = 0;

		private void btnOk_Click(object sender, EventArgs e)
		{
			Exam = new Exam(
				examNameTextbox.Text,
				courseName.Text,
				_numQuestions,
				Convert.ToSingle(minimalScoreTb.Text),
				Convert.ToSingle(freePointsTb.Text),
				questions
			);

			DialogResult = DialogResult.OK;
			Close();
		}

		private void previousQuestion_Click(object sender, EventArgs e)
		{
			if (currentQuestionIndex == 0)
				previousQuestion.Enabled = false;

			if (currentQuestionIndex != 0)
				loadQuestion(currentQuestionIndex - 1);
		}

		private void nextQuestion_Click(object sender, EventArgs e)
		{
			if (currentQuestionIndex == 0) // 0 -> 1
				previousQuestion.Enabled = true;

			loadQuestion(currentQuestionIndex + 1);
		}

		void loadQuestion(int index)
		{
			bool chk = saveCurrentAnswer();
			if (chk)
			{
				currentQuestionIndex = index;

				checkedListBox1.Items.Clear();
				if (questions.Count <= index) //if no answer was set before
				{
					questions.Add(null);
					questionTextbox.Text = "";
				}
				else if (questions[index] != null) //otherwise read existing data
				{
					questionTextbox.Text = questions[index].Question;

					foreach (string question in questions[index].Answers)
					{
						checkedListBox1.Items.Add(question);
					}

					if (questions[index].CorrectAnswers != null)
					{
						foreach (int correctAnswerIndex in questions[index].CorrectAnswers)
						{
							checkedListBox1.SetItemChecked(correctAnswerIndex, true);
						}
					}
				}
			}
			else MessageBox.Show("Please select atleast one valid answer!", "Invalid question", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		bool saveCurrentAnswer()
		{
			string[] allAnswers = new string[checkedListBox1.Items.Count];
			for (int i = 0; i < allAnswers.Length; i++)
			{
				allAnswers[i] = checkedListBox1.Items[i] as string;
			}

			int[] correctAnswers = new int[checkedListBox1.CheckedItems.Count];
			for (int i = 0; i < correctAnswers.Length; i++)
			{
				correctAnswers[i] = checkedListBox1.CheckedIndices[i];
			}

			switch (correctAnswers.Length)
			{
				case 0:
					questions[currentQuestionIndex] = new ExamQuestion(questionTextbox.Text, allAnswers, null);
					return true;
				case 1:
					questions[currentQuestionIndex] = new ExamQuestion(questionTextbox.Text, allAnswers, new int[] { checkedListBox1.CheckedIndices[0] });
					return true;
				default:
					questions[currentQuestionIndex] = new ExamQuestion(questionTextbox.Text, allAnswers, correctAnswers);
					return true;
			}
		}

		private void addAnswer_Click(object sender, EventArgs e)
		{
			AddAnswerDialog dialog = new AddAnswerDialog();
			var r = dialog.ShowDialog();
			if (r == DialogResult.OK)
			{
				checkedListBox1.Items.Add(dialog.Answer);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void removeAnswer_Click(object sender, EventArgs e)
		{
			if (checkedListBox1.SelectedIndex >= 0)
				checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
		}
	}
}
