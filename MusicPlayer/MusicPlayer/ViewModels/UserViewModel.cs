namespace MusicPlayer.ViewModels
{
    using System.Collections.Generic;

    public class UserViewModel : IContentViewModel
    {
        public UserViewModel()
        {
        }

        public UserViewModel(UserViewModel user)
            :this(user.Username,user.Password,user.ImgUrl)
        {
        }

        public UserViewModel(string username, string password, string ImgUrl)
        {
            this.Username = username;
            this.Password = password;
            this.ImgUrl = ImgUrl;
            this.Playlists = new List<PlaylistViewModel>();
        }

        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string ImgUrl { get; set; }

        public IEnumerable<PlaylistViewModel> Playlists { get; set; }
    }
}
