using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.ViewModels
{
    public class CreateThreadViewModel
    {
        public int CategoryId { get; set; }

        public string Title { get; set; }

        public string Keywords { get; set; }

        public string Content { get; set; }
    }
}