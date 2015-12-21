namespace MusicPlayer.Models
{
    using Parse;
    using System.Collections.Generic;
    using SQLite.Net.Attributes;    
    using SQLiteNetExtensions.Attributes;

    [ParseClassName("User")]
    public class User : ParseObject
    {
        public User()
        {
            this.Playlists = new List<Playlist>();
        }

        [PrimaryKey]
        [AutoIncrement]
        [ParseFieldName("id")]
        public int Id { get; set; }

        [ParseFieldName("username")]
        public string Username
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("password")]
        public string Password
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("imgUrl")]
        public string ImgUrl
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("playlists")]
        [OneToMany]
        public IEnumerable<Playlist> Playlists
        {
            get { return GetProperty<IEnumerable<Playlist>>(); }
            set { SetProperty<IEnumerable<Playlist>>(value); }
        }
    }
}
