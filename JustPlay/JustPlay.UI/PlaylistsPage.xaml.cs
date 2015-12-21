using JustPlay.UI.Extensions;
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
		private readonly string BASE_PATH_TO_EXAMPLE_AUDIO = "/Assets/Music/02. Immortalized.mp3";
		private readonly string BASE_PATH_TO_EXAMPLE_IMAGE = "/Assets/PlaylistBaseImage.png";
		private readonly string BASE_PATH_TO_DISTURBED = "/Assets/1439537280_-1018871059.jpg";

		private bool playerIsRunning = false;

		public PlaylistsPage()
		{
			this.InitializeComponent();

			var playlistsContent = new PlaylistsContentViewModel();
			playlistsContent.Playlists = new List<PlaylistViewModel>
			{
				new PlaylistViewModel("Metallicaaaa", BASE_PATH_TO_DISTURBED)
					{Songs=new List<SoundViewModel>
					{
						new SoundViewModel("Johan the balerina","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Strauss","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Mozart","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the metallic","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Jedi","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
					} },
					new PlaylistViewModel("Eminem", BASE_PATH_TO_EXAMPLE_IMAGE)
					{Songs=new List<SoundViewModel>
					{
						new SoundViewModel("Johan the barbarian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Destroyer","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Conqueror","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Doncho the Batman","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the superior one","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the doctor","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Kenov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Hristov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Muslim","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the multi-threaded","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Kostov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Cuklev","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Minkov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan woth CS:GO and voda","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Russian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the barbarian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Destroyer","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Conqueror","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Doncho the Batman","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the superior one","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the doctor","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Kenov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Hristov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Muslim","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the multi-threaded","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Kostov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Cuklev","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Minkov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan woth CS:GO and voda","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Russian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the barbarian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Destroyer","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Conqueror","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Doncho the Batman","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the superior one","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the doctor","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Kenov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Hristov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Muslim","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the multi-threaded","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Kostov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Cuklev","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Minkov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan woth CS:GO and voda","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Russian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the barbarian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Destroyer","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Conqueror","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Doncho the Batman","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the superior one","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the doctor","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Kenov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Hristov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Muslim","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the multi-threaded","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Kostov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Cuklev","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Minkov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan woth CS:GO and voda","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Russian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the barbarian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Destroyer","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Conqueror","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Doncho the Batman","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the superior one","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the doctor","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Kenov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Hristov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Muslim","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the multi-threaded","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Kostov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Cuklev","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Minkov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan woth CS:GO and voda","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Russian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the barbarian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Destroyer","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Conqueror","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Doncho the Batman","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the superior one","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the doctor","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Kenov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Hristov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Muslim","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the multi-threaded","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Kostov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Cuklev","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Minkov","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan woth CS:GO and voda","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the Russian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO}
					} }
			};


			this.ContentViewModel = playlistsContent;

			var playlistDataContext = new PlaylistsPageViewModel(playlistsContent);
			this.DataContext = playlistDataContext;

			BackButton.Visibility = Visibility.Collapsed;
		}

		public PlaylistsContentViewModel ContentViewModel { get; private set; }

		private void MenuItemsListView_ItemClick(object sender, ItemClickEventArgs e)
		{
			var currentPlaylist = (PlaylistViewModel)e.ClickedItem;

			this.ContentViewModel.CurrentPlaylist.Clear();
			currentPlaylist.Songs.ForEach(song => this.ContentViewModel.CurrentPlaylist.Add(song));

			BackButton.Visibility = Visibility.Visible;
		}

		private void SoundGridView_DragOver(object sender, DragEventArgs e)
		{
			e.AcceptedOperation = DataPackageOperation.Copy;

			e.DragUIOverride.Caption = "drop to add a custom sound and tile";
			e.DragUIOverride.IsCaptionVisible = true;
			e.DragUIOverride.IsContentVisible = true;
			e.DragUIOverride.IsGlyphVisible = true;
		}

		private async void SoundGridView_Drop(object sender, DragEventArgs e)
		{
			//if (e.DataView.Contains(StandardDataFormats.StorageItems))
			//{
			//	IReadOnlyList<IStorageItem> items = await e.DataView.GetStorageItemsAsync();

			//	if (items.Any())
			//	{
			//		var storageFile = items[0] as StorageFile;
			//		var contentType = storageFile.ContentType;

			//		StorageFolder folder = ApplicationData.Current.LocalFolder;

			//		if (contentType == "audio/wav" || contentType == "audio/mpeg")
			//		{
			//			StorageFile newFile = await storageFile.CopyAsync(folder, storageFile.Name, NameCollisionOption.GenerateUniqueName);

			//			MyMediaElement.SetSource(await storageFile.OpenAsync(FileAccessMode.Read), contentType);
			//			MyMediaElement.Play();
			//		}
			//	}
			//}
		}

		private void SearchAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
		{
			string query = sender.Text;

			if (string.IsNullOrEmpty(query))
			{
				return;
			}

			this.ContentViewModel.CurrentPlaylist.Clear();
			this.ContentViewModel.Playlists.ForEach(playlist =>
			{
				playlist.Songs.ForEach(song =>
				{
					if (song.Title.Contains(query))
					{
						this.ContentViewModel.CurrentPlaylist.Add(song);
					}
				});
			});
		}

		private void SearchAutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
		{

		}

		private void SoundGridView_ItemClick(object sender, ItemClickEventArgs e)
		{
			var currentSong = (SoundViewModel)e.ClickedItem;
			this.PlaySoundFile(currentSong, playerIsRunning, this.MyMediaElement);
			this.playerIsRunning = !this.playerIsRunning;
		}

		private void SoundGridView_Tapped(object sender, TappedRoutedEventArgs e)
		{
			// What on earth is this monstrosity? WHAT HAVE I DONE!?
			var currentSong = (SoundViewModel)((Image)e.OriginalSource).DataContext;
			this.PlaySoundFile(currentSong, playerIsRunning, this.MyMediaElement);
			this.playerIsRunning = !this.playerIsRunning;
		}

		private void PlaySoundFile(SoundViewModel currentSong, bool playerIsRunning, MediaElement MyMediaElement)
		{
			if (playerIsRunning == false)
			{
				this.MyMediaElement.Source = new Uri(this.BaseUri, currentSong.AudioSource);
				this.MyMediaElement.Play();
			}
			else
			{
				this.MyMediaElement.Pause();
			}

			currentSong.Title = "Test";

			playerIsRunning = !playerIsRunning;
		}

		private void SoundGridView_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
		{
			// Edit current file
			var currentSong = (SoundViewModel)((Image)e.OriginalSource).DataContext;
			this.appbarEditSong.IsOpen = true;
		}

		private void btnAddSong_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnRemoveSong_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
