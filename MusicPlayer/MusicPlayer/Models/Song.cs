namespace MusicPlayer.Models
{
    using Parse;
    using SQLite.Net.Attributes;

    [ParseClassName("Song")]
    public class Song : ParseObject
    {
        public Song()
            : this(string.Empty, string.Empty, string.Empty)
        {
        }

        public Song(string title, string url, string genre)
        {
            this.SongTitle = title;
            this.Url = url;
            this.Genre = genre;
        }

        [PrimaryKey]
        [AutoIncrement]
        [ParseFieldName("id")]
        public int Id { get; set; }

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
        public string Genre
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        public override string ToString()
        {
            return $"Song: {this.SongTitle}; Genre: {this.Genre}; Url:{this.Url}";
        }
    }
}
