using System.Net.Http;
using System.Net.Http.Headers;

namespace HttpRequest
{
	class Program
	{
		private static readonly HttpClient client = new HttpClient();

		private static async Task ProcessRepositories()
		{
			const string url = "http://220.165.143.74:8001/api/PhoneNumber/CheckIsRegister?phoneNumber=13698798707";
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Add("Accept", "application/json");
			client.DefaultRequestHeaders.Add("Authorization", "null");			
			HttpResponseMessage response = await client.SendAsync(new HttpRequestMessage(HttpMethod.Post, url));
			Console.Write(response.Content);
		}

		static async Task Main(string[] args)
		{
			await ProcessRepositories();
		}
	}
}