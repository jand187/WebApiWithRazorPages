using System;
using System.Net.Http;
using Microsoft.Owin.Hosting;

namespace SelfHost
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var baseAddress = "http://localhost:9000/";

			using (WebApp.Start<Startup>(url: baseAddress))
			{
				var client = new HttpClient();

				client.GetAsync(baseAddress + "/api/values");
				Console.ReadLine();
			}
		}
	}
}
