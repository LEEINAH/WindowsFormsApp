using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		int startingMileage; // 출발 시 주행거리
		int endingMileage; // 도착 시 주행거리
		double milesTraveled; // 이동거리
		double reimburseRate = .39; // 거리 당 환급액
		double amountOwed; // 환급총액
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			startingMileage = (int)numericUpDown1.Value; // 출발 시 주행거리 가져옴
			endingMileage = (int)numericUpDown2.Value; // 도착 시 주행거리 가져옴

			if (startingMileage < endingMileage) // 출발 시 주행거리가 도착 시 주행거리 보다 작으면 코드 실행
			{
				milesTraveled = endingMileage - startingMileage; // 이동 거리 계산
				amountOwed = milesTraveled * reimburseRate; // 환급총액 계산
				label4.Text = "$" + amountOwed; 
			} else
			{
				MessageBox.Show(
					"The starting mileage must be less than the ending mileage",
					"Cannot Calculate Mileage");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show(milesTraveled + " miles", "Miles Traveled");
		}
	}
}
