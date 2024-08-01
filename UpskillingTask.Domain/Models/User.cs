using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingTask.Domain.Models
{
	public class User
	{
		public int UserId { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string Role { get; set; } // "Instructor" or "Student"

		public ICollection<Course> Courses { get; set; } // For instructors
		public ICollection<CourseStudent> courseStudents { get; set; } // For students
		public ICollection<StudentExam> studentExams { get; set; } // For students
	}
}

