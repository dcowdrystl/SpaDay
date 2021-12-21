using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }

        [HttpPost]
        /*[Route("/user/add")]*/
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Add", addUserViewModel);
            }
            
            User user = new User()
            {
                Username = addUserViewModel.UserName,
                Email = addUserViewModel.Email,
                Password = addUserViewModel.Password
            };
            return View("Index", user);
        }
    }
}