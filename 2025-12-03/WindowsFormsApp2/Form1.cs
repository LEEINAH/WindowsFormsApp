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
		Farmer farmer;
		public Form1()
		{
			InitializeComponent();
			farmer = new Farmer(15, 30);
		}

		private void calculate_Click(object sender, EventArgs e)
		{
			Console.WriteLine("I need {0} bags of feed for {1} cows", 
				farmer.BagsOfFeed, farmer.NumberOfCows);
			// {0} 자리에 첫 번째 매개변수를, {1} 자리에 두 번째 매개변수를 집어넣는다.
		}

		private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
		{
			farmer.NumberOfCows = (int)numericUpDown1.Value;
		}
	}
}
