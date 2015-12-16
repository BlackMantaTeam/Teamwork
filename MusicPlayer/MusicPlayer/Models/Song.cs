namespace MusicPlayer.Models
{
    public class Song
    {
        public int Id { get; set; }

        public string SongTitle { get; set; }

        public string Url { get; set; }

        public Genre Genre { get; set; }
    }
}
