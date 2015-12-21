namespace MusicPlayer
{
    using MusicPlayer.ViewModels;
    using MusicPlayer.Views;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //this.DataContext = new MainPageViewModel();
            this.DataContext = new UserViewModel();
        }

        private void OnLoginButtonClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MyPlaylistsView));
        }

        private void OnRegisterButtonClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RegisterView));
        }
    }
}