using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
	public partial class Form1 : Form
	{
		Random random = new Random();
		Stats stats = new Stats();
		public Form1()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			// Add a random key to the ListBox
			listBox1.Items.Add((Keys)random.Next(65, 90));
			if (listBox1.Items.Count > 7)
			{
				listBox1.Items.Clear();
				listBox1.Items.Add("Game over");
				timer1.Stop();
			}
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			// 사용자가 ListBox에 있는 문자를 누를 때
			// 이를 제거한 후, 게임이 조금 더 빨라지게 한다.
			if (listBox1.Items.Contains(e.KeyCode))
			{
				listBox1.Items.Remove(e.KeyCode);
				listBox1.Refresh();
				if (timer1.Interval > 400) // 이 부분은 올바른 키 입력 횟수가 증가할수록 게임의 난이도가 증가하는 부분을 처리하는 코드.
					timer1.Interval -= 10; //
				if (timer1.Interval > 250) //
					timer1.Interval -= 7; //
				if (timer1.Interval > 100) //
					timer1.Interval -= 2; //
				difficultyProgressBar.Value = 800 - timer1.Interval;

				// 사용자가 올바른 키를 누르면
				// Update(true) 메서드를 호출해서 Stats 객체를 갱신한다.
				stats.Update(true);
			}
			else
			{
				// 사용자가 다른 키를 누르면 
				// Update(false) 메서드를 호출해서 Stats 객체를 갱신한다.
				stats.Update(false);
			}

			// StatusStrip 컨트롤의 레이블을 갱신한다.
			correctLabel.Text = "Correct: " + stats.Correct;
			missedLabel.Text = "Missed: " + stats.Missed;
			totalLabel.Text = "Total: " + stats.Total;
			accuracyLabel.Text = "Accuracy: " + stats.Accuracy + "%";
		}
	}
}
