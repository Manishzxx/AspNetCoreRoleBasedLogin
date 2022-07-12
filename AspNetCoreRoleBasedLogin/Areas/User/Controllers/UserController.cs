using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreRoleBasedLogin.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Policy = "UserPolicy")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
