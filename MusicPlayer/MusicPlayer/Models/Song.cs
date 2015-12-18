namespace MusicPlayer.Models
{
    using Parse;

    [ParseClassName("Song")]
    public class Song: ParseObject
    {
        //[ParseFieldName("id")]
        //public int Id
        //{
        //    get { return GetProperty<int>(); }
        //    set { SetProperty<int>(value); }
        //}

        [ParseFieldName("songTitle")]
        public string SongTitle
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("url")]
        public string Url
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("genre")]
        public Genre Genre
        {
            get { return GetProperty<Genre>(); }
            set { SetProperty<Genre>(value); }
        }
    }
}
