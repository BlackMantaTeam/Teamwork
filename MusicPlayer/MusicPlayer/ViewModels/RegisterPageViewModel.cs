namespace MusicPlayer.ViewModels
{
    public class RegisterPageViewModel : ViewModelBase
    {
        private readonly string pageTitle = "Register";

        public RegisterPageViewModel(IContentViewModel contentViewModel)
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
