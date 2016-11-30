using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using angular2_training_selfhosted_restendpoint.Models;

namespace angular2_training_selfhosted_restendpoint.Controllers
{
    public class CoffeeListController : ApiController
    {
		public static List<Junkie> Junkies = new List<Junkie>(new[] {
			new Junkie() { Id = 0, Name = "Phil", Balance = 7.00m, Consumptions = 200 },
			new Junkie() { Id = 1, Name = "Klaus", Balance = 6.15m, Consumptions = 125 }
		});

        // GET: api/CoffeeList
        public IEnumerable<Junkie> Get()
        {
			return Junkies;
        }

        // GET: api/CoffeeList/5
        public IHttpActionResult Get(int id)
        {
			var junkie = Junkies.SingleOrDefault(x => x.Id == id);
			if (junkie != null)
			{
				return this.Ok(junkie);
			}

			return this.NotFound();
        }

        // POST: api/CoffeeList
        public IHttpActionResult Post([FromBody]Junkie value)
        {
			if (!this.ModelState.IsValid)
			{
				return this.BadRequest();
			}

			value.Id = Junkies.Count;
			Junkies.Add(value);
			return this.Ok();
        }

        // PUT: api/CoffeeList/5
        public IHttpActionResult Put(int id, [FromBody]Junkie value)
        {
			if (Junkies.Any(j => j.Id == value.Id))
			{
				Junkies = Junkies.Select(x => x.Id == value.Id ? value : x).ToList();
				return this.Ok();
			}

			return this.NotFound();
        }

        // DELETE: api/CoffeeList/5
        public IHttpActionResult Delete(int id)
        {
			if (Junkies.RemoveAll(x => x.Id == id) >= 1)
			{
				return this.Ok();
			}

			return this.NotFound();
        }
    }
}
