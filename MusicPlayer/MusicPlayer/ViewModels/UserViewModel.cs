namespace MusicPlayer.ViewModels
{
    using Commands;
    using System.Collections.Generic;
    using System.Windows.Input;
    public class UserViewModel : ViewModelBase, IContentViewModel
    {
        private string username;
        private string password;
        private string imgUrl;
        private PlaylistViewModel selectedPlaylist;
        private ICommand registerUserCommand;
        private ICommand loginUserCommand;

        public UserViewModel()
            : this(string.Empty, string.Empty, string.Empty)
        {
        }

        public UserViewModel(UserViewModel user)
            : this(user.Username, user.Password, user.ImgUrl)
        {
        }

        public UserViewModel(string username, string password, string ImgUrl)
        {
            this.Username = username;
            this.Password = password;
            this.ImgUrl = ImgUrl;
            this.Playlists = new List<PlaylistViewModel>();
        }

        //public int Id { get; set; }

        public string Username
        {
            get { return this.username; }

            set
            {
                if (value != this.username)
                {
                    this.username = value;
                    this.OnPropertyChanged("Username");
                }
            }
        }

        public string Password
        {
            get { return this.password; }

            set
            {
                if (value != this.password)
                {
                    this.password = value;
                    this.OnPropertyChanged("Password");
                }
            }
        }

        public string ImgUrl
        {
            get { return this.imgUrl; }

            set
            {
                if (value != this.imgUrl)
                {
                    this.imgUrl = value;
                    this.OnPropertyChanged("ImgUrl");
                }
            }
        }

        public IEnumerable<PlaylistViewModel> Playlists { get; set; }

        //public PlaylistViewModel SelectedPlaylist
        //{
        //    get
        //    {
        //        return this.selectedPlaylist;
        //    }
        //    set
        //    {
        //        this.selectedPlaylist = value;
        //        this.OnPropertyChanged("SelectedPlaylist");
        //    }
        //}

            }
}
