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
		private readonly string BASE_PATH_TO_EXAMPLE_IMAGE = "/Assets/LockScreenLogo.scale-200.png";
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
						new SoundViewModel("Johan the balerina","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the balerina","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the balerina","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the balerina","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
					} },
					new PlaylistViewModel("Eminem", BASE_PATH_TO_EXAMPLE_IMAGE)
					{Songs=new List<SoundViewModel>
					{
						new SoundViewModel("Johan the barbarian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the barbarian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the barbarian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the barbarian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the barbarian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the barbarian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the barbarian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the barbarian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the barbarian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the barbarian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the barbarian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the barbarian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the barbarian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the barbarian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
						new SoundViewModel("Johan the barbarian","Hard rock") {AudioSource=BASE_PATH_TO_EXAMPLE_AUDIO},
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

		private void SoundGridView_ItemClick(object sender, ItemClickEventArgs e)
		{
			var currentSong = (SoundViewModel)e.ClickedItem;

			if (playerIsRunning == false)
			{
				this.MyMediaElement.Source = new Uri(this.BaseUri, currentSong.AudioSource);
				this.MyMediaElement.Play();
			}
			else
			{
				this.MyMediaElement.Pause();
			}

			currentSong.Title="Test";

			playerIsRunning = !playerIsRunning;
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
			if (e.DataView.Contains(StandardDataFormats.StorageItems))
			{
				var items = await e.DataView.GetStorageItemsAsync();

				if (items.Any())
				{
					var storageFile = items[0] as StorageFile;
					var contentType = storageFile.ContentType;

					StorageFolder folder = ApplicationData.Current.LocalFolder;

					if (contentType == "audio/wav" || contentType == "audio/mpeg")
					{
						StorageFile newFile = await storageFile.CopyAsync(folder, storageFile.Name, NameCollisionOption.GenerateUniqueName);

						MyMediaElement.SetSource(await storageFile.OpenAsync(FileAccessMode.Read), contentType);
						MyMediaElement.Play();
					}
				}
			}
		}

		private void SearchAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
		{

		}

		private void SearchAutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
		{

		}
	}
}
