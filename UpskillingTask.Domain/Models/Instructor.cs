using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingTask.Domain.Models
{
	public class Instructor
	{
		public int InstructorId { get; set; }

 		public string Name { get; set; }
		public ICollection<Course> Courses { get; set; }
		public ICollection<Question> Questions { get; set; }
	}
}
