using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingTask.Domain.Models
{
	public class Question
	{
		public int QuestionId { get; set; }
		public string QuestionText { get; set; }
		public string DifficultyLevel { get; set; } // "Simple", "Medium", "Hard"

		//public QuestionLevel Level { get; set; }

		//public int InstructorId { get; set; }
		//public Instructor instructor { get; set; }

		public ICollection<choice> choices { get; set; }

		public ICollection<ExamQuestion> ExamQuestions { get; set; }
	}
}
