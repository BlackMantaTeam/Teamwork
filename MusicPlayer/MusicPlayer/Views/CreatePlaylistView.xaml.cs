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
    using Models;

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
