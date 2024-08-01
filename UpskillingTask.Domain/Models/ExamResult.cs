using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingTask.Domain.Models
{
	public class ExamResult
	{
		public int ExamResultId { get; set; }
		public int ExamId { get; set; }
		public StudentExam studentExam { get; set; }
		public double Score { get; set; }
	}
}
