using System.Collections.Generic;
using System.Web.Http;

namespace SelfHost.Controllers
{
	public class ValuesController : ApiController
	{
		public IEnumerable<string> Get()
		{
			return new string[] { "pølle", "value2" };
		}

		// GET api/values/5 
		public string Get(int id)
		{
			return "pølle";
		}

		// POST api/values 
		public void Post([FromBody]string value)
		{
		}

		// PUT api/values/5 
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/values/5 
		public void Delete(int id)
		{
		} 
	}
}
