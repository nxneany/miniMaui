using Newtonsoft.Json;
using System.Collections.Generic;
using MauiApp1.Models;

namespace MauiApp1.Services
{
	public static class JsonDataService
	{
		public static List<UserModel> GetUsersFromJson(string json)
		{
			return JsonConvert.DeserializeObject<List<UserModel>>(json);
		}
	}
}
