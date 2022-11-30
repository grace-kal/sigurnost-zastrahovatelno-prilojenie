using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sigurnost_WebApp.Controllers
{
    public class PolicyController : Controller
    {
        public IActionResult GetMyPolicies()
        {
            return View();
        }
    }
}
