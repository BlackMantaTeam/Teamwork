namespace MusicPlayer.ViewModels
{    
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Linq.Expressions;    
    using System.Windows.Input;
    using Commands;
    using Contracts;
    using Extensions;
    using Models;   
    using Parse;    

    public class PlaylistViewModel : ViewModelBase, IContentViewModel
    {
        public ObservableCollection<SongViewModel> songs;
        private ICommand addSongCommand;
        private ICommand deleteCommand;
        private ICommand savePlalistCommand;
        private ICommand loadPlaylistsCommand;

        public static Expression<Func<Playlist, PlaylistViewModel>> FromModel
        {
            get
            {
                return model =>
                    new PlaylistViewModel()
                    {
                        PlaylistTitle = model.PlaylistTitle,
                        Genre = model.Genre,
                        Songs = model.Songs.AsQueryable().Select(SongViewModel.FromModel)
                    };
            }
        }

        public PlaylistViewModel()
            : this(string.Empty)
        {
            //this.LoadSongs();
        }

        public PlaylistViewModel(string title)
        {
            this.PlaylistTitle = title;
        }

        public PlaylistViewModel(PlaylistViewModel newPlaylist)
            : this(newPlaylist.PlaylistTitle, newPlaylist.Genre, newPlaylist.Songs)
        {
        }

        public PlaylistViewModel(string title, string genre, IEnumerable<SongViewModel> songs)
        {
            this.PlaylistTitle = title;
            this.Genre = genre;
            this.Songs = songs;
        }

        public string PlaylistTitle { get; set; }

        public string Genre { get; set; }

        public ParseUser User { get; set; }

        public IEnumerable<SongViewModel> Songs
        {
            get
            {
                if (this.songs == null)
                {
                    this.songs = new ObservableCollection<SongViewModel>();
                }

                return this.songs;
            }

            set
            {
                if (this.songs == null)
                {
                    this.songs = new ObservableCollection<SongViewModel>();
                }

                this.songs.Clear();
                value.ForEach(this.songs.Add);
            }
        }

        public ICommand AddSong
        {
            get
            {
                if (this.addSongCommand == null)
                {
                    this.addSongCommand = new DelegateCommandWithParam<SongViewModel>((newSong) =>
                    {
                        this.songs.Add(new SongViewModel(newSong));
                    });
                }

                return this.addSongCommand;
            }
        }

        public ICommand Delete
        {
            get
            {
                if (this.deleteCommand == null)
                {
                    this.deleteCommand = new DelegateCommandWithParam<SongViewModel>((song) =>
                    {
                        this.songs.Remove(song);
                    });
                }

                return this.deleteCommand;
            }
        }

        public ICommand SavePlaylist
        {
            get
            {
                if (this.savePlalistCommand == null)
                {
                    this.savePlalistCommand = new DelegateCommand(this.OnSavePlaylistExecute);
                }

                return this.savePlalistCommand;
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
            //var userPlaylists = await ParseObject.GetQuery("playlist").W;
            ////var query = new Parse..Query("playlist");
            //userPlaylists.include("user");

        }

        private async void OnSavePlaylistExecute()
        {
            ObservableCollection<Song> songsToAdd = new ObservableCollection<Song>();
            this.Songs.ForEach(x => songsToAdd.Add(new Song(
                x.SongTitle,                
                x.Url,
                x.Genre.ToString()
            )));

            var playlist = new Playlist
            {
                PlaylistTitle = this.PlaylistTitle,
                Songs = songsToAdd,
                Genre = this.Genre,
                //User = ParseUser.CurrentUser
            };

            playlist["user"] = ParseUser.CurrentUser;

            await playlist.SaveAsync();
        }

        private async void LoadSongs()
        {
            var songs = await new ParseQuery<Song>().FindAsync();

            this.Songs = songs.AsQueryable().Select(SongViewModel.FromModel);

            //this.Songs = songs.AsQueryable().Select(model => new SongViewModel
            //{
            //    SongTitle = model.SongTitle,
            //    Genre = model.Genre,
            //    Url = model.Url
            //});
        }
    }
}
