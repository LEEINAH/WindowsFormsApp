using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
	class Stats
	{
		public int Total = 0;
		public int Missed = 0;
		public int Correct = 0;
		public int Accuracy = 0;

		public void Update(bool correctKey)
		{
			Total++;

			if (!correctKey)
			{
				Missed++;
			}
			else
			{
				Correct++;
			}
			Accuracy = 100 * Correct / (Missed + Correct);
			// Update() 메서드가 호출될 때마다, 정확도를 %로 재계산하고 Accuracy 필드에서 그 값을 보여 준다.
		}
	}
}
