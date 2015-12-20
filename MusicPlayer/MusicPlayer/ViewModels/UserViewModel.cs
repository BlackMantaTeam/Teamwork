﻿namespace MusicPlayer.ViewModels
{
    using Commands;
    using Common;
    using Contracts;
    using Extensions;
    using Models;
    using Parse;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Windows.Input;
    using Views;
    using Windows.UI.Xaml.Controls;
    public class UserViewModel : ViewModelBase, IContentViewModel
    {
        private string username;
        private string password;
        private string imgUrl;
        private PlaylistViewModel selectedPlaylist;
        private ICommand registerUserCommand;
        private ICommand loginUserCommand;
        private ICommand logoutUserCommand;
        private ICommand loadPlaylistsCommand;
        private ObservableCollection<PlaylistViewModel> playlists;

        public UserViewModel()
        {
            //LoadPlaylists();
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public string ImgUrl { get; set; }

        public IEnumerable<PlaylistViewModel> Playlists
        {
            get
            {
                if (this.playlists == null)
                {
                    this.playlists = new ObservableCollection<PlaylistViewModel>();
                }

                return this.playlists;
            }

            set
            {
                if (this.playlists == null)
                {
                    this.playlists = new ObservableCollection<PlaylistViewModel>();
                }

                this.playlists.Clear();
                value.ForEach(this.playlists.Add);
            }
        }

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

        public ICommand LoadPlaylist
        {
            get
            {
                if (this.loadPlaylistsCommand == null)
                {
                    this.loadPlaylistsCommand = new DelegateCommand(this.OnLoadPlaylistsExecute);
                }

                return this.loadPlaylistsCommand;
            }
        }

        private async void OnLoadPlaylistsExecute()
        {
            //var userPlaylists = await ParseObject.GetQuery("Playlist").WhereEqualTo("user", ParseUser.CurrentUser).FindAsync();
            //this.Playlists.Add
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
            user["playlists"] = this.Playlists;

            await user.SignUpAsync();
        }

        private async void OnLogInUserExecute()
        {
            Validator.ValidateUsername(this.Username);
            Validator.ValidateUsername(this.Password);
            await ParseUser.LogInAsync(this.Username, this.Password);
        }

        private async void OnLogoutUserExecute()
        {
            await ParseUser.LogOutAsync();
            var currentUser = ParseUser.CurrentUser;
        }

        private async void LoadPlaylists()
        {
            ////var userPlaylists = await ParseObject.GetQuery("playlist").WhereEqualTo("user", ParseUser.CurrentUser).FindAsync();
            //var playlists = await new ParseQuery<Playlist>().FindAsync();
            //ObservableCollection<SongViewModel> songsToAdd = new ObservableCollection<SongViewModel>();
            //playlists.Select(x=>x.Songs).ForEach(s => s.ForEach(j=>songsToAdd.Add(new SongViewModel(
            //    j.SongTitle,
            //    j.Url,
            //    j.Genre.ToString()
            //))));
            //this.Playlists = playlists.AsQueryable().Select(model => new PlaylistViewModel
            //{                
            //    PlaylistTitle = model.PlaylistTitle,
            //    Genre = model.Genre,
            //    Songs = songsToAdd
            //});
        }
    }
}
