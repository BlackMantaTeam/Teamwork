namespace JustPlay.UI.ViewModels.Content
{
	using Contracts;
	using System.Collections.ObjectModel;

	public class PlaylistsContentViewModel : ViewModelBase, IContentViewModel
	{
		public ObservableCollection<SoundViewModel> Songs { get; set; }

		public PlaylistsContentViewModel()
		{

		}
	}
}
