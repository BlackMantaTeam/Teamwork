using JustPlay.UI.Managers;
using JustPlay.UI.ViewModels;
using JustPlay.UI.ViewModels.Content;
using JustPlay.UI.ViewModels.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace JustPlay.UI
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class PlaylistsPage : Page
	{

		public PlaylistsPage()
		{
			this.InitializeComponent();


			var playlistsContent = new PlaylistsContentViewModel();
			playlistsContent.Playlists = new List<PlaylistViewModel>
			{
				new PlaylistViewModel("Metallicaaaa","C:\\Users\\Tectonik\\Desktop\\Teamwork\\Teamwork\\JustPlay\\JustPlay.UI\\Assets\\LockScreenLogo.scale-200.png"),
				new PlaylistViewModel("Metallicaaaa","C:\\Users\\Tectonik\\Desktop\\Teamwork\\Teamwork\\JustPlay\\JustPlay.UI\\Assets\\LockScreenLogo.scale-200.png"),
				new PlaylistViewModel("Metallicaaaa","C:\\Users\\Tectonik\\Desktop\\Teamwork\\Teamwork\\JustPlay\\JustPlay.UI\\Assets\\LockScreenLogo.scale-200.png"),
				new PlaylistViewModel("Metallicaaaa","C:\\Users\\Tectonik\\Desktop\\Teamwork\\Teamwork\\JustPlay\\JustPlay.UI\\Assets\\LockScreenLogo.scale-200.png"),
				new PlaylistViewModel("Metallicaaaa","C:\\Users\\Tectonik\\Desktop\\Teamwork\\Teamwork\\JustPlay\\JustPlay.UI\\Assets\\LockScreenLogo.scale-200.png"),
				new PlaylistViewModel("Metallicaaaa","C:\\Users\\Tectonik\\Desktop\\Teamwork\\Teamwork\\JustPlay\\JustPlay.UI\\Assets\\LockScreenLogo.scale-200.png"),
				new PlaylistViewModel("Metallicaaaa","C:\\Users\\Tectonik\\Desktop\\Teamwork\\Teamwork\\JustPlay\\JustPlay.UI\\Assets\\LockScreenLogo.scale-200.png")
			};

			var playlistDataContext = new PlaylistsPageViewModel(playlistsContent);
			this.DataContext = playlistDataContext;

			BackButton.Visibility = Visibility.Collapsed;
		}

		private void MenuItemsListView_ItemClick(object sender, ItemClickEventArgs e)
		{
			var currentPlaylist = (PlaylistViewModel)e.ClickedItem;

			// Filter on category
			CategoryTextBlock.Text = currentPlaylist.Title;

			this.

			//SoundManager.GetSoundsByCategory(Sounds, menuItem.Category);
			BackButton.Visibility = Visibility.Visible;
		}
	}
}
