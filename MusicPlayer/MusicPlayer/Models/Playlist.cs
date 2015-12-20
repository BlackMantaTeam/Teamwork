namespace MusicPlayer.Models
{
    using Parse;
    using SQLite.Net.Attributes;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using SQLiteNetExtensions.Attributes;

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

        //public int UserId { get; set; }
        [ParseFieldName("user")]
        public ParseUser User { get; set; }

        //private async void OnSavePlaylistExecute(object parameters)
        //{
        //    var playlist = new Playlist
        //    {
        //        PlaylistTitle = this.PlaylistTitle,
        //        Songs = this.Songs,
        //        Genre = this.Genre,
        //        User = this.User
        //    };

        //    await playlist.SaveAsync();
        //}
    }
}
