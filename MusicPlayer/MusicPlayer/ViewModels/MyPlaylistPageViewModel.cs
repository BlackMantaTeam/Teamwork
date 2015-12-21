namespace MusicPlayer.ViewModels
{
    using MusicPlayer.Contracts;

    public class MyPlaylistPageViewModel : ViewModelBase, IContentViewModel, IPageViewModel
    {
        private readonly string pageTitle = "My Playlists";

        public MyPlaylistPageViewModel(IContentViewModel contentViewModel)
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
