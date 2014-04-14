using System.Net.Http;
using System.Web.Http;
using RazorEngine;
using Encoding = System.Text.Encoding;

namespace Website.Api
{
	public class HomeController : ApiController
	{
		public HttpContent Index()
		{
			var template = "Hello @Model.Name! Welcome to Web API and Razor!";
			var result = Razor.Parse(template, new {Name = "World"});

			return new StringContent(result, Encoding.UTF8, "text/html");
		}
	}
}
