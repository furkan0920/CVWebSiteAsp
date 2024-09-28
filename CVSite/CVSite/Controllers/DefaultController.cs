using CVSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace CVSite.Controllers
{
	public class DefaultController : Controller
	{
		private readonly Context c;
		public DefaultController(Context context) {
			c=context;
		}

		public IActionResult Index()
		{		
			var valuesSkillls = c.Skillls.ToList();
			var valuesAbouts = c.Abouts.ToList();
			var valuesConferancess = c.Conferancess.ToList();
			var valuesHobbiees = c.Hobbiees.ToList();
			var valuesExperiences = c.Experiences.ToList();
			var valuesEducations = c.Educations.ToList();

			var values = (valuesSkillls, valuesAbouts, valuesConferancess, valuesEducations, valuesExperiences, valuesHobbiees);
			return View(values);
		}
	}
}
