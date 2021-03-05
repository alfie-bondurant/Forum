using Forum.Services;
using Forum.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forum.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            DashboardService dashboardService = new DashboardService();

            return View(new DashboardViewModel() {
                Kategorie = dashboardService.GetMostPopularCategories(),
                Watki = dashboardService.GetMostPopularPosts()
            });;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}