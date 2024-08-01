using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpskillingTask.Domain.Models;

namespace UpskillingTask.Repository.Data
{
	public class UpskTaskContext : DbContext
	{
		
    public DbSet<User> Users { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<Exam> exams { get; set; }
		public DbSet<Question> Questions { get; set; }
		public DbSet<choice> choices { get; set; }
		public DbSet<CourseStudent> courseStudents { get; set; }
		public DbSet<StudentExam> studentExams { get; set; }
		public DbSet<ExamQuestion> QuizQuestions { get; set; }
		public DbSet<ExamResult> examResults { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CourseStudent>()
			.HasKey(cs => new { cs.StudentId, cs.CourseId });
			modelBuilder.Entity<CourseStudent>()
				.HasOne(cs => cs.Student)
				.WithMany(s => s.courseStudents)
				.HasForeignKey(cs => cs.StudentId);
			modelBuilder.Entity<CourseStudent>()
				.HasOne(cs => cs.Course)
				.WithMany(c => c.CourseStudents)
				.HasForeignKey(cs => cs.CourseId);

			modelBuilder.Entity<StudentExam>()
				.HasKey(se => new { se.StudentId, se.ExamId });
			modelBuilder.Entity<StudentExam>()
				.HasOne(se => se.Student)
				.WithMany(s => s.studentExams)
				.HasForeignKey(se => se.StudentId);
			modelBuilder.Entity<StudentExam>()
				.HasOne(se => se.Exam)
				.WithMany(e => e.StudentExams)
				.HasForeignKey(se => se.ExamId);

			modelBuilder.Entity<ExamQuestion>()
				.HasKey(eq => new { eq.ExamId, eq.QuestionId });
			modelBuilder.Entity<ExamQuestion>()
				.HasOne(eq => eq.Exam)
				.WithMany(e => e.ExamQuestions)
				.HasForeignKey(eq => eq.ExamId);
			modelBuilder.Entity<ExamQuestion>()
				.HasOne(eq => eq.Question)
				.WithMany(q => q.ExamQuestions)
				.HasForeignKey(eq => eq.QuestionId);

			//modelBuilder.Entity<ExamResult>()
			//	.HasOne(er => er.studentExam)
			//	.WithMany()
			//	.HasForeignKey(er => er.StudentExamId);
		}
	}
}

