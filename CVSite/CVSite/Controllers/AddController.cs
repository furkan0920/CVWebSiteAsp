using CVSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace CVSite.Controllers
{
	public class AddController : Controller
	{
		private readonly Context c;
		public AddController(Context context)
		{
			c = context;
		}
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public ActionResult NewExperience()
		{
			return View();
		}
		[HttpPost]
		public ActionResult NewExperience(Experience ex)
		{
			c.Experiences.Add(ex);
			c.SaveChanges();
			return RedirectToAction("ExperienceInf", "Admin");
		}

		[HttpGet]
		public ActionResult NewHobbies()
		{
			return View();
		}
		[HttpPost]
		public ActionResult NewHobbies(Hobbies hb)
		{
			c.Hobbiees.Add(hb);
			c.SaveChanges();
			return RedirectToAction("HobbiesInf", "Admin");
		}

		[HttpGet]
		public ActionResult NewSkills()
		{
			return View();
		}
		[HttpPost]
		public ActionResult NewSkills(Skills sl)
		{
			c.Skillls.Add(sl);
			c.SaveChanges();
			return RedirectToAction("SkillsInf", "Admin");
		}

		[HttpGet]
		public ActionResult NewConferances()
		{
			return View();
		}
		[HttpPost]
		public ActionResult NewConferances(Conferance cf)
		{
			c.Conferancess.Add(cf);
			c.SaveChanges();
			return RedirectToAction("ConferancesInf", "Admin");
		}
		[HttpGet]
		public ActionResult NewEducation()
		{
			return View();
		}
		[HttpPost]
		public ActionResult NewEducation(Education edc)
		{
			c.Educations.Add(edc);
			c.SaveChanges();
			return RedirectToAction("EducationInf", "Admin");
		}
	}
}
