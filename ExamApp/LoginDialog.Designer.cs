namespace ExamApp
{
	partial class LoginDialog
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
			this.label2 = new System.Windows.Forms.Label();
			this.passwordTextbox = new System.Windows.Forms.TextBox();
			this.firstNameTextbox = new System.Windows.Forms.TextBox();
			this.lastNameTextbox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "First name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password";
			// 
			// passwordTextbox
			// 
			this.passwordTextbox.Location = new System.Drawing.Point(73, 58);
			this.passwordTextbox.Name = "passwordTextbox";
			this.passwordTextbox.PasswordChar = '*';
			this.passwordTextbox.Size = new System.Drawing.Size(99, 20);
			this.passwordTextbox.TabIndex = 3;
			// 
			// firstNameTextbox
			// 
			this.firstNameTextbox.Location = new System.Drawing.Point(73, 6);
			this.firstNameTextbox.Name = "firstNameTextbox";
			this.firstNameTextbox.Size = new System.Drawing.Size(100, 20);
			this.firstNameTextbox.TabIndex = 4;
			// 
			// lastNameTextbox
			// 
			this.lastNameTextbox.Location = new System.Drawing.Point(73, 32);
			this.lastNameTextbox.Name = "lastNameTextbox";
			this.lastNameTextbox.Size = new System.Drawing.Size(100, 20);
			this.lastNameTextbox.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Last name";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(175, 111);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// LoginDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(268, 149);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lastNameTextbox);
			this.Controls.Add(this.firstNameTextbox);
			this.Controls.Add(this.passwordTextbox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "LoginDialog";
			this.Text = "Login dialog";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox passwordTextbox;
		private System.Windows.Forms.TextBox firstNameTextbox;
		private System.Windows.Forms.TextBox lastNameTextbox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
	}
}

