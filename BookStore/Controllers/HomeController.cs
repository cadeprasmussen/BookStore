using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IBookRepository _repository;


        //Passing in the Book repository to the constructor
        public HomeController(ILogger<HomeController> logger, IBookRepository repository)
        {
            _logger = logger;
            _repository = repository;

        }

        public IActionResult Index()
        {
            return View(_repository.Books);
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Privacy(Book addBook)
        {
            if (ModelState.IsValid)
            {
                return View("Index", _repository.Books);
            }
            else
            {
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
