using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingTask.Domain.Models
{
	public class Exam
	{

		public int ExamId { get; set; }
		public string Title { get; set; }
		public ExamType Type { get; set; }
		public int CourseId { get; set; }
		public Course Course { get; set; }

		public ICollection<ExamQuestion> ExamQuestions { get; set; }
		public ICollection<StudentExam> StudentExams { get; set; }
	}

}
