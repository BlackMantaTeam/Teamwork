using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MusicPlayer.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PlayView : Page
    {
        public PlayView()
        {
            this.InitializeComponent();
        }

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
    }
}
