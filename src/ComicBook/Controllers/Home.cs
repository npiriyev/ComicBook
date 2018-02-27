using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBook.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            var content = new ContentResult();
           
            return "Hi there from Home";
        }

    }
}