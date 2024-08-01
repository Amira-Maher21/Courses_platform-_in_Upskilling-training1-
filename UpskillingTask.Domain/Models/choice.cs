using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingTask.Domain.Models
{
	public class choice
	{
		public int ChoiceId { get; set; }
		public string ChoiceText { get; set; }
		public bool IsCorrect { get; set; }
		public int QuestionId { get; set; }
		public Question Question { get; set; }


	}
}
