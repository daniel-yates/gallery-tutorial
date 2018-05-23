using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public string GameName { get; set; }
        public string DescriptionHtml { get; set; }
        public Developer[] Developers { get; set; }
        public bool Favourite { get; set; }
    }
}