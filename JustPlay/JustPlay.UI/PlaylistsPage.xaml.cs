namespace JustPlay.UI
{
    using System.Collections.Generic;
    using JustPlay.UI.ViewModels;
    using JustPlay.UI.ViewModels.Content;
    using JustPlay.UI.ViewModels.Pages;    
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

    public sealed partial class PlaylistsPage : Page
    {
        public PlaylistsPage()
        {
            this.InitializeComponent();

            var playlistsContent = new PlaylistsContentViewModel();
            playlistsContent.Songs = new List<SoundViewModel>
            {
                new SoundViewModel(title: "Metallica", genre: "Metal"),
                new SoundViewModel(title: "Megadeth", genre: "Metal"),
                new SoundViewModel(title: "Metallica", genre: "Metal"),
                new SoundViewModel(title: "Metallica", genre: "Metal"),
                new SoundViewModel(title: "Eminem", genre: "Rap"),
                new SoundViewModel(title: "Metallica", genre: "Metal"),
                new SoundViewModel(title: "Metallica", genre: "Metal"),
                new SoundViewModel(title: "Metallica", genre: "Metal"),
                new SoundViewModel(title: "Metallica", genre: "Metal")
            };

            var playlistDataContext = new PlaylistsPageViewModel(playlistsContent);
            this.DataContext = playlistDataContext;

            BackButton.Visibility = Visibility.Collapsed;
        }
    }
}