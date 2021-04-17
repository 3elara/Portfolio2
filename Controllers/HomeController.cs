using Microsoft.AspNetCore.Mvc;
namespace Porto2.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public ViewResult Index()
        {
            return View("Index");
        }
        [HttpGet]       //type of request
        [Route("projects")]     //associated route string (exclude the leading /)
        public ViewResult Projects()
        {
            return View("Projects");
        }
        [HttpGet]       //type of request
        [Route("contact")]     //associated route string (exclude the leading /)
        public ViewResult Contact()
        {
            return View("Contact");
        }
        // [HttpGet]       //type of request
        // [Route("projects")]     //associated route string (exclude the leading /)
        // public string Project()
        // {
        //     return "Expecto Projecto!";
        // }
        // [HttpGet]       //type of request
        // [Route("contact")]     //associated route string (exclude the leading /)
        // public string Contact()
        // {
        //     return "Call Me Maybe!";
        // }

    }
}