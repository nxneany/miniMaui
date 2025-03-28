using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MauiApp1.Models
{
	public class UserModel
	{
		[JsonProperty("sid")]
		public string Sid { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("password")]
		public string Password { get; set; }

		[JsonProperty("year")]
		public long Year { get; set; }

		[JsonProperty("major")]
		public string Major { get; set; }

		[JsonProperty("courses")]
		public List<Course> Courses { get; set; }
	}

	public class Course
	{
		[JsonProperty("course_id")]
		public string CourseId { get; set; }

		[JsonProperty("course_name")]
		public string CourseName { get; set; }

		[JsonProperty("credits")]
		public long Credits { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }
	}
}
