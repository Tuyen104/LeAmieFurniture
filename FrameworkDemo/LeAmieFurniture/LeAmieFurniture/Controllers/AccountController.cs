using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeAmieFurniture.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult MyAccount()
        {
            return View();
        }
    }
}