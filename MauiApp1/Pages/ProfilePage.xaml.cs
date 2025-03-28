using Microsoft.Maui.Controls;

namespace MauiApp1.Pages
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage(object user)
        {
            InitializeComponent();
            BindingContext = user;  // ใช้ข้อมูลที่ส่งมาจากหน้า LoginPage
        }
    }
}
