using Azure.Core.Extensions;
using CVSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace CVSite.Controllers
{
	public class AdminController : Controller
	{
		private readonly Context c;
		public AdminController(Context context)
		{
			c = context;
		}

		public IActionResult Index()
		{
			var values = c.Abouts.ToList();
			return View(values);
		}
		public IActionResult UserGet(int id)
		{
			var bl = c.Abouts.Find(id);
			return View("UserGet", bl);
		}
		public IActionResult UserUpdate(About a)
		{
			var upt = c.Abouts.Find(a.ID);
			upt.Name = a.Name;
			upt.Surname = a.Surname;
			upt.Address = a.Address;
			upt.Note = a.Note;
			upt.Phone = a.Phone;
			upt.Photo = a.Photo;
			c.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult ConferancesInf()
		{
			var values = c.Conferancess.ToList();
			return View(values);
		}
		public IActionResult ConferancesGet(int id)
		{
			var fnd = c.Conferancess.Find(id);
			return View("ConferancesGet", fnd);
		}
		public IActionResult ConferancesUpdate(Conferance cnf)
		{
			var fnd = c.Conferancess.Find(cnf.ID);
			fnd.Conferances = cnf.Conferances;
			c.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult ConferancesDelete(int id)
		{
			var fnd = c.Conferancess.Find(id);
			c.Conferancess.Remove(fnd);
			c.SaveChanges();
			return RedirectToAction("ConferancesInf");
		}
		public IActionResult EducationInf()
		{
			var values = c.Educations.ToList();
			return View(values);
		}
		public IActionResult EducationGet(int id)
		{
			var fnd = c.Educations.Find(id);
			return View("EducationGet", fnd);
		}
		public IActionResult EducationUpdate(Education edc)
		{
			var fnd = c.Educations.Find(edc.ID);
			fnd.Title = edc.Title;
			fnd.SubTitle = edc.SubTitle;
			fnd.GNote = edc.GNote;
			fnd.Date = edc.Date;
			c.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult EducationDelete(int id)
		{
			var fnd = c.Educations.Find(id);
			c.Educations.Remove(fnd);
			c.SaveChanges();
			return RedirectToAction("EducationInf");
		}
		public IActionResult ExperienceInf()
		{
			var values = c.Experiences.ToList();
			return View(values);
		}
		public IActionResult ExperienceGet(int id)
		{
			var fnd = c.Experiences.Find(id);
			return View("ExperienceGet", fnd);
		}
		public IActionResult ExperienceUpdate(Experience ex)
		{
			var fnd = c.Experiences.Find(ex.ID);
			fnd.Title = ex.Title;
			fnd.SubTitle = ex.SubTitle;
			fnd.Description = ex.Description;
			fnd.Date = ex.Date;
			c.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult ExperienceDelete(int id)
		{
			var fnd = c.Experiences.Find(id);
			c.Experiences.Remove(fnd);
			c.SaveChanges();
			return RedirectToAction("ExperienceInf");
		}
		public IActionResult HobbiesInf()
		{
			var values = c.Hobbiees.ToList();
			return View(values);
		}
		public IActionResult HobbiesGet(int id)
		{
			var fnd = c.Hobbiees.Find(id);
			return View("HobbiesGet", fnd);
		}
		public IActionResult HobbiesUpdate(Hobbies hbs)
		{
			var fnd = c.Hobbiees.Find(hbs.ID);
			fnd.Hobbie = hbs.Hobbie;
			c.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult HobbiesDelete(int id)
		{
			var fnd = c.Hobbiees.Find(id);
			c.Hobbiees.Remove(fnd);
			c.SaveChanges(); 
			return RedirectToAction("HobbiesInf");
		}
		public IActionResult SkillsInf()
		{
			var values = c.Skillls.ToList();
			return View(values);
		}
		public IActionResult SkillsGet(int id)
		{
			var fnd = c.Skillls.Find(id);
			return View("SkillsGet", fnd);
		}
		public IActionResult SkillsUpdate(Skills sl)
		{
			var fnd = c.Skillls.Find(sl.ID);
			fnd.Skill = sl.Skill;
			c.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult SkillsDelete(int id)
		{
			var fnd = c.Skillls.Find(id);
			c.Skillls.Remove(fnd);
			c.SaveChanges();
			return RedirectToAction("SkillsInf");
		}

		
	}
}
