using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using MauiApp1.Models;

namespace MauiApp1.ViewModels
{
	public class CourseRegistrationViewModel : BindableObject
	{
		public ObservableCollection<Course> Courses { get; set; }

		public ICommand RegisterCourseCommand { get; set; }

		public CourseRegistrationViewModel()
		{
			// Example data
			Courses = new ObservableCollection<Course>
			{
				new Course { CourseName = "Math 101" },
				new Course { CourseName = "Science 101" }
			};

			// Command that gets executed when the button is clicked
			RegisterCourseCommand = new Command<Course>(RegisterCourse);
		}

		private void RegisterCourse(Course course)
		{
			// Logic to register the course
			// You can show a message or handle registration logic here
			Application.Current.MainPage.DisplayAlert("Registered", $"You have registered for {course.CourseName}", "OK");
		}
	}

	public class Course
	{
		public string CourseName { get; set; }
	}
}
