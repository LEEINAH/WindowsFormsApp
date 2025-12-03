using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
	class Worker : Bee
	{
		// 생성자에서는 문자열 배열인 jobsICanDo 필드만 설정하면 된다. 
		// 이 필드는 private 필드인데, 여왕벌이 각 일벌이 어떤 일을 할 수 있는지
		// 일일이 확인하지 않고 바로 일을 시키기만 하면 되게 할 계획이므로 이렇게 함.
		public Worker(string[] jobsICanDo, double weightMg) 
			: base(weightMg)
		{
			this.jobsICanDo = jobsICanDo;
		}

		const double honeyRnitsPerShiftWorked = .65;

		// Worker 클래스는 HoneyconsumptionRate() 메서드를 오버라이드한다.
		// 현재 일하고 있는 벌의 꿀 소비량을 추가로 더함.
		public override double HoneyConsumptionRate()
		{
			double consumption = base.HoneyConsumptionRate();
			consumption += shiftsWorked * honeyRnitsPerShiftWorked;
			return consumption;
		}

		// ShiftsLeft는 읽기 전용 속성으로, 지금 하고 있는 일을 몇 시간 단위만큼 더 해야 하는지 계산해서 알려줌.
		public int ShiftsLeft
		{
			get
			{
				return shiftsToWork - shiftsWorked;
			}
		}

		// CurrentJob은 어떤 일을 하고 있는지 여왕벌에게 알려주기 위한 읽기 전용 속성.
		private string currentJob = "";
		public string CurrentJob
		{
			get
			{
				return currentJob;
			}
		}

		private string[] jobsICanDo;
		private int shiftsToWork;
		private int shiftsWorked;

		// 여왕벌은 일벌의 DoThisJob()을 호출해 할 일을 알려준다.
		// 일벌은 jobsICanDo 필드로 그 일을 할 수 있는지 확인해 본다.
		public bool DoThisJob(string job, int numberOfshifts)
		{
			if (!String.IsNullOrEmpty(currentJob))
				return false;
			for (int i = 0; i < jobsICanDo.Length; i++)
				if (jobsICanDo[i] == job)
				{
					currentJob = job;
					this.shiftsToWork = numberOfshifts;
					shiftsWorked = 0;
					return true;
				}
			return false;
		}

		// 여왕벌은 일벌의 WorkOneShift() 메서드를 호출해서 다음 시간 단위에 할 일을 처리하라는 지시를 내린다.
		// 이 메서드에서는 이 일이 지금 하고 있는 일의 마지막 시간 단위 분량인 경우에만 true를 반환한다.
		// 이렇게 하면 여왕벌 객체에서는 업무 보고서에 이번 시간 단위만 마치면 그 일벌은 할 일을 모두 마친다는 내용을 추가할 수 있다.
		public bool DidYouFinish()
		{
			if (String.IsNullOrEmpty(currentJob))
				return false;
			shiftsWorked++;
			if (shiftsWorked > shiftsToWork) 
			{
				shiftsWorked = 0;
				shiftsToWork = 0;
				currentJob = "";
				return true;
			}
			else
				return false;
		}
	}
}
