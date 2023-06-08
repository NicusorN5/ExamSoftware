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
			this.label1 = new System.Windows.Forms.Label();
			this.questionTextbox = new System.Windows.Forms.TextBox();
			this.previousQuestion = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.nextQuestion = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.addAnswer = new System.Windows.Forms.Button();
			this.removeAnswer = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.minimalScoreTb = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.freePointsTb = new System.Windows.Forms.TextBox();
			this.markAsCorrect = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Question";
			// 
			// questionTextbox
			// 
			this.questionTextbox.Location = new System.Drawing.Point(67, 35);
			this.questionTextbox.Multiline = true;
			this.questionTextbox.Name = "questionTextbox";
			this.questionTextbox.Size = new System.Drawing.Size(424, 133);
			this.questionTextbox.TabIndex = 1;
			// 
			// previousQuestion
			// 
			this.previousQuestion.Location = new System.Drawing.Point(15, 405);
			this.previousQuestion.Name = "previousQuestion";
			this.previousQuestion.Size = new System.Drawing.Size(112, 27);
			this.previousQuestion.TabIndex = 2;
			this.previousQuestion.Text = "< Previous question";
			this.previousQuestion.UseVisualStyleBackColor = true;
			this.previousQuestion.Click += new System.EventHandler(this.previousQuestion_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(67, 174);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(340, 225);
			this.listBox1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 174);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Answers";
			// 
			// nextQuestion
			// 
			this.nextQuestion.Location = new System.Drawing.Point(379, 405);
			this.nextQuestion.Name = "nextQuestion";
			this.nextQuestion.Size = new System.Drawing.Size(112, 27);
			this.nextQuestion.TabIndex = 5;
			this.nextQuestion.Text = "Next question >";
			this.nextQuestion.UseVisualStyleBackColor = true;
			this.nextQuestion.Click += new System.EventHandler(this.nextQuestion_Click);
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(416, 438);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 6;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// addAnswer
			// 
			this.addAnswer.Location = new System.Drawing.Point(413, 174);
			this.addAnswer.Name = "addAnswer";
			this.addAnswer.Size = new System.Drawing.Size(75, 23);
			this.addAnswer.TabIndex = 7;
			this.addAnswer.Text = "+";
			this.addAnswer.UseVisualStyleBackColor = true;
			this.addAnswer.Click += new System.EventHandler(this.addAnswer_Click);
			// 
			// removeAnswer
			// 
			this.removeAnswer.Location = new System.Drawing.Point(413, 203);
			this.removeAnswer.Name = "removeAnswer";
			this.removeAnswer.Size = new System.Drawing.Size(75, 23);
			this.removeAnswer.TabIndex = 8;
			this.removeAnswer.Text = "-";
			this.removeAnswer.UseVisualStyleBackColor = true;
			this.removeAnswer.Click += new System.EventHandler(this.removeAnswer_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(15, 438);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// minimalScoreTb
			// 
			this.minimalScoreTb.Location = new System.Drawing.Point(89, 6);
			this.minimalScoreTb.Name = "minimalScoreTb";
			this.minimalScoreTb.Size = new System.Drawing.Size(100, 20);
			this.minimalScoreTb.TabIndex = 10;
			this.minimalScoreTb.Text = "4.0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Minimal score";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(195, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Free points";
			// 
			// freePointsTb
			// 
			this.freePointsTb.Location = new System.Drawing.Point(260, 6);
			this.freePointsTb.Name = "freePointsTb";
			this.freePointsTb.Size = new System.Drawing.Size(100, 20);
			this.freePointsTb.TabIndex = 13;
			this.freePointsTb.Text = "1.0";
			// 
			// markAsCorrect
			// 
			this.markAsCorrect.Location = new System.Drawing.Point(413, 232);
			this.markAsCorrect.Name = "markAsCorrect";
			this.markAsCorrect.Size = new System.Drawing.Size(75, 81);
			this.markAsCorrect.TabIndex = 14;
			this.markAsCorrect.Text = "Mark selected answer as correct";
			this.markAsCorrect.UseVisualStyleBackColor = true;
			this.markAsCorrect.Click += new System.EventHandler(this.markAsCorrect_Click);
			// 
			// ExamCreator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 471);
			this.Controls.Add(this.markAsCorrect);
			this.Controls.Add(this.freePointsTb);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.minimalScoreTb);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.removeAnswer);
			this.Controls.Add(this.addAnswer);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.nextQuestion);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.previousQuestion);
			this.Controls.Add(this.questionTextbox);
			this.Controls.Add(this.label1);
			this.Name = "ExamCreator";
			this.Text = "TestCreator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox questionTextbox;
		private System.Windows.Forms.Button previousQuestion;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button nextQuestion;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button addAnswer;
		private System.Windows.Forms.Button removeAnswer;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox minimalScoreTb;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox freePointsTb;
		private System.Windows.Forms.Button markAsCorrect;
	}
}