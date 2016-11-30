using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace angular2_training_selfhosted_restendpoint.Models
{
	public class Junkie
	{
		[JsonProperty(PropertyName = "id")]
		public int? Id { get; set; }

		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		[JsonProperty(PropertyName = "consumptions")]
		public int Consumptions { get; set; }

		[JsonProperty(PropertyName = "balance")]
		public decimal Balance { get; set; }
	}
}