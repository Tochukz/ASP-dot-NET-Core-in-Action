using Microsoft.AspNetCore.Mvc;

namespace learning_middleware.Controllers
{
    public class ErrorController: Controller
    {
        public ViewResult Error()
        {
            return View();
        }
        
    }
}