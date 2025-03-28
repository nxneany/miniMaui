using MauiApp1.Models;
using MauiApp1.ViewModels;
using Microsoft.Maui.Controls;

namespace MauiApp1.Pages
{
	public partial class LoginPage : ContentPage
	{
		private LoginViewModel _viewModel;

		public LoginPage()
		{
			InitializeComponent();
			_viewModel = new LoginViewModel();
			BindingContext = _viewModel; // ตั้งค่า BindingContext ให้กับหน้า
		}

		// ฟังก์ชันเมื่อคลิกปุ่ม Login
		private async void OnLoginClicked(object sender, EventArgs e)
		{
			// ตรวจสอบการล็อกอินแบบ Asynchronous
			bool isValidLogin = await _viewModel.ValidateLoginAsync();

			if (isValidLogin)
			{
				// ถ้าล็อกอินสำเร็จ
				UserModel loggedInUser = new UserModel
				{
					Email = _viewModel.Email,  // กำหนดข้อมูลผู้ใช้ที่ล็อกอิน
											   // คุณสามารถเพิ่มข้อมูลอื่นๆ ที่ต้องการจาก ViewModel ที่นี่
				};

				await DisplayAlert("Login Successful", "Welcome!", "OK");

				// ไปยังหน้า Profile และส่งข้อมูลผู้ใช้ที่ล็อกอิน
				await Navigation.PushModalAsync(new ProfilePage(loggedInUser)); // ส่งข้อมูลผู้ใช้ไปที่หน้า Profile
			}
			else
			{
				// ถ้าล็อกอินล้มเหลว
				await DisplayAlert("Login Failed", "Invalid email or password", "OK");
			}
		}
	}
}
