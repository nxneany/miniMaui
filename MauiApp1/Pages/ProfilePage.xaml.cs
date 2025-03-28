using MauiApp1.Pages;

namespace MauiApp1.Pages
{
    public partial class ProfilePage : ContentPage
    {
        // Constructor
        public ProfilePage(object user)
        {
            InitializeComponent();
            BindingContext = user;
        }

        // Event handler for the Register button click
        private async void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            // Navigate to the CourseRegistrationPage when the button is clicked
            await Navigation.PushAsync(new CourseRegistrationPage());
        }
    }
}
