namespace MusicPlayer.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UserViewModel: IContentViewModel
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string ImgUrl { get; set; }

        public IEnumerable<PlaylistViewModel> Playlists { get; set; }
    }
}
