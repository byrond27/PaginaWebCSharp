/*
 * Created by SharpDevelop.
 * User: Sercop-Admin
 * Date: 17/01/2018
 * Time: 12:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Web.Mvc;

namespace PaginaWebCSharp.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
		
		public ActionResult Contact()
		{
			return View();
		}
	}
}
