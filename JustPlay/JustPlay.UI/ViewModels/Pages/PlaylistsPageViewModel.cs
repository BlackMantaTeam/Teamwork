namespace JustPlay.UI.ViewModels.Pages
{
	using Commands;
	using JustPlay.UI.Contracts;
	using System.Windows.Input;
	using Windows.UI.Xaml.Controls;

	class PlaylistsPageViewModel : PageViewModelBase, IPageViewModel
	{
		public const string TITLE = "Playlists";
		private ICommand revealPaneCommand;

		public PlaylistsPageViewModel(IContentViewModel content)
			: base(TITLE, content)
		{

		}

		public ICommand RevealPane
		{
			get
			{
				if (this.revealPaneCommand == null)
				{
					this.revealPaneCommand = new DelegateCommand<SplitView>((pane) =>
					{
						pane.IsPaneOpen = !pane.IsPaneOpen;
					});
				}
				return this.revealPaneCommand;
			}
		}
	}
}