public class Course
{
	public string CourseName { get; set; }

	public string Status { get; set; }
}

public class User
{
	public string Sid { get; set; }
	public string Name { get; set; }
	public string Major { get; set; }
	public List<Course> Courses { get; set; }
}
