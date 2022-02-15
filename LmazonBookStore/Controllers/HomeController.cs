using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LmazonBookStore.Models;
using LmazonBookStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LmazonBookStore.Controllers
{
    public class HomeController : Controller
    {
        private IBookStoreRepository repo;

        public HomeController (IBookStoreRepository temp)
        {
            repo = temp;
        }

        // GET: /<controller>/
        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 10;

            var x = new BooksViewModel
            {
                Books = repo.Books
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = repo.Books.Count(),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            //// Add in SQL via Linq, then go to Index to change the List to IQueryable
            //var list = repo.Books
            //    .OrderBy(b => b.Title)
            //    //Skip as in .Skip(), Skip the first 5 
            //    .Skip((pageNum - 1) * pageSize)
            //    //number of result as in .Take() and show the next 5
            //    .Take(pageSize);

            return View(x);
        }
    }
}
