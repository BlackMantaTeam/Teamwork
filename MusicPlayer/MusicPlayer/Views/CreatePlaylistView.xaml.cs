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

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreatePlaylistView : Page
    {
        public CreatePlaylistView()
        {
            this.InitializeComponent();
            var contentViewModel = new PlaylistViewModel("playlist1");

            //TODO ToDetele
            contentViewModel.Songs = new List<SongViewModel>()
            {
                new SongViewModel(1, "Song1", "MyPlaylistPageViewModel"),
                new SongViewModel(2, "Song2", "MyPlaylistPageViewModel")
            };

            this.DataContext = new CreatePlaylistPageViewModel(contentViewModel);
        }

        private void OnSavePlaylistButtonClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MyPlaylistsView));
        }
    }
}
