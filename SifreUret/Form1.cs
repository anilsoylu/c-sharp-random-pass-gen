using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RandomCov2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnStart_Click(object sender, EventArgs e)
		{
			int TotalCountGenPass = Convert.ToInt32(txtCountPass.Text);
			HashSet<string> generatedPasswords = new HashSet<string>();
			StringBuilder pass = new StringBuilder();

			while (generatedPasswords.Count < TotalCountGenPass)
			{
				string newPassword = RastgeleUret();
				if (generatedPasswords.Add(newPassword)) // Eğer şifre set'e eklendiyse, yani yeni ve benzersiz bir şifreyse
				{
					pass.AppendLine(newPassword);
				}
			}

			System.IO.File.WriteAllText("sifreler.txt", pass.ToString());
			MessageBox.Show("Şifreler sifreler.txt dosyasına kaydedildi!");
		}


		string RastgeleUret()
		{
			int toplam = Convert.ToInt32(txtCountChar.Text);
			Random rnd = new System.Random(unchecked((int)DateTime.Now.Ticks));
			string ret = "";
			for (int i = 0; i < toplam; i++)
			{
				if (chkSert.Checked)
					ret += randZorLetter(rnd);
				else
					ret += randLetter(rnd);
			}
			return ret;
		}
		const string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		const string lettersZor = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!#*+-/@[]_";
		char randLetter(Random rnd)
		{
			return letters[rnd.Next(letters.Length)];
		}

		char randZorLetter(Random rnd)
		{
			return lettersZor[rnd.Next(lettersZor.Length)];
		}

		private void txtCountChar_KeyPress(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;

			if (!Char.IsDigit(ch) && ch != 8)
			{
				e.Handled = true;
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.ExitThread();
		}
	}
}
