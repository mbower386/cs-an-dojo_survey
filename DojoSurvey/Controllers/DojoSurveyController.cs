using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class DojoSurveyController : Controller
    {
        // Index
        [HttpGet]
        [Route ("")]
        public ViewResult Index ()
        {
            return View ();
        }

        // remember to use [HttpPost] attributes!
        [HttpPost]
        [Route ("submit")]
        public IActionResult Submit (string inputName, string location, string language, string comment)
        {
            // Do something with form input
            ViewBag.name = inputName;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comment = comment;

            return View("Survey");
        }

    }
}