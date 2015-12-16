namespace MusicPlayer.ViewModels
{
    using Models;

    public class SongViewModel : ViewModelBase
    {
        public SongViewModel(SongViewModel newSong)
            : this(newSong.Id, newSong.SongTitle, newSong.Url)
        {
        }

        public SongViewModel(int id, string title, string url)
        {
            this.Id = id;
            this.SongTitle = title;
            this.Url = url;
        }

        public int Id { get; set; }

        public string SongTitle { get; set; }

        public string Url { get; set; }

        public Genre Genre { get; set; }
    }
}
