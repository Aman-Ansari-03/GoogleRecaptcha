using Microsoft.AspNetCore.Mvc;
using RecaptchaV3.Extensions;
using RecaptchaV3.Models;
using RecaptchaV3.Services;
using System.Diagnostics;

namespace RecaptchaV3.Controllers
{
    //my name is aman asnari
    public class HomeController : Controller
    {
        private IRecaptchaExtension _recaptcha;
        public HomeController(IRecaptchaExtension recaptcha)
        {
            _recaptcha = recaptcha;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            if (ModelState.IsValid && UserService.IsValid(user))
            {
                return RedirectToAction("Welcome", "Home");
            }
            return View();
        }

        public IActionResult Welcome()
        {
            ViewData["Message"] = $"You are online now! Date:{DateTime.Now.ToShortTimeString()}";
            return View();
        }
        public IActionResult Error()
        {
            ViewBag.ErrorMessage = "There is an error!";
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> VerifyToken(string token)
        {
            var verified = await _recaptcha.VerifyRecaptchaTokenAsync(token);

            return Json(verified);
        }
    }
}
