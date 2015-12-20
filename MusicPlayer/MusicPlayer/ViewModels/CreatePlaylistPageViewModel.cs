using MusicPlayer.Contracts;

namespace MusicPlayer.ViewModels
{
	public class CreatePlaylistPageViewModel : ViewModelBase, IContentViewModel
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
