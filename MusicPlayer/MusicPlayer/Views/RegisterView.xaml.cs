namespace MusicPlayer.Views
{
    using Parse;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices.WindowsRuntime;
    using ViewModels;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Media.Capture;
    using Windows.Storage;
    using Windows.Storage.Streams;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Controls.Primitives;
    using Windows.UI.Xaml.Data;
    using Windows.UI.Xaml.Input;
    using Windows.UI.Xaml.Media;
    using Windows.UI.Xaml.Media.Imaging;
    using Windows.UI.Xaml.Navigation;

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegisterView : Page
    {
        public RegisterView()
        {
            this.InitializeComponent();

            this.DataContext = new UserViewModel();
        }

        private void OnRegisterButtonClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MyPlaylistsView));
        }
        private void OnCancelButtonClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private async void OnShootButtonClick(object sender, RoutedEventArgs e)
        {
            CameraCaptureUI camera = new CameraCaptureUI();
            BitmapImage source = new BitmapImage();
            StorageFolder folder = ApplicationData.Current.LocalFolder;

            //StorageFolder folder2 = Windows.Storage.KnownFolders.SavedPictures;
            StorageFile file = await camera.CaptureFileAsync(CameraCaptureUIMode.Photo);

            StorageFile source1 = await file.CopyAsync(folder, "newPic.jpg", NameCollisionOption.GenerateUniqueName);
            this.imgUrl.Text = source1.Path;            
        }
    }
}
