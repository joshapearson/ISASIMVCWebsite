using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISASIMVCWebsite.Models;
using System.IO;

namespace ISASIMVCWebsite.Controllers
{
	public class HomeController : Controller
	{


		List<Society> Society = new List<Society>();
		List<Event> Event = new List<Event>();


		public ActionResult Index(int imageNumber)
		{
			return View();
		}

		public ActionResult GetMembers()
		{
			// retrieve all corporate members
			using (ApplicationDbContext context = new ApplicationDbContext())
			{


				var corporateMembers = context.CorporateMember.Select(cm => new
				{
					MemberNumber = cm.MemberNumber,
					Website = cm.Website,
					Name = cm.Name
				})
					.ToList();

				foreach (var file in Directory.GetFiles(Server.MapPath("~/Images/SponsorLogos")))
				{
					var memberNumber = Path.GetFileNameWithoutExtension(file);


					if (memberNumber.IndexOf('_') != -1)
					{
						memberNumber = memberNumber.Remove(memberNumber.IndexOf('_'));
					}

					var corporateMember = corporateMembers.Where(cm => cm.MemberNumber == memberNumber)
						.Select(cm => new
						{
							Website = cm.Website,
							Name = cm.Name
						})
						.FirstOrDefault();
					if (corporateMember == null)
						continue;

					if (corporateMember.Website.Contains("http://"))
					{

					}
					else
					{

					}
				}
			}

			return View();
				}
			}
		}