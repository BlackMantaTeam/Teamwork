namespace MusicPlayer.Views
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using MusicPlayer.ViewModels;
    using Windows.ApplicationModel;
    using Windows.Storage;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Input;
    using Windows.UI.Xaml.Navigation;
    public sealed partial class PlayView : Page
    {
        public PlayView()
        {
            this.InitializeComponent();
            this.DataContext = new PlaylistViewModel();
            var contentViewModel = new PlaylistViewModel();
            //this.DataContext = new MyPlaylistContentViewModel(contentViewModel);

            //TODO ToDetele
            contentViewModel.Songs = new List<SongViewModel>()
            {
                new SongViewModel("Song1","","pop"),
                new SongViewModel("Song1","","pop"),
                new SongViewModel("Song1", "", "pop")
            };            

            var myPlaylistContentViewModel = new MyPlaylistPageViewModel(contentViewModel);
            this.DataContext = myPlaylistContentViewModel;
            this.ContentViewModel = new PlaylistViewModel();
        }

        public IContentViewModel ContentViewModel { get; private set; }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            StorageFolder folder = await Package.Current.InstalledLocation.GetFolderAsync("Assets");
            StorageFile file = await folder.GetFileAsync("Grapes - I dunno.mp3");
            var stream = await file.OpenAsync(FileAccessMode.Read);

            myMediaElement.SetSource(stream, file.ContentType);
        }

        private void OnPlayButtonClick(object sender, RoutedEventArgs e)
        {
            myMediaElement.Play();
        }

        private void OnPauseButtonClick(object sender, RoutedEventArgs e)
        {
            myMediaElement.Pause();
        }

        private void OnStopButtonClick(object sender, RoutedEventArgs e)
        {
            myMediaElement.Stop();
        }

        private void OnBackButtonClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MyPlaylistsView));
        }

        private async void OnSongTapped(object sender, TappedRoutedEventArgs e)
        {
            StorageFolder folder = await Package.Current.InstalledLocation.GetFolderAsync("Assets");
            StorageFile file = await folder.GetFileAsync("Grapes - I dunno.mp3");
            var stream = await file.OpenAsync(FileAccessMode.Read);

            myMediaElement.SetSource(stream, file.ContentType);
        }
    }
}