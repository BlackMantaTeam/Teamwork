namespace MusicPlayer.ViewModels
{
    public class MainPageViewModel : ViewModelBase, IPageViewModel
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
