namespace MauiApp1.Models
{
	public class UserModel
	{
		public string Sid { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public int Year { get; set; }
		public string Major { get; set; }
		public List<Course> Courses { get; set; }
	}

	public class Course
	{
		public string CourseId { get; set; }
		public string CourseName { get; set; }
		public int Credits { get; set; }
		public string Status { get; set; }
	}
}
