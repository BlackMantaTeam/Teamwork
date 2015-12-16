namespace MusicPlayer.Models
{
    using System.Collections.Generic;

    public class Playlist
    {
        public string PlaylistTitle { get; set; }

        public IEnumerable<Song> Songs { get; set; }

        public Genre Genre { get; set; }
    }
}
