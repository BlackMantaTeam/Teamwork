namespace MusicPlayer.Models
{
    using System.Collections.Generic;
    using SQLite.Net.Attributes;

    public class User
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string ImgUrl { get; set; }

        public IEnumerable<Playlist> Playlists { get; set; }
    }
}
