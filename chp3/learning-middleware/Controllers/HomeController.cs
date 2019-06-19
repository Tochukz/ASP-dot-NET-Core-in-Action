using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Diagnostics;

namespace learning_middleware.Controllers
{
    public class HomeController : Controller
    {
        /**
         * Return a String
         */
        public IActionResult Index()
        {
            return Content("<div style='text-align:center'><img src='/img/welcome-page.jpg' alt='Welcome Page'/></div>", "text/html");
        }

        public ViewResult testpage()
        {
            return View("~/Views/Home/about.cshtml");
        }
        /**
         * Simulate a 500 Error
         */
        public ActionResult MakeError()
        {
            int a = 10;
            int b = 0;
            int y = a / b;

            return Content("Created Exception Intentionally");
        }

        /**
         * Disable the StatusCodePagesMiddleware and issue 500
         */
        public IActionResult OffStatusPage()
        {
            var statusCodePagesFeature = HttpContext.Features.Get<IStatusCodePagesFeature>();
            if (statusCodePagesFeature != null)
            {
                statusCodePagesFeature.Enabled = false;
            }
            
            return StatusCode(500);
        }
    }

}