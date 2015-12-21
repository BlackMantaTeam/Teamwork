namespace MusicPlayer.Views
{
	using System.Collections.Generic;
    using Contracts;
    using MusicPlayer.ViewModels;
	using Windows.UI.Xaml;
	using Windows.UI.Xaml.Controls;
	using Windows.UI.Xaml.Input;	

	public sealed partial class MyPlaylistsView : Page
	{
        public MyPlaylistsView()
		{
			this.InitializeComponent();
            //this.DataContext = new UserViewModel();
            var contentViewModel = new UserViewModel();
            //this.DataContext = new MyPlaylistPageViewModel(contentViewModel);

            //////TODO ToDetele
            contentViewModel.Playlists = new List<PlaylistViewModel>()
            {
                new PlaylistViewModel("Playlist1"),
                new PlaylistViewModel("Playlist1"),
                new PlaylistViewModel("Playlist1"),
                new PlaylistViewModel("Playlist1"),
                new PlaylistViewModel("Playlist1"),
                new PlaylistViewModel("Playlist1"),
                new PlaylistViewModel("Playlist1")
            };

            //this.DataContext = new MyPlaylistPageViewModel(contentViewModel);
            var myPlaylistContentViewModel = new MyPlaylistPageViewModel(contentViewModel);
            this.DataContext = myPlaylistContentViewModel;
            this.ContentViewModel = myPlaylistContentViewModel;
        }

        public IContentViewModel ContentViewModel { get; private set; }

        private void OnCreateButtonClick(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(CreatePlaylistView));
		}

		private void OnLogoutButtonClick(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(MainPage));
		}

        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(PlayView));
        }
    }
}