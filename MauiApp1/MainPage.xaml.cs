using Microsoft.Maui.Controls;

namespace MauiApp1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		// Event handler สำหรับคลิกปุ่ม
		private void OnCounterClicked(object sender, EventArgs e)
		{

			CounterBtn.Text = "Clicked!";
		}
	}
}
