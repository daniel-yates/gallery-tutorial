namespace VideoGameGallery.Controllers
{
    using VideoGameGallery.Models;
    using System.Web.Mvc;
    using VideoGameGallery.Data;

    public class VideoGameController : Controller
    {
        private VideoGameRepository _videoGameRepository = null;

        public VideoGameController()
        {
            _videoGameRepository = new VideoGameRepository();
        }

        public ActionResult Index()
        {
            var videoGames = _videoGameRepository.GetVideoGames();

            return View(videoGames);
        }
        
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var videoGame = _videoGameRepository.GetVideoGame(id.Value);

            return View(videoGame);
        }
    }
}