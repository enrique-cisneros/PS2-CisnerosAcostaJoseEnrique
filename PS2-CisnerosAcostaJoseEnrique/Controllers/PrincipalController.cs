using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PS2_CisnerosAcostaJoseEnrique.Controllers
{
    public class PrincipalController : Controller
    {
        [Authorize]
        // GET: Principal
        public ActionResult Index()
        {
            return View();
        }
    }
}