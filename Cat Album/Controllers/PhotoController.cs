using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cat_Album.Controllers
{
    public class PhotoController : Controller
    {
        // GET: Photo
        public string Index()
        {
            return "This is the index";
        }

        public string Welcome()
        {
            return "This is the welcome page";
        }
    }
}