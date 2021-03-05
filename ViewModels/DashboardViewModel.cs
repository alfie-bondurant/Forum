using Forum.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.ViewModels
{
    public class DashboardViewModel
    {
        public List<KategoriaViewModel> Kategorie { get; set; }
        public List<Watek> Watki { get; set; }

    }
}