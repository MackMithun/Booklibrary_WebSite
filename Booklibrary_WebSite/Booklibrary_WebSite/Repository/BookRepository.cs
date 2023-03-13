using Booklibrary_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booklibrary_WebSite.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetAllBooks(int id)
        {
            return DataSource().Where(x=>x.Id==id).FirstOrDefault();
        }
        public List<BookModel> searchbook(string title,string authorName)
        {
            return DataSource().Where(x=>x.Title==title && x.Author==authorName).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="MVC",Author="mithun singh"},
                new BookModel(){Id=2,Title="Web Form",Author="Abhay Gupta"},
                new BookModel(){Id=3,Title="java",Author="sagar vats"},
                new BookModel(){Id=4,Title="Python",Author="Rahul"},
                new BookModel(){Id=5,Title="PHP",Author="Ashu"}
            };
        }
    }
}
