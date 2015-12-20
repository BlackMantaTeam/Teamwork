namespace MusicPlayer.Models
{
    using System.Collections.Generic;
    using SQLite.Net.Attributes;
    using Parse;
    using SQLiteNetExtensions.Attributes;

    //[ParseClassName("User")]
    public class User
    {
        public User()
        {
            this.Playlists= new List<Playlist>();
        }

        [PrimaryKey]
        [AutoIncrement]
        [ParseFieldName("id")]
        public int Id { get; set; }

        [ParseFieldName("username")]
        public string Username { get; set; }
        //{
        //    get { return GetProperty<string>(); }
        //    set { SetProperty<string>(value); }
        //}

        [ParseFieldName("password")]
        public string Password { get; set; }
        //{
        //    get { return GetProperty<string>(); }
        //    set { SetProperty<string>(value); }
        //}

        [ParseFieldName("imgUrl")]
        public string ImgUrl { get; set; }
        //{
        //    get { return GetProperty<string>(); }
        //    set { SetProperty<string>(value); }
        //}

        [ParseFieldName("playlists")]
        [OneToMany]
        public IEnumerable<Playlist> Playlists { get; set; }
        //{
        //    get { return GetProperty<IEnumerable<Playlist>>(); }
        //    set { SetProperty<IEnumerable<Playlist>>(value); }
        //}
    }
}
