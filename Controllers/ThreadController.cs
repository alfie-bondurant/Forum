using Forum.Exceptions;
using Forum.Services;
using Forum.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forum.Controllers
{
    public class ThreadController : Controller
    {

        ThreadService threadService = new ThreadService();
        
        public ActionResult Add(int id)
        {
            return View(threadService.GetCategory(id));
        }

        public ActionResult Create(CreateThreadViewModel model) {
            try
            {
                return RedirectToAction("Preview", new { id = threadService.Create(model) });
            }
            catch (NoCategoryException e)
            {
                return View("NoCategory");
            }
            catch (CouldntCreateThread e) { 
            
            }

            return RedirectToAction("Index", "Home",new { });
        }

        public ActionResult Preview(int id) {
            return View();
        }

    }
}