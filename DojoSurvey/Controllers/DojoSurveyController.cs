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
    }
}