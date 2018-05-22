namespace Gallery.Controllers
{
    using System;
    using System.Web.Mvc;

    public class ItemController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "Street Fighter";
            ViewBag.GameName = "Street Fighter 2: Champion Edition";
            ViewBag.Description = "<p>Street Fighter II: Champion Edition is a competitive fighting game released for the arcades by Capcom in 1992</p>";
            ViewBag.Developers = new string[]
            {
                "Producer(s): Yoshiki Okamoto",
                "Designer(s): Akira Nishitani, Akira Yasuda",
                "Composer(s): Isao Abe"
            };

            return View();
        }
    }
}