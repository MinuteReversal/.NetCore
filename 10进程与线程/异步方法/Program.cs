/**
* https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1.result?view=netframework-4.8
*/
using System;
using System.Threading;
using System.Threading.Tasks;

namespace 异步方法
{
	class Program
	{
		static Task Fn1()
		{
			Console.WriteLine("Fn1");
			var tcs = new TaskCompletionSource<object>();

			var timer = new System.Timers.Timer(1000);
			timer.Elapsed += (s, e) =>
			{
				tcs.SetResult(null);
			};
			timer.AutoReset = false;
			timer.Start();

			return tcs.Task;
		}
		static Task Fn2(int x)
		{
			Console.WriteLine($"Fn{x}");
			var tcs = new TaskCompletionSource<object>();

			var timer = new System.Timers.Timer(1000);
			timer.Elapsed += (s, e) =>
			{
				tcs.SetResult(null);
			};
			timer.AutoReset = false;
			timer.Start();

			return tcs.Task;
		}
		static Task<int> Fn3()
		{
			Console.WriteLine($"Fn{3}");
			var tcs = new TaskCompletionSource<int>();
			var timer = new System.Timers.Timer(1000);
			timer.Elapsed += (s, e) =>
			{
				tcs.SetResult(3);
			};
			timer.AutoReset = false;
			timer.Start();
			return tcs.Task;
		}
		static Task<int> Fn4(int x)
		{
			Console.WriteLine($"Fn{x}");
			var tcs = new TaskCompletionSource<int>();
			var timer = new System.Timers.Timer(1000);
			timer.Elapsed += (s, e) =>
			{
				tcs.SetResult(x);
			};
			timer.AutoReset = false;
			timer.Start();
			return tcs.Task;
		}
		static Task Fn5()
		{
			Console.WriteLine($"Fn5");
			var tcs = new TaskCompletionSource<object>();
			tcs.SetException(new Exception("test"));
			return tcs.Task;
		}
		static async Task Main(string[] args)
		{
			await Fn1();
			await Fn2(2);
			int r1 = await Fn3();
			int r2 = await Fn4(4);
			try
			{
				await Fn5();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				Console.WriteLine("complete");
			}
			Console.WriteLine(r1);
			Console.WriteLine(r2);
		}
	}
}
