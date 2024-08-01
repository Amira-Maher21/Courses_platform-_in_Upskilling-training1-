using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingTask.Domain.Models
{
	public class StudentExam
	{
		public int ExamId { get; set; }
		public Exam Exam { get; set; }
		public int StudentId { get; set; }
		public User Student { get; set; }
		public double? Score { get; set; }
		 //public DateTime DateTaken { get; set; }
	}
}

