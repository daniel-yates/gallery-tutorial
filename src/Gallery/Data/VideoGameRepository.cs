namespace VideoGameGallery.Data
{
    using VideoGameGallery.Models;

    public class VideoGameRepository
    {
        private static VideoGame[] _videoGames = new VideoGame[]
        {
            new VideoGame()
            {
                Id = 1,
                SeriesTitle = "Street Fighter",
                GameName = "Street Fighter 2: Champion Edition",
                DescriptionHtml = "<p>Street Fighter II: Champion Edition is a competitive fighting game released for the arcades by Capcom in 1992</p>",
                Developers = new Developer[]
                {
                    new Developer() { Role = "Producer", Name = "Yoshiki Okamoto" },
                    new Developer() { Role = "Designer", Name = "Akira Nishitani, Akira Yasuda" },
                    new Developer() { Role = "Composer", Name = "Isao Abe" }
                }
            },
            new VideoGame()
            {
                Id = 2,
                SeriesTitle = "Street Fighter",
                GameName = "Street Fighter 2 Turbo: Hyper Fighting",
                DescriptionHtml = "<p>Street Fighter II Turbo: Hyper Fighting is a competitive fighting game released for the arcade by Capcom in 1992. It is the third game in the Street Fighter II sub-series of Street Fighter games following Street Fighter II: Champion Edition.</p>",
                Developers = new Developer[]
                {
                    new Developer() { Role = "Producer", Name = "Yoshiki Okamoto" },
                    new Developer() { Role = "Designer", Name = "Akira Nishitani, Akira Yasuda" },
                    new Developer() { Role = "Composer", Name = "Yoko Shimomura, Isao Abe" }
                }
            },
            new VideoGame()
            {
                Id = 3,
                SeriesTitle = "Street Fighter",
                GameName = "Super Street Fighter 2",
                DescriptionHtml = "<p>Super Street Fighter II: The New Challengers is a head-to-head fighting game produced by Capcom and originally released as a coin-operated arcade game in 1993.</p>",
                Developers = new Developer[]
                {
                    new Developer() { Role = "Producer", Name = "Yoshiki Okamoto" },
                    new Developer() { Role = "Designer", Name = "Noritaka Funamizu, Haruo Murata" },
                    new Developer() { Role = "Composer", Name = "Isao Abe, Syun Nishigaki" }
                }
            }
        };

        public VideoGame[] GetVideoGames()
        {
            return _videoGames;
        }

        public VideoGame GetVideoGame(int id)
        {
            VideoGame videoGameToReturn = null;

            foreach (var videoGame in _videoGames)
            {
                if (videoGame.Id == id)
                {
                    videoGameToReturn = videoGame;

                    break;
                }
            }

            return videoGameToReturn;
        }
    }
}