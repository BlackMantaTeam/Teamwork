namespace MusicPlayer.Models
{
    using Parse;
    using SQLite.Net.Attributes;
    using SQLiteNetExtensions.Attributes;
    using System.Collections.ObjectModel;

    [ParseClassName("Playlist")]
    public class Playlist : ParseObject
    {
        [PrimaryKey]
        [AutoIncrement]
        [ParseFieldName("id")]
        public int Id { get; set; }

        [ParseFieldName("playlistTitle")]
        public string PlaylistTitle
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [OneToMany]
        [ParseFieldName("songs")]
        public ObservableCollection<Song> Songs
        {
            get { return GetProperty<ObservableCollection<Song>>(); }
            set { SetProperty<ObservableCollection<Song>>(value); }
        }

        [ParseFieldName("genre")]
        public string Genre
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }
        
        [ParseFieldName("user")]
        public ParseUser User { get; set; }
    }
}
