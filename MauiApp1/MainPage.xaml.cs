using Microsoft.Maui.Controls;

namespace MauiApp1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		// ฟังก์ชันที่เรียกใช้เมื่อปุ่มถูกคลิก
		private void OnCounterClicked(object sender, EventArgs e)
		{
			// เพิ่มโค้ดที่ต้องการทำเมื่อคลิกปุ่ม
			// ตัวอย่างเช่นเพิ่มข้อความ
			DisplayAlert("Button Clicked", "You clicked the button!", "OK");
		}
	}
}
