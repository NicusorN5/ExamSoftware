namespace ExamApp
{
	partial class ExamWindow
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
			questionTb = new TextBox();
			answersTb = new CheckedListBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// questionTb
			// 
			questionTb.Location = new Point(12, 12);
			questionTb.Multiline = true;
			questionTb.Name = "questionTb";
			questionTb.Size = new Size(776, 101);
			questionTb.TabIndex = 0;
			// 
			// answersTb
			// 
			answersTb.FormattingEnabled = true;
			answersTb.Location = new Point(12, 119);
			answersTb.Name = "answersTb";
			answersTb.Size = new Size(776, 346);
			answersTb.TabIndex = 1;
			// 
			// button1
			// 
			button1.Location = new Point(713, 471);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 2;
			button1.Text = ">";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// ExamWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 518);
			Controls.Add(button1);
			Controls.Add(answersTb);
			Controls.Add(questionTb);
			Name = "ExamWindow";
			Text = "Exam";
			Load += ExamWindow_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox questionTb;
		private CheckedListBox answersTb;
		private Button button1;
	}
}