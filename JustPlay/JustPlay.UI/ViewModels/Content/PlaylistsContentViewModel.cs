namespace JustPlay.UI.ViewModels.Content
{
	using Commands;
	using Contracts;
	using Extensions;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Windows.Input;
	using Windows.UI.Xaml.Controls;
	public class PlaylistsContentViewModel : ViewModelBase, IContentViewModel
	{
		private ObservableCollection<PlaylistViewModel> playlists;
		private ObservableCollection<SoundViewModel> currentPlaylist;
		private ICommand addCommand;
		private ICommand deleteCommand;
		private ICommand searchCommand;

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

		public ObservableCollection<SoundViewModel> CurrentPlaylist
		{
			get
			{
				if (this.currentPlaylist == null)
				{
					this.currentPlaylist = new ObservableCollection<SoundViewModel>();
				}

				return this.currentPlaylist;
			}
			set
			{
				if (this.currentPlaylist == null)
				{
					this.currentPlaylist = new ObservableCollection<SoundViewModel>();
				}

				this.currentPlaylist.Clear();
				value.ForEach(this.currentPlaylist.Add);
			}
		}

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
					this.deleteCommand = new DelegateCommand<PlaylistViewModel>((playlist) =>
					{
						this.playlists.Remove(playlist);
					});
				}
				return this.deleteCommand;
			}
		}

		public ICommand SearchCommand
		{
			get
			{
				if (this.deleteCommand == null)
				{
					this.deleteCommand = new DelegateCommand<AutoSuggestBox>((query) =>
					{
						if (string.IsNullOrEmpty(query.Text) == false)
						{
							this.CurrentPlaylist.Clear();
							this.Playlists.ForEach(playlist =>
							{
								playlist.Songs.ForEach(song =>
								{
									if (song.Title.Contains(query.Text))
									{
										this.CurrentPlaylist.Add(song);
									}
								});
							});
						}
					});
				}

				return this.deleteCommand;
			}
		}
	}
}