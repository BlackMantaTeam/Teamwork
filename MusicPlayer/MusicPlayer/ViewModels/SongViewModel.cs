namespace MusicPlayer.ViewModels
{
    using Models;

    public class SongViewModel : ViewModelBase
    {
        public SongViewModel()
        : this(string.Empty, string.Empty, Genre.Miscellaneous)
        {
        }

        public SongViewModel(SongViewModel newSong)
            : this(newSong.SongTitle, newSong.Url, newSong.Genre)
        {
        }

        public SongViewModel(string title, string url, Genre genre)
        {
            this.SongTitle = title;
            this.Url = url;
            this.Genre = genre;
        }

        //public int Id { get; set; }

        public string SongTitle { get; set; }

        public string Url { get; set; }

        public Genre Genre { get; set; }


        private async void OnSaveSongExecute(object parameters)
        {
            var song = new Song
            {
                SongTitle = this.SongTitle,
                Url = this.Url,
                Genre = this.Genre.ToString()
            };

            await song.SaveAsync();
        }
    }
}
