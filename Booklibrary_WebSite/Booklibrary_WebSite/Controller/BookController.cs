﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booklibrary_WebSite.Controllerz
{
    public class BookController : Controller
    {
        public string  GetAllBooks()
        {
            return "All Books";
        }
        public string GetBook(int id)
        {
            return "All Books "+id;
        }

    }
}
