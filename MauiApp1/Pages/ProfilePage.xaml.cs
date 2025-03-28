using MauiApp1.Models;
using MauiApp1.ViewModels;
using Microsoft.Maui.Controls;

namespace MauiApp1.Pages
{
    public partial class ProfilePage : ContentPage
    {
        private ProfileViewModel _profileViewModel;

        // คอนสตรัคเตอร์ที่รับข้อมูล UserModel
        public ProfilePage(UserModel user)
        {
            InitializeComponent();
            _profileViewModel = new ProfileViewModel(user); // ส่งข้อมูลผู้ใช้ที่ล็อกอินไปยัง ProfileViewModel
            BindingContext = _profileViewModel; // ตั้งค่า BindingContext
        }
    }
}
