using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    public class DashboardController : Controller
    {
        [Authorize(Roles = "Admin")]
        public IActionResult Admin() => View();

        [Authorize(Roles = "Manager")]
        public IActionResult Manager() => View();

        [Authorize(Roles = "Customer")]
        public IActionResult Customer() => View();

        [Authorize(Roles = "User")]
        public IActionResult User() => View();
    }
}
