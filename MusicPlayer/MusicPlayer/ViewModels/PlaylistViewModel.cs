namespace MusicPlayer.ViewModels
{
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Windows.Input;
	using Commands;
	using Models;
	using Extensions;
	using Contracts;

	public class PlaylistViewModel : ViewModelBase, IPlaylistsViewModel, IContentViewModel
    {
        private ObservableCollection<SongViewModel> songs;
        private ICommand addSongCommand;
        private ICommand deleteCommand;

        public PlaylistViewModel()
            : this(string.Empty)
        {
        }

        public PlaylistViewModel(string title)
        {
            this.PlaylistTitle = title;
        }

        public string PlaylistTitle { get; set; }

        public Genre Genre { get; set; }

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
    }
}
