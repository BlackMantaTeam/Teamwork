namespace MusicPlayer.ViewModels
{    
    using System;
    using System.Linq.Expressions;
    using Models;

    public class SongViewModel : ViewModelBase
    {
        public static Expression<Func<Song, SongViewModel>> FromModel
        {
            get
            {
                return model =>
                    new SongViewModel()
                    {
                        SongTitle = model.SongTitle,
                        Genre = model.Genre,
                        Url=model.Url
                    };
            }
        }

        public SongViewModel()
        : this(string.Empty, string.Empty, string.Empty)
        {
        }

        public SongViewModel(SongViewModel newSong)
            : this(newSong.SongTitle, newSong.Url, newSong.Genre)
        {
        }

        public SongViewModel(string title, string url, string genre)
        {
            this.SongTitle = title;
            this.Url = url;
            this.Genre = genre;
        }
        
        public string SongTitle { get; set; }

        public string Url { get; set; }

        public string Genre { get; set; }


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
