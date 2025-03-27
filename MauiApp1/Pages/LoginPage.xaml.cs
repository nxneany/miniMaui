using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;  // เพิ่ม namespace สำหรับการใช้งาน DeviceInfo

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
			string email = emailEntry.Text;
			string password = passwordEntry.Text;

			// ตรวจสอบว่าแอปทำงานบน Windows (WinUI)
			if (DeviceInfo.Platform == DevicePlatform.WinUI)
			{
				// สามารถใช้ฟังก์ชันหรือ API ที่เฉพาะสำหรับ Windows (WinUI) ที่นี่
				Console.WriteLine("กำลังทำงานบน Windows (WinUI)");
			}

			if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(password))
			{
				// จำลองการเข้าสู่ระบบ (ไม่มีฐานข้อมูลจริง)
				if (email == "test@student.com" && password == "1234")
				{
					await Navigation.PushModalAsync(new ProfilePage());
				}
				else
				{
					await DisplayAlert("Login Failed", "Invalid email or password", "OK");
				}
			}
			else
			{
				await DisplayAlert("Error", "Please enter both email and password", "OK");
			}
		}
	}
}
