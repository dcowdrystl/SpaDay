using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using System;
namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /*[HttpGet("/user/add")]*/
        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            ViewBag.userName = newUser.Username;
            ViewBag.eMail = newUser.Email;
            ViewBag.date = newUser.Date.ToLongDateString();

            if (newUser.Password == verify)
            {
                ViewBag.user = newUser;

                return View("Index");
            }
            else
            {
                ViewBag.error = "Passwords do not match! Try again!";


                return View("Add");
            }
        }

    }
}
