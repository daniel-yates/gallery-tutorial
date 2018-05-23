namespace Gallery.Controllers
{
    using Gallery.Models;
    using System;
    using System.Web.Mvc;

    public class ItemController : Controller
    {
        public ActionResult Detail()
        {
            var videoGame = new Item()
            {
                SeriesTitle = "Street Fighter",
                GameName = "Street Fighter 2: Champion Edition",
                DescriptionHtml = "<p>Street Fighter II: Champion Edition is a competitive fighting game released for the arcades by Capcom in 1992</p>",
                Developers = new Developer[]
                {
                    new Developer() { Role = "Producer", Name = "Yoshiki Okamoto" },
                    new Developer() { Role = "Designer", Name = "Akira Nishitani, Akira Yasuda" },
                    new Developer() { Role = "Composer", Name = "Isao Abe" }
                }
            };

            return View(videoGame);
        }
    }
}