﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ExamApp
{
	public partial class LoginDialog : Form
	{
		public LoginDialog()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (File.Exists("Database.users"))
			{
				var data = File.ReadAllLines("Database.users");
				for(int i =0; i < data.Length; i += 4)
				{
					if (data[i] == firstNameTextbox.Text &&
						data[i+1] == lastNameTextbox.Text)
					{
						if (data[i + 2] == passwordTextbox.Text)
						{
							DialogResult = DialogResult.OK;

							switch(data[i+3])
							{
								case "teacher":
									TeacherMenu menu = new TeacherMenu();
									menu.ShowDialog();
									break;

								case "student":
								default:
									//todo: show student menu
									break;
							}

							Close();
							return;
						}
						else
						{
							MessageBox.Show("Password is incorrect!", ">:(", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return;
						}
					}
				}

				RegistrationDialog dialog = new RegistrationDialog();
				var r = dialog.ShowDialog();
				if(r == DialogResult.OK)
				{
					string[] accData = { firstNameTextbox.Text,  lastNameTextbox.Text, dialog.IsTeacher ? "teacher" : "student" };

					if(dialog.IsTeacher)
					{
						var teacherMenu = new TeacherMenu();
						teacherMenu.ShowDialog();
					}
					else
					{

					}

					File.AppendAllLines("Database.users", accData);
				}
			}
			else
			{
				File.Create("Database.users");

				AdminPasswordDialog dlg = new AdminPasswordDialog();
				DialogResult r = dlg.ShowDialog();

				if(r != DialogResult.OK) Application.Exit();
			}
		}
	}
}
