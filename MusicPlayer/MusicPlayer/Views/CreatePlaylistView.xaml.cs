namespace MusicPlayer.Views
{
    using MusicPlayer.ViewModels;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

    public sealed partial class CreatePlaylistView : Page
    {
        public CreatePlaylistView()
        {
            this.InitializeComponent();
            this.DataContext = new PlaylistViewModel();
        }

        private void OnSavePlaylistButtonClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MyPlaylistsView));
        }
    }
}
