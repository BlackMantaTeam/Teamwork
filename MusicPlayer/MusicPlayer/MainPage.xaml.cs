namespace MusicPlayer
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices.WindowsRuntime;
    using MusicPlayer.ViewModels;
    using MusicPlayer.Views;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Controls.Primitives;
    using Windows.UI.Xaml.Data;
    using Windows.UI.Xaml.Input;
    using Windows.UI.Xaml.Media;
    using Windows.UI.Xaml.Navigation;
    using MusicPlayer.Commands;
    using System.Threading.Tasks;
    using SQLite.Net.Async;
    using Windows.Storage;
    using SQLite.Net;
    using SQLite.Net.Platform.WinRT;
    using System.Text;
    using Models;

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
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