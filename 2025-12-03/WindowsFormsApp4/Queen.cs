using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
	class Queen : Bee
	{
		public Queen(Worker[] workers, double weightMg)
			: base(weightMg)
		{
			this.workers = workers;
		}

		// 여왕벌 클래스에서는 일벌들이 저장된 배열을 비공개로 설정한다.
		// 한 번 그 배열을 설정하면 다른 클래스에서는 바꾸거나 볼 수도 없어야 하니까.
		// 일벌들에게 지시를 내릴 수 있는 건 여왕벌뿐이다. 이 필드 값은 생성자에서 설정한다.
		private Worker[] workers;
		private int shiftNumber = 0;

		public bool AssignWork(string job, int numberOfShifts)
		{
			for (int i = 0; i < workers.Length; i++) 
				if (workers[i].DoThisJob(job, numberOfShifts)) 
					// 여왕벌이 일벌한테 일을 시킬 때 우선 첫 번째 일벌한테 일을 시켜본다.
					// 일벌이 그 일을 할 수 없으면 그다음 일벌한테 일을 시켜보고,
					// 주어진 일을 할 수 있는 일벌이 나타나면 메서드는 종료됨.(이 때 반복문도 같이 종료)
					return true;
			return false;
		}

		public string WorkTheNextShift()
		{
			// 근무 시간의 꿀 소비량 계산은 현재 여왕벌의 꿀 소비량으로 시작한다.
			double honeyConsumed = HoneyConsumptionRate();

			shiftNumber++;
			string report = "Report for shift #" + shiftNumber + "\r\n";
			// 여왕벌에 있는 WorkTheNextShift() 메서드에서는 각 일벌한테 한 시간 단위만큼
			// 일 하라는 지시를 내린 다음 각 일벌의 상태를 바탕으로 보고서를 작성한다.
			for (int i = 0; i < workers.Length; i++)
			{
				// 각 일벌들이 반복문을 돌며 이 메서드를 호출하면서, 일벌의 총 꿀 소비량을 계산한다.
				honeyConsumed += workers[i].HoneyConsumptionRate();

				if (workers[i].DidYouFinish())
					report += "Worker #" + (i + 1) + " finished the job\r\n";
				if (String.IsNullOrEmpty(workers[i].CurrentJob))
					report += "Worker #" + (i + 1) + " is not working\r\n";
				else
					if (workers[i].ShiftsLeft > 0)
					report += "Worker #" + (i + 1) + " is doing '" + workers[i].CurrentJob
						+ "' for " + workers[i].ShiftsLeft + " more shifts\r\n";
					else
						report += "Worker #" + (i + 1) + " will be done with '"
							+ workers[i].CurrentJob + "' after this shift\r\n";
			}
			// 각 꿀벌들이 보고서를 한 줄 작성한다.
			// 그 후 여왕은 마지막 줄에 근무 시간 동안 소비한 총 꿀량을 작성한다.
			report += "Total honey consumed for the shift: " + honeyConsumed + " units\r\n";

			return report;
		}
	}
}
