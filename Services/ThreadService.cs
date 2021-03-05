using Forum.Exceptions;
using Forum.Models;
using Forum.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Services
{
    public class ThreadService
    {
        public Kategoria GetCategory(int id) {

            using (ApplicationDbContext db = new ApplicationDbContext()) {
                return db.Kategorie.Where(w => w.Id == id).FirstOrDefault();
            }

        }

        public int Create(CreateThreadViewModel model) {

            using (ApplicationDbContext db = new ApplicationDbContext()) {

                Kategoria category = db.Kategorie.Where(w => w.Id == model.CategoryId).FirstOrDefault();

                if (category == null)
                    throw new NoCategoryException();

                Watek newThread = new Watek() { 
                    Tytul = model.Title,
                    SlowaKluczowe = model.Keywords,
                    Aktywny = true,
                    DataDodania = DateTime.Now,
                    Grafika = "",
                    IdKategorii = category.Id,
                    IdUzytkownika = "123"//HttpContext.Current.User.Identity.Name
                };

                db.Watki.Add(newThread);

                if (db.SaveChanges() > 0) {

                    Post newPost = new Post() {
                        IdWatku = newThread.Id,
                        Tresc = model.Content,
                        DataDodania = DateTime.Now,
                        IdUzytkownika = HttpContext.Current.User.Identity.Name
                    };

                    db.Posty.Add(newPost);

                    if (db.SaveChanges() > 0)
                        return newThread.Id;
                }

                throw new CouldntCreateThread();
            }

        }

    }
}