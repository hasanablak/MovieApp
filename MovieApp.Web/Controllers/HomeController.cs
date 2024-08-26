using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
using MovieApp.Web.Entity;
using MovieApp.Web.Models;
using System.Collections.Generic;

namespace MovieApp.Web.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
          

            return View();
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                // Model başarılı bir şekilde alındı, işlemleri yapabilirsiniz
                // Örneğin: veritabanına kaydetme, e-posta gönderme, vb.
                UserRepository.AddUser(model);

                var users = UserRepository.Users;
                // İşlem tamamlandığında yönlendirme veya geri dönme
                return RedirectToAction("Index");
            }

            // Model geçersizse tekrar formu döndür
            return View(model);
        }
    }
}
