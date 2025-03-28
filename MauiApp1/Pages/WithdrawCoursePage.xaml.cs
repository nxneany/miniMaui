using Microsoft.Maui.Controls;

namespace MauiApp1
{
	public partial class WithdrawCoursePage : ContentPage
	{
		public WithdrawCoursePage()
		{
			InitializeComponent();
		}

		private async void OnWithdrawCourseClicked(object sender, EventArgs e)
		{
			var course = (sender as Button)?.Text;
			await DisplayAlert("Course Withdrawn", $"{course} has been withdrawn", "OK");
		}
	}
}
