using MauiApp1.Pages; // นำเข้า LoginPage

namespace MauiApp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new LoginPage()); // ให้แสดงหน้า Login ก่อน
	}

}
