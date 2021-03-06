﻿using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models.ViewModels;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IBookRepository _repository;

        public int PageSize = 5;

        //Passing in the Book repository to the constructor
        public HomeController(ILogger<HomeController> logger, IBookRepository repository)
        {
            _logger = logger;
            _repository = repository;

        }

        //Creating the instances of the books and page info as we get to the page
        public IActionResult Index(string category, int pageNum = 1)
        {
            return View(new BookListViewModel
            {
                Books = _repository.Books
                        .Where(p => category == null || p.Category == category)
                        .OrderBy(p => p.BookId)
                        .Skip((pageNum - 1) * PageSize)
                        .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = pageNum,
                    BooksPerPage = PageSize,
                    //If category null then dispaly all books if not make to where number of pages category count
                    TotalNumBooks = category == null ?_repository.Books.Count() :
                        _repository.Books.Where(x => x.Category == category).Count()
                },
                CurrentCategory = category
            }) ;
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
