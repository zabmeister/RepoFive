using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Subscriber.Mvc.Controllers
{
    public class SubscriberController : Controller
    {
        public ActionResult Index()
        {
            return new ContentResult { Content = "Hello world" };
        }
    }
}
