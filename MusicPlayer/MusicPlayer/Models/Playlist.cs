namespace MusicPlayer.Models
{
    using Parse;
    using System.Collections.Generic;

    [ParseClassName("Playlist")]
    public class Playlist: ParseObject
    {
        [ParseFieldName("playlistTitle")]
        public string PlaylistTitle
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("songs")]
        public IEnumerable<Song> Songs
        {
            get { return GetProperty<IEnumerable<Song>>(); }
            set { SetProperty<IEnumerable<Song>>(value); }
        }

        [ParseFieldName("genre")]
        public Genre Genre
        {
            get { return GetProperty<Genre>(); }
            set { SetProperty<Genre>(value); }
        }
    }
}
