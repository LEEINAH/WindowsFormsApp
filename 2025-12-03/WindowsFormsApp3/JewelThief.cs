using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
	class JewelThief
	{
		private Jewels stolenJewels = null;
		public void ReturnContents(Jewels safeContents, Owner owner)
		{
			stolenJewels = safeContents;
			Console.WriteLine("I'm stealing the contents! " + stolenJewels.Sparkle());
		}
	}
}
