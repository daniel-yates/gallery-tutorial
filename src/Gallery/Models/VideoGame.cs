﻿namespace VideoGameGallery.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public string GameName { get; set; }
        public string DescriptionHtml { get; set; }
        public Developer[] Developers { get; set; }
        public bool Favourite { get; set; }

        public string DisplayText
        {
            get
            {
                return SeriesTitle + " - " + GameName;
            }
        }

        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-").ToLower() + "-" + GameName.Replace(" ", "-").Replace(":","").ToLower() + ".jpg";
            }
        }
    }
}