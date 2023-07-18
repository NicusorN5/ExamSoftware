namespace ExamApp
{
	partial class ExamCreator
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			questionTextbox = new TextBox();
			previousQuestion = new Button();
			label2 = new Label();
			nextQuestion = new Button();
			btnOk = new Button();
			addAnswer = new Button();
			removeAnswer = new Button();
			btnCancel = new Button();
			minimalScoreTb = new TextBox();
			label3 = new Label();
			label4 = new Label();
			freePointsTb = new TextBox();
			checkedListBox1 = new CheckedListBox();
			label5 = new Label();
			examNameTextbox = new TextBox();
			label6 = new Label();
			courseName = new TextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(13, 106);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(55, 15);
			label1.TabIndex = 0;
			label1.Text = "Question";
			// 
			// questionTextbox
			// 
			questionTextbox.Location = new Point(77, 106);
			questionTextbox.Margin = new Padding(4, 3, 4, 3);
			questionTextbox.Multiline = true;
			questionTextbox.Name = "questionTextbox";
			questionTextbox.Size = new Size(494, 153);
			questionTextbox.TabIndex = 1;
			// 
			// previousQuestion
			// 
			previousQuestion.Enabled = false;
			previousQuestion.Location = new Point(17, 533);
			previousQuestion.Margin = new Padding(4, 3, 4, 3);
			previousQuestion.Name = "previousQuestion";
			previousQuestion.Size = new Size(131, 31);
			previousQuestion.TabIndex = 2;
			previousQuestion.Text = "< Previous question";
			previousQuestion.UseVisualStyleBackColor = true;
			previousQuestion.Click += previousQuestion_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(15, 267);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(51, 15);
			label2.TabIndex = 4;
			label2.Text = "Answers";
			// 
			// nextQuestion
			// 
			nextQuestion.Location = new Point(441, 533);
			nextQuestion.Margin = new Padding(4, 3, 4, 3);
			nextQuestion.Name = "nextQuestion";
			nextQuestion.Size = new Size(131, 31);
			nextQuestion.TabIndex = 5;
			nextQuestion.Text = "Next question >";
			nextQuestion.UseVisualStyleBackColor = true;
			nextQuestion.Click += nextQuestion_Click;
			// 
			// btnOk
			// 
			btnOk.Location = new Point(484, 571);
			btnOk.Margin = new Padding(4, 3, 4, 3);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(88, 27);
			btnOk.TabIndex = 6;
			btnOk.Text = "OK";
			btnOk.UseVisualStyleBackColor = true;
			btnOk.Click += btnOk_Click;
			// 
			// addAnswer
			// 
			addAnswer.Location = new Point(481, 267);
			addAnswer.Margin = new Padding(4, 3, 4, 3);
			addAnswer.Name = "addAnswer";
			addAnswer.Size = new Size(88, 27);
			addAnswer.TabIndex = 7;
			addAnswer.Text = "+";
			addAnswer.UseVisualStyleBackColor = true;
			addAnswer.Click += addAnswer_Click;
			// 
			// removeAnswer
			// 
			removeAnswer.Location = new Point(481, 300);
			removeAnswer.Margin = new Padding(4, 3, 4, 3);
			removeAnswer.Name = "removeAnswer";
			removeAnswer.Size = new Size(88, 27);
			removeAnswer.TabIndex = 8;
			removeAnswer.Text = "-";
			removeAnswer.UseVisualStyleBackColor = true;
			removeAnswer.Click += removeAnswer_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(17, 571);
			btnCancel.Margin = new Padding(4, 3, 4, 3);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(88, 27);
			btnCancel.TabIndex = 9;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// minimalScoreTb
			// 
			minimalScoreTb.Location = new Point(103, 73);
			minimalScoreTb.Margin = new Padding(4, 3, 4, 3);
			minimalScoreTb.Name = "minimalScoreTb";
			minimalScoreTb.Size = new Size(116, 23);
			minimalScoreTb.TabIndex = 10;
			minimalScoreTb.Text = "4.0";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(13, 76);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(82, 15);
			label3.TabIndex = 11;
			label3.Text = "Minimal score";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(226, 76);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(65, 15);
			label4.TabIndex = 12;
			label4.Text = "Free points";
			// 
			// freePointsTb
			// 
			freePointsTb.Location = new Point(302, 73);
			freePointsTb.Margin = new Padding(4, 3, 4, 3);
			freePointsTb.Name = "freePointsTb";
			freePointsTb.Size = new Size(116, 23);
			freePointsTb.TabIndex = 13;
			freePointsTb.Text = "1.0";
			// 
			// checkedListBox1
			// 
			checkedListBox1.FormattingEnabled = true;
			checkedListBox1.Location = new Point(77, 267);
			checkedListBox1.Name = "checkedListBox1";
			checkedListBox1.Size = new Size(397, 256);
			checkedListBox1.TabIndex = 15;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(17, 9);
			label5.Name = "label5";
			label5.Size = new Size(69, 15);
			label5.TabIndex = 16;
			label5.Text = "Exam name";
			// 
			// examNameTextbox
			// 
			examNameTextbox.Location = new Point(92, 6);
			examNameTextbox.Name = "examNameTextbox";
			examNameTextbox.Size = new Size(479, 23);
			examNameTextbox.TabIndex = 17;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(17, 38);
			label6.Name = "label6";
			label6.Size = new Size(44, 15);
			label6.TabIndex = 18;
			label6.Text = "Course";
			// 
			// courseName
			// 
			courseName.Location = new Point(92, 35);
			courseName.Name = "courseName";
			courseName.Size = new Size(480, 23);
			courseName.TabIndex = 19;
			// 
			// ExamCreator
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(589, 668);
			Controls.Add(courseName);
			Controls.Add(label6);
			Controls.Add(examNameTextbox);
			Controls.Add(label5);
			Controls.Add(checkedListBox1);
			Controls.Add(freePointsTb);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(minimalScoreTb);
			Controls.Add(btnCancel);
			Controls.Add(removeAnswer);
			Controls.Add(addAnswer);
			Controls.Add(btnOk);
			Controls.Add(nextQuestion);
			Controls.Add(label2);
			Controls.Add(previousQuestion);
			Controls.Add(questionTextbox);
			Controls.Add(label1);
			Margin = new Padding(4, 3, 4, 3);
			Name = "ExamCreator";
			Text = "TestCreator";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox questionTextbox;
		private Button previousQuestion;
		private Label label2;
		private Button nextQuestion;
		private Button btnOk;
		private Button addAnswer;
		private Button removeAnswer;
		private Button btnCancel;
		private TextBox minimalScoreTb;
		private Label label3;
		private Label label4;
		private TextBox freePointsTb;
		private CheckedListBox checkedListBox1;
		private Label label5;
		private TextBox examNameTextbox;
		private Label label6;
		private TextBox courseName;
	}
}