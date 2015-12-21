namespace JustPlay.UI.ViewModels
{
	using Extensions;
	using JustPlay.UI.Commands;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Windows.Input;

	public class PlaylistViewModel : ViewModelBase, INotifyPropertyChanged
	{
		private ObservableCollection<SoundViewModel> songs;
		private string title;
		private string imageSource;
		private ICommand addCommand;
		private ICommand deleteCommand;

		public PlaylistViewModel(string title, string imageSource)
		{
			this.Title = title;
			this.ImageSource = imageSource;
		}

		public PlaylistViewModel(PlaylistViewModel newPlaylist)
			: this(newPlaylist.Title, newPlaylist.ImageSource)
		{
			if (this.songs == null)
			{
				this.songs = new ObservableCollection<SoundViewModel>();
			}

			newPlaylist.Songs.ForEach(song => this.songs.Add(song));
		}

		public string Title
		{
			get
			{
				return this.title;
			}
			set
			{
				this.title = value;
				this.OnPropertyChanged("Title");
			}
		}
		public string ImageSource { get; set; }

		public IEnumerable<SoundViewModel> Songs
		{
			get
			{
				if (this.songs == null)
				{
					this.songs = new ObservableCollection<SoundViewModel>();
				}

				return this.songs;
			}
			set
			{
				if (this.songs == null)
				{
					this.songs = new ObservableCollection<SoundViewModel>();
				}

				this.songs.Clear();
				value.ForEach(this.songs.Add);
			}
		}

		public ICommand Save
		{
			get
			{
				if (this.addCommand == null)
				{
					this.addCommand = new DelegateCommand<SoundViewModel>((newSong) =>
					{
						this.songs.Add(new SoundViewModel(newSong));
					});
				}

				return this.addCommand;
			}
		}

		public ICommand Delete
		{
			get
			{
				if (this.deleteCommand == null)
				{
					this.deleteCommand = new DelegateCommand<SoundViewModel>((song) =>
					{
						song.Name = "Master Yoda";
					});
				}
				return this.deleteCommand;
			}
		}
	}
}