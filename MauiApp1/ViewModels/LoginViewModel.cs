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

		private List<UserModel> users;

		public LoginViewModel()
		{
			LoadUsersFromJson();
		}

		// อ่านข้อมูลจากไฟล์ JSON
		private void LoadUsersFromJson()
		{
			// กำหนดตำแหน่งไฟล์ user.json ในโฟลเดอร์ LocalApplicationData
			var jsonFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "user.json");

			// ตรวจสอบว่าไฟล์ user.json มีอยู่หรือไม่
			if (File.Exists(jsonFilePath))
			{
				// อ่านข้อมูลจากไฟล์ JSON
				var json = File.ReadAllText(jsonFilePath);

				// แปลงข้อมูล JSON เป็น List ของ UserModel
				users = JsonConvert.DeserializeObject<List<UserModel>>(json);
			}
			else
			{
				// หากไม่พบไฟล์, ให้สร้าง List ที่ว่างไว้
				users = new List<UserModel>();
			}
		}


		// ฟังก์ชันตรวจสอบล็อกอิน
		public async Task<bool> ValidateLoginAsync()
		{
			if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
			{
				return false; // ถ้าอีเมลหรือรหัสผ่านว่าง ให้ return false
			}

			// ตรวจสอบว่าอีเมลและรหัสผ่านที่กรอกตรงกับข้อมูลในระบบหรือไม่
			var user = users?.FirstOrDefault(u => u.Email == Email && u.Password == Password);

			if (user != null)
			{
				LoggedInUser = user; // เก็บข้อมูลผู้ใช้ที่ล็อกอินสำเร็จ
				return true; // ล็อกอินสำเร็จ
			}

			return false; // ล็อกอินล้มเหลว
		}
	}
}
