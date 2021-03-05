using Forum.Exceptions;
using Forum.Models;
using Forum.Services;
using Forum.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forum.Controllers
{
    //[Authorize]
    public class CategoryController : Controller
    {

        CategoryService service = new CategoryService();

        // GET: Category
        public ActionResult Index()
        {
            return View(service.GetCategories());
        }

        public ActionResult Threads(int id) {

            ThreadsViewModel threads = null;

            try
            {
                threads = service.GetThreads(id);
            } catch (NoCategoryException e) {
                return View("NoCategory");
            }

            return View(threads);
        }

    }
}