using Microsoft.AspNetCore.Http.Connections.Client;
using Microsoft.AspNetCore.SignalR.Client;

public class Program
{
	const String token =
				"eyJhbGciOiJSUzI1NiIsImtpZCI6IjE5RDYyMkU1OTA1NjJCMDg3NkY0MTA5NUQ1MjQ3QTQxIiwidHlwIjoiYXQrand0In0.eyJuYmYiOjE2NTM0NDMxOTgsImV4cCI6MTY4NDk3OTE5OCwiaXNzIjoiaHR0cDovL29hdXRoLmx4a2luZy5jbiIsImF1ZCI6IkFuZ3VsYXIiLCJjbGllbnRfaWQiOiJBbmd1bGFyX0FwcCIsInN1YiI6IjNhMDJhMmY2LWI3OTEtM2QxMC00MjNlLWQ2NTNiMjdjZDBjNiIsImF1dGhfdGltZSI6MTY1MzQ0MzE5OCwiaWRwIjoibG9jYWwiLCJyb2xlIjoiYWRtaW4iLCJwaG9uZV9udW1iZXJfdmVyaWZpZWQiOiJGYWxzZSIsImVtYWlsIjoiYWRtaW5AYWJwLmlvIiwiZW1haWxfdmVyaWZpZWQiOiJGYWxzZSIsIm5hbWUiOiJhZG1pbiIsImlhdCI6MTY1MzQ0MzE5OCwic2NvcGUiOlsiQW5ndWxhciIsIm9wZW5pZCIsIm9mZmxpbmVfYWNjZXNzIl0sImFtciI6WyJwd2QiXX0.mVZiPBWCCws67_luJ0Vn7hAr9TRGm0IhpV1GeTO4RTB7xCpzEyAZ8gxkMRaNQhM2CV51-JJHpS3jQVy2vvr2mfGhLKwaLeLFeagr9l3X_sBY314aKFxwJOuAfgsVNi6w0qTLitlBjSLpwWbXzfCLoZMI103JWdW26MWHxZLAjmAOHY9xZZ6pjJxOpkOPzZkcwL5aw9nsTTkDY25dR4LkpSDf0xWgJlcd82jCclNsoY0gsKTz-rkxI2X9odMMAXTRHDzyDH1wAQ3o0t6HlogpSHOfgX9IvnMNDvqlteaqPZa_nvECwvowbXWvRw5BQXz93shjGnmDDnFsc-VaVQGAyQ";
	const String url = "http://oauth.lxking.cn/chat-test-hub";
	const String targetUserId = "3a02a2f6-b791-3d10-423e-d653b27cd0c6";

	public static void Main(string[] args)
	{
		HubConnection _connection = new HubConnectionBuilder().WithUrl(url, options =>
		{
			options.AccessTokenProvider = () => Task.Run<string?>(() => token);
		}
		).Build();

		_connection.StartAsync().Wait();

		_connection.On("ReceiveMessage", (string message) =>
		{
			Console.WriteLine(message);
		});

		_connection.InvokeAsync("SendMessage", targetUserId, "Hello World!").Wait();
		Console.Read();
		// _connection.StopAsync().Wait();
	}
}