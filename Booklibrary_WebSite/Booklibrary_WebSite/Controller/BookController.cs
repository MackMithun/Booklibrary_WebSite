using Booklibrary_WebSite.Models;
using Booklibrary_WebSite.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booklibrary_WebSite.Controllerz
{
    public class BookController : Controller
    {
        private readonly BookRepository _Book =null;
        public BookController()
        {
            _Book = new BookRepository();
        }
        public ViewResult  GetAllBooks()
        {
            var data = _Book.GetAllBooks();
            return View(data);
        }
        public ViewResult GetBook(int id)
        {
           var data =_Book.GetAllBookByID(id);
            return View(data);
        }

        public List<BookModel> SerachBook(string bookName,string AuthorName)
        {
            return _Book.searchbook(bookName, AuthorName);
        }
    }
}
