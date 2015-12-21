namespace MusicPlayer.ViewModels
{
    using MusicPlayer.Contracts;

    public class CreatePlaylistPageViewModel : ViewModelBase, IContentViewModel,IPageViewModel
    {
        private readonly string pageTitle = "Create a Playlist";

        public CreatePlaylistPageViewModel(IContentViewModel contentViewModel)
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
