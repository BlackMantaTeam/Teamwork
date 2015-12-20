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
