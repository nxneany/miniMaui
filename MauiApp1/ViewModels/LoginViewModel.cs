using MauiApp1.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
	public class LoginViewModel
	{
		public string Email { get; set; }
		public string Password { get; set; }
		public UserModel LoggedInUser { get; private set; }

		// ฟังก์ชันอ่านข้อมูลจากไฟล์ JSON
		private List<UserModel> users;

		public LoginViewModel()
		{
			LoadUsersFromJson();
		}

		// อ่านข้อมูลจากไฟล์ JSON
		private void LoadUsersFromJson()
		{
			var jsonFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "user.json");
			if (File.Exists(jsonFilePath))
			{
				var json = File.ReadAllText(jsonFilePath);
				users = JsonConvert.DeserializeObject<List<UserModel>>(json);
			}
			else
			{
				users = new List<UserModel>(); // กรณีไม่พบไฟล์
			}
		}

		// ฟังก์ชันตรวจสอบล็อกอิน
		public async Task<bool> ValidateLoginAsync()
		{
			// ตรวจสอบว่าอีเมลและรหัสผ่านที่กรอกตรงกับข้อมูลในระบบหรือไม่
			var user = users.FirstOrDefault(u => u.Email == Email && u.Password == Password);

			if (user != null)
			{
				LoggedInUser = user; // เก็บข้อมูลผู้ใช้ที่ล็อกอินสำเร็จ
				return true; // ล็อกอินสำเร็จ
			}

			return false; // ล็อกอินล้มเหลว
		}
	}
}
