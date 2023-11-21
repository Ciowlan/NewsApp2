using NewsApp.Models;
using Newtonsoft.Json;

namespace NewsApp.Services
{ 
	public class ApiService
	{
		public async Task<Root> GetNews(string categoryName)
		{
			var httpClient = new HttpClient();
			var response = await httpClient.GetStringAsync($"https://gnews.io/api/v4/top-headlines?category={categoryName.ToLower()}&apikey=4279223382b397f9c72ff728beb84143&lang=zh");
            return JsonConvert.DeserializeObject<Root>(response);
		}
	}

}


	