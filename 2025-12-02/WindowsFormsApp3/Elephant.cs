using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
	class Elephant
	{
		public int EarSize; // 귀 사이즈
		public String Name; // 이름 

		public void WhoAmI()
		{
			MessageBox.Show("My ears are " + EarSize + " inches tall.",
				Name + " says...");
		}
	}
}
