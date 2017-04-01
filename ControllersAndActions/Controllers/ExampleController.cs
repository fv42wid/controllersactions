using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public VirtualFileResult Index() =>
            File("/lib/bootstrap/dist/css/boostrap.css", "text/css");

        public ViewResult Result() => View((object)"Hello World");

        public RedirectToActionResult Redirect() =>
            RedirectToAction("Index");
    }
}
