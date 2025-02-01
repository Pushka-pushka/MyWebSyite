using Microsoft.AspNetCore.Mvc;
using System.Globalization;


namespace MyWebSyite.Controllers
{   [Route("my/test")]
    public class TestController: Controller
    {

        


        [Route("show")]
        public string Index()
        {
            return "index test method";
        }

        [Route("detalis/{id}")]
        public String Details(string id)
        {
            return "ID Value = " +id;
        }
        [HttpPost]
        [Route("Login")]
        public string LoginSave()
        {
            return " фрма для входа  POST";
        }

        [HttpGet]
        [Route ("Login")]
        public string Login()
        {
            return "форма для входа GET";
        }

    }
}
