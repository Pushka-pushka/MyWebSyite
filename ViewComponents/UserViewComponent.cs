using Microsoft.AspNetCore.Mvc;
using MyWebSyite.ViewModel;

namespace MyWebSyite.ViewComponents
{
    public class UserViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = new UserModel()
            {
                IsLoggedIn = true,
                UserName = "ASSSYoou"
            };
            return View("User", model);
        }


    }
}