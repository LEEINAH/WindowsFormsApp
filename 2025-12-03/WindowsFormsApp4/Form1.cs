using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			workerBeeJob.SelectedIndex = 0; // ComboBox의 첫 번째 항목을 보여 주기 위한 설정
			Worker[] workers = new Worker[4];
			workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" }, 175);
			workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114);
			workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" }, 149);
			workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing",
						 "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" }, 155);
			queen = new Queen(workers, 275);
		}

		private Queen queen;

		// assignJob 버튼을 클릭하면 queen에 있는 AssignWork() 메서드를 호출해
		// 일벌한테 작업을 할당해 주고 그 일을 할 수 있는 일벌이 있는지 여부에 따라 메시지 상자로 결과를 알려준다.
		private void assignJob_Click(object sender, EventArgs e)
		{
			if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
				MessageBox.Show("No workers are available to do the job '"
					+ workerBeeJob.Text + "'", "The queen bee says...");
			else
				MessageBox.Show("The job '" + workerBeeJob.Text + "' will be done in "
					+ shifts.Value + " shifts", "The queen bee says...");
		}

		// nextShift 버튼을 클릭하면 여왕벌이 일벌들에게 다음 시간 단위 동안 할 일을 처리하라고 지시하고,
		// 보고서를 만들어서 텍스트상자에 출력한다.
		private void nextShift_Click(object sender, EventArgs e)
		{
			report.Text = queen.WorkTheNextShift();
		}
	}
}
