namespace MusicPlayer.ViewModels
{
	using MusicPlayer.Contracts;

	public class MyPlaylistContentViewModel : ViewModelBase, IContentViewModel
	{
        private readonly string pageTitle = "My Playlists";

        public MyPlaylistContentViewModel(IContentViewModel contentViewModel)
        {
            this.ContentViewModel = contentViewModel;
        }

        public string Title
        {
            get
            {
                return this.pageTitle;
            }
        }

        public IContentViewModel ContentViewModel { get; set; }
    }
}
