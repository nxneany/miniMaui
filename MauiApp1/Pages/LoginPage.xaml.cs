using Microsoft.Maui.Controls;

namespace MauiApp1.Pages
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		private async void OnLoginClicked(object sender, EventArgs e)
		{
			var email = EmailEntry.Text;
			var password = PasswordEntry.Text;

			// ข้อมูลจำลองผู้ใช้
			var user = new
			{
				Sid = "65011212241",
				Name = "อนัญญา กรโสภา",
				Email = "nune@gmail.com",
				Password = "1234",
				Year = 3,
				Major = "วิทยาการคอมพิวเตอร์",
				Courses = new[]
				{
			new { CourseId = "CS101", CourseName = "Programming Basics", Credits = 3, Status = "Enrolled" },
			new { CourseId = "CS202", CourseName = "Data Structures", Credits = 3, Status = "Completed" }
		}
			};

			// ตรวจสอบข้อมูลการเข้าสู่ระบบ
			if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
			{
				await DisplayAlert("Error", "Please enter both email and password", "OK");
			}
			else if (email == user.Email && password == user.Password)
			{
				// ถ้า login สำเร็จ ส่งข้อมูลผู้ใช้ไปยังหน้า ProfilePage
				await Navigation.PushAsync(new ProfilePage(user));
			}
			else
			{
				await DisplayAlert("Error", "Invalid email or password.", "OK");
			}
		}

	}
}
