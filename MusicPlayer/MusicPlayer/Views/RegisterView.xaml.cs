namespace MusicPlayer.Views
{
    using System;
    using ViewModels;
    using Windows.Media.Capture;
    using Windows.Storage;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Media.Imaging;

    public sealed partial class RegisterView : Page
    {
        public RegisterView()
        {
            this.InitializeComponent();

           this.DataContext = new UserViewModel();
            //var contentViewModel = new UserViewModel();

            //this.DataContext = new RegisterPageViewModel(contentViewModel);
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