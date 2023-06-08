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
		}
		public Exam Exam { get; private set; }

		public List<ExamQuestion> questions;
		public List<int> correctAnswers;

		int _numQuestions = 1;

		int currentQuestionIndex = 0;

		private void btnOk_Click(object sender, EventArgs e)
		{
			Exam = new Exam(
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
			currentQuestionIndex -= 1;

			if (currentQuestionIndex == 0)
				previousQuestion.Enabled = false;

			setTextboxes();
		}

		private void nextQuestion_Click(object sender, EventArgs e)
		{
			if (currentQuestionIndex == 0)
				previousQuestion.Enabled = true;

			if(currentQuestionIndex > questions.Count - 1)
			{
				questions.Add(null);
			}

			List<string> answers = new List<string>();
			foreach(string answer in listBox1.Items )
			{
				if(answer.StartsWith("[CORRECT]"))
				{
					answer.Remove(0, "[CORRECT]".Length);
				}
				answers.Add(answer);
			}

			if(answers.Count == 1)
			{
				questions[currentQuestionIndex] = new ExamQuestion(questionTextbox.Text, null, answers[0]);
			}
			if (correctAnswers.Count > 1)
			{
				questions[currentQuestionIndex] = new ExamQuestion(questionTextbox.Text, answers.ToArray(), correctAnswers.ToArray());
			}
			if(correctAnswers.Count == 1)
			{
				questions[currentQuestionIndex] = new ExamQuestion(questionTextbox.Text, answers.ToArray(), correctAnswers[0]);
			}

			currentQuestionIndex += 1;
			setTextboxes();
		}

		private void setTextboxes()
		{
			listBox1.Items.Clear();
			if (questions[currentQuestionIndex] != null)
			{
				var q = questions[currentQuestionIndex];
				questionTextbox.Text = q.Question;

				if (q.Answers.Count() == 1)
				{
					listBox1.Items.Add(q.CorrectAnswer as string);
				}
				else
				{
					for (int i = 0; i < q.Answers.Count(); i++)
					{
						string item = q.Answers[i];
						if (q.CorrectAnswer is int[] lst)
						{
							for (int j = 0; j < lst.Length; j++)
							{
								if (lst[j] == i)
								{
									listBox1.Items.Add("[CORRECT]" + item);
								}
							}
						}
						else if(q.CorrectAnswer is int idAnswer)
						{
							if(idAnswer == i)
							{
								listBox1.Items.Add("[CORRECT]" + item);
							}
						}
					}
				}
			}
			
		}

		private void addAnswer_Click(object sender, EventArgs e)
		{

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void markAsCorrect_Click(object sender, EventArgs e)
		{
			foreach(int selectedItem in listBox1.SelectedIndices) 
			{
				if (!listBox1.Items[selectedItem].ToString().StartsWith("[CORRECT]"))
				{
					listBox1.Items[selectedItem] = "[CORRECT]" + listBox1.Items[selectedItem];
				}
				else listBox1.Items[selectedItem] = listBox1.Items[selectedItem].ToString().Remove(0, "[CORRECT]".Length);
			}
		}

		private void removeAnswer_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex > 0)
				listBox1.Items.RemoveAt(listBox1.SelectedIndex);
		}
	}
}
