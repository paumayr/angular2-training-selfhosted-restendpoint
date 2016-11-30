using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using Microsoft.Owin.Hosting;

namespace angular2_training_selfhosted_restendpoint
{
	public class Program
	{
		static void Main()
		{
			string baseAddress = "http://localhost:9000/";

			// Start OWIN host 
			using (WebApp.Start<Startup>(url: baseAddress))
			{
				Console.ReadLine();
			}

		}
	}
}