using Forum.Models;
using Forum.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Services
{
    public class DashboardService
    {
        public List<KategoriaViewModel> GetMostPopularCategories() {

            using (ApplicationDbContext db = new ApplicationDbContext()) {
                return db.Kategorie.Where(w => w.Aktywna && w.Watki.Count > 0).OrderByDescending(o => o.Watki.Count).Take(5).Select(s=>new KategoriaViewModel() { 
                
                    Id = s.Id,
                    Nazwa = s.Nazwa,
                    DataUtworzenia = s.Watki.OrderBy(o=>o.DataDodania).FirstOrDefault().DataDodania
                
                }).ToList();

            }

        }

        internal List<Watek> GetMostPopularPosts()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                return db.Watki.Where(w => w.Kategoria.Aktywna).OrderByDescending(o => (o.Posty.FirstOrDefault() == null || o.Posty.Count==0) ? 0: o.Posty.FirstOrDefault().Oceny.Sum(s=>s.Wartosc)).Take(5).ToList();
            }
        }
    }
}