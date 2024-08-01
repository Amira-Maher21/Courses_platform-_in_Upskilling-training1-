using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingTask.Domain.Models
{
	public class CourseStudent
	{
		public int StudentId { get; set; }
		public User Student { get; set; }
		public int CourseId { get; set; }
		public Course Course { get; set; }
	}
}

