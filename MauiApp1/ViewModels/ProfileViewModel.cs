using MauiApp1.Models;

namespace MauiApp1.ViewModels
{
	public class ProfileViewModel
	{
		public UserModel User { get; private set; }

		public ProfileViewModel(UserModel user)
		{
			User = user;
		}
	}
}
