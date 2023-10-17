using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtiqaCDN.Controllers.Web
{
	public class FreelancerController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
