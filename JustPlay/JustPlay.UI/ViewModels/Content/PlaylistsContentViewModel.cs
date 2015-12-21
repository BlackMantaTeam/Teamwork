namespace JustPlay.UI.ViewModels.Content
{
	using Commands;
	using Contracts;
	using Extensions;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Windows.Input;

	public class PlaylistsContentViewModel : ViewModelBase, IContentViewModel
	{
		private ObservableCollection<PlaylistViewModel> playlists;
		private ICommand addCommand;
		private ICommand deleteCommand;

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

		public PlaylistViewModel CurrentPlaylist { get; set; }

		public ICommand Save
		{
			get
			{
				if (this.addCommand == null)
				{
					this.addCommand = new DelegateCommand<PlaylistViewModel>((newPlaylist) =>
					{
						this.playlists.Add(new PlaylistViewModel(newPlaylist));
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
					this.deleteCommand = new DelegateCommand<SoundViewModel>((playlist) =>
					{
						playlist.Name = "Master Yoda";
					});
				}
				return this.deleteCommand;
			}
		}
	}
}