﻿using Library.Services.IRepository;
using Library.Utility;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace Library.Controllers
{
    public class BooksController : Controller
    {
        private readonly IUnitOfWork _iUnitOfWork;
        private readonly IWebHostEnvironment _host;

        public BooksController(IUnitOfWork iUnitOfWork, IWebHostEnvironment host)
        {
            _iUnitOfWork = iUnitOfWork;
            _host = host;
        }
        public IActionResult Index(int pageNumber = 1, int pageSize = 8)
        {
            var books = _iUnitOfWork.BookRepository.GetBooksWithAuthors().ToList();
            var result = PaginateResult.PageResults(books, pageNumber, pageSize);

            return View(result);
        }


        public IActionResult Data()
        {
            var applicationPath = Path.GetDirectoryName(Assembly.GetEntryAssembly()?.FullName);
            // var data = System.IO.File.ReadAllLines(applicationPath + @"\Data\userData.json");

            return View("Data", applicationPath);
        }

        
    }
}
