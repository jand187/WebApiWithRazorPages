using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHost.Controllers
{
	public class HomeController : ApiController
	{
		public HtmlActionResult Get(string view)
		{
			return new HtmlActionResult(view);
		}
	}

	public class HtmlActionResult : IHttpActionResult
	{
		private const string ViewDirectory = @"C:\Users\jda\Documents\Visual Studio 2013\Projects\SelfHost\SelfHost";
		private readonly string _view;

		public HtmlActionResult(string viewName)
		{
			_view = LoadView(viewName);
		}

		public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
		{
			var response = new HttpResponseMessage(HttpStatusCode.OK);
			response.Content = new StringContent(_view);
			response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
			return Task.FromResult(response);
		}

		private static string LoadView(string name)
		{
			var view = File.ReadAllText(Path.Combine(ViewDirectory, name));
			return view;
		}
	}
}
