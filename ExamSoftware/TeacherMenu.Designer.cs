namespace ExamApp
{
	partial class TeacherMenu
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
			button1 = new Button();
			listView1 = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			button3 = new Button();
			button2 = new Button();
			tabPage2 = new TabPage();
			listView2 = new ListView();
			columnHeader4 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			button4 = new Button();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			tabPage2.SuspendLayout();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(7, 6);
			button1.Margin = new Padding(4, 3, 4, 3);
			button1.Name = "button1";
			button1.Size = new Size(122, 27);
			button1.TabIndex = 0;
			button1.Text = "Create test";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// listView1
			// 
			listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
			listView1.Location = new Point(136, 6);
			listView1.Margin = new Padding(4, 3, 4, 3);
			listView1.Name = "listView1";
			listView1.Size = new Size(745, 447);
			listView1.TabIndex = 4;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.Details;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Test name";
			columnHeader1.Width = 80;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Course";
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Number of questions";
			columnHeader3.Width = 140;
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Location = new Point(12, 12);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(894, 484);
			tabControl1.TabIndex = 5;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(button3);
			tabPage1.Controls.Add(button2);
			tabPage1.Controls.Add(listView1);
			tabPage1.Controls.Add(button1);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(886, 456);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Tests";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(7, 72);
			button3.Name = "button3";
			button3.Size = new Size(122, 27);
			button3.TabIndex = 7;
			button3.Text = "Delete test";
			button3.UseVisualStyleBackColor = true;
			button3.Click += deleteTest;
			// 
			// button2
			// 
			button2.Location = new Point(7, 39);
			button2.Name = "button2";
			button2.Size = new Size(122, 27);
			button2.TabIndex = 6;
			button2.Text = "Edit test";
			button2.UseVisualStyleBackColor = true;
			button2.Click += editTest;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(listView2);
			tabPage2.Controls.Add(button4);
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(886, 456);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Students";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// listView2
			// 
			listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5 });
			listView2.Location = new Point(87, 6);
			listView2.Name = "listView2";
			listView2.Size = new Size(793, 444);
			listView2.TabIndex = 1;
			listView2.UseCompatibleStateImageBehavior = false;
			listView2.View = View.Details;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "First name";
			columnHeader4.Width = 100;
			// 
			// columnHeader5
			// 
			columnHeader5.Text = "Second name";
			columnHeader5.Width = 100;
			// 
			// button4
			// 
			button4.Location = new Point(6, 6);
			button4.Name = "button4";
			button4.Size = new Size(75, 69);
			button4.TabIndex = 0;
			button4.Text = "See student's tests";
			button4.UseVisualStyleBackColor = true;
			button4.Click += seeStudentExams;
			// 
			// TeacherMenu
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(913, 507);
			Controls.Add(tabControl1);
			Margin = new Padding(4, 3, 4, 3);
			Name = "TeacherMenu";
			Text = "Teacher Menu";
			Load += TeacherMenu_Load;
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Button button1;
		private ListView listView1;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private Button button2;
		private Button button3;
		private Button button4;
		private ListView listView2;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
	}
}