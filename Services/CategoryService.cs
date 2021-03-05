using Forum.Exceptions;
using Forum.Models;
using Forum.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Services
{
    public class CategoryService
    {
        public List<KategoriaViewModel> GetCategories()
        {

            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                return db.Kategorie.Where(w => w.Aktywna).OrderBy(o => o.Nazwa).Select(s => new KategoriaViewModel()
                {
                    Id = s.Id,
                    Nazwa = s.Nazwa,
                    IloscWatkow = s.Watki.Count
                }).ToList();
            }

        }

        public ThreadsViewModel GetThreads(int id) {

            ApplicationDbContext db = new ApplicationDbContext();//) {

                Kategoria category = db.Kategorie.Where(w => w.Id == id).FirstOrDefault();

                if (category != null) {
                    return new ThreadsViewModel()
                    {
                        CategoryId = category.Id,
                        CategoryName = category.Nazwa,
                        Threads = category.Watki.ToList()
                    };
                }

                throw new NoCategoryException();
            //}

        }

    }
}