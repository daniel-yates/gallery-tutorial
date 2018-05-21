namespace Gallery.Controllers
{
    using System;
    using System.Web.Mvc;

    public class ItemController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Redirect("/");
            }

            return Content("Hello from the item controller");
        }
    }
}