using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web.railgun.com.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public void Index()
        {
           Response.Redirect("https://railgunit.geckoboard.com/dashboards/623CF019653E3E4E");
        }

        public void Demo1()
        {
            Response.Redirect("https://railgunit.geckoboard.com/dashboards/623CF019653E3E4E");
        }
        public void Demo2()
        {
            Response.Redirect("https://railgunit.geckoboard.com/dashboards/623CF019653E3E4E");
        }
    }
}