namespace JustPlay.UI.ViewModels.Pages
{
	using JustPlay.UI.Contracts;

	class PlaylistsPageViewModel : PageViewModelBase, IPageViewModel
	{
		public const string TITLE = "Playlists";

		public PlaylistsPageViewModel(IContentViewModel content)
			: base(TITLE, content)
		{

		}
	}
}