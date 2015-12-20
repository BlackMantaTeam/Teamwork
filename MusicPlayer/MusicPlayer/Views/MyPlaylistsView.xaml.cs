namespace MusicPlayer.Views
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Runtime.InteropServices.WindowsRuntime;
	using MusicPlayer.ViewModels;
	using Windows.Foundation;
	using Windows.Foundation.Collections;
	using Windows.UI.Xaml;
	using Windows.UI.Xaml.Controls;
	using Windows.UI.Xaml.Controls.Primitives;
	using Windows.UI.Xaml.Data;
	using Windows.UI.Xaml.Input;
	using Windows.UI.Xaml.Media;
	using Windows.UI.Xaml.Navigation;
	using Contracts;

	public sealed partial class MyPlaylistsView : Page
	{
        public MyPlaylistsView()
		{
			this.InitializeComponent();
            //this.DataContext = new UserViewModel();

            //this.DataContext = new MyPlaylistContentViewModel(contentViewModel);
            var contentViewModel = new UserViewModel();
            //TODO ToDetele
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

            var myPlaylistContentViewModel = new MyPlaylistContentViewModel(contentViewModel);
            this.DataContext = myPlaylistContentViewModel;
            this.ContentViewModel = myPlaylistContentViewModel;
        }

        public IContentViewModel ContentViewModel { get; private set; }

        //protected override async void OnNavigatedTo(NavigationEventArgs e)
        //{
        //    this.contentViewModel.PropertyChanged
        //}

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