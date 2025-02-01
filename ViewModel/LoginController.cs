using Microsoft.AspNetCore.Mvc;
using MyWebSyite.ViewModel;

namespace MyWebSyite.ViewModel
{
    public class LoginController:Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Title = "GET-ЗАПРОС";
            return View(new LoginModel());
        }
        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            ViewBag.Title = "POST-Запрос";
            return View(model);
        }
    }
}
