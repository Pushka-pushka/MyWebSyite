using Microsoft.AspNetCore.Mvc;
using MyWebSyite.ViewModel;


namespace MyWebSyite.Controllers
{
    public class RazortestController : Controller
    {
        public IActionResult Index()
        {
            Person person = new Person()
            {
                FirstName = "Alex",
                LastName = "Leb",
                Age = 38
            };

            Person user = new Person()
            {
                FirstName = "Bob",
                LastName = "Dilan",
                Age = 10

            };

            return View(user);
        }
        public IActionResult List()
        {
            var people = new Person[]
            {
                new Person() { FirstName = "Erik", LastName = "Jonson", Age = 18 },
                new Person() { FirstName = "Robert", LastName = "popov", Age = 16 },
                new Person() { FirstName = "elizabeth", LastName = "Ronsons", Age = 35 },
            };
            return View(people);
        }
    }
}
