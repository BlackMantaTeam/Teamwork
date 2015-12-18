namespace MusicPlayer.ViewModels
{
    using Commands;
    using Common;
    using Models;
    using Parse;
    using System;
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
        private ICommand logoutUserCommand;
        
        public string Username { get; set; }

        public string Password { get; set; }

        public string ImgUrl { get; set; }

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

        public ICommand RegisterUser
        {
            get
            {
                if (this.registerUserCommand == null)
                {
                    this.registerUserCommand = new DelegateCommand(this.OnRegisterUserExecute);
                }

                return this.registerUserCommand;
            }
        }

        public ICommand LoginUser
        {
            get
            {
                if (this.loginUserCommand == null)
                {
                    this.loginUserCommand = new DelegateCommand(this.OnLogInUserExecute);
                }

                return this.loginUserCommand;
            }
        }

        public ICommand LogoutUser
        {
            get
            {
                if (this.logoutUserCommand == null)
                {
                    this.logoutUserCommand = new DelegateCommand(this.OnLogoutUserExecute);
                }

                return this.logoutUserCommand;
            }
        }

        private async void OnRegisterUserExecute()
        {
            Validator.ValidateUsername(this.Username);
            Validator.ValidateUsername(this.Password);

            var user = new ParseUser()
            {
                Username = this.Username,
                Password = this.Password
            };

            user["imgUrl"] = this.ImgUrl;
            user["playlists"] = new List<Song>();

            await user.SignUpAsync();
        }

        private async void OnLogInUserExecute()
        {
            Validator.ValidateUsername(this.Username);
            Validator.ValidateUsername(this.Password);

            await ParseUser.LogInAsync(this.Username, this.Password);

            //try
            //{
            //    await ParseUser.LogInAsync(this.Username, this.Password);
            //}
            //catch (Exception e)
            //{
            //    //invalidLoginLabel.Text = "Bad Username/Password!";
            //}
        }

        private async void OnLogoutUserExecute()
        {
            await ParseUser.LogOutAsync();
            //ParseUser currentUser = ParseUser..getCurrentUser();
        }
        //public async Task LoadPlaylists()
        //{

        //}
    }
}
