using MauiApp1.Pages;
using Microsoft.Maui.Controls;

namespace MauiApp1
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			MainPage = new NavigationPage(new LoginPage()); // ใช้ NavigationPage
		}
	}
}
