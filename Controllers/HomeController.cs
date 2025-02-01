using Microsoft.AspNetCore.Mvc;

namespace MyWebSyite.Controllers
{
    public class HomeController : Controller
    {
      public string Index( string id)
        {
            return  id;
        }
        public string list( string id )
        {
            return "return list";
        }
    }
}
