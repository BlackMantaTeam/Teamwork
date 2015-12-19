namespace MusicPlayer.Page.ViewModels
{
	using MusicPlayer.Contracts;

	public class MainPageViewModel : ViewModelBase
    {
        private readonly string pageTitle = "Music Player";

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
