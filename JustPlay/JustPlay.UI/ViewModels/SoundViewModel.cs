namespace JustPlay.UI.ViewModels
{
	public class SoundViewModel
	{
		// Example: Title -> "Disturbed - Voices"
		// Artist -> "Disturbed"
		// Name -> "Voices"

		public string Title { get; set; }
		public string Genre { get; set; }

		public string AudioSource { get; set; }
		public string ImageSource { get; set; }

		public string Artist { get; set; }
		public string Name { get; set; }

		public SoundViewModel(string title, string genre)
		{
			this.Title = title;
			this.Genre = genre;

			AudioSource = $"/Assets/Audio/{genre}/{title}.wav";
			ImageSource = $"/Assets/Images/{genre}/{title}.png";
		}

		public SoundViewModel(SoundViewModel newSong)
		{
			this.Title = newSong.Title;
			this.Genre = newSong.Genre;
			this.AudioSource = newSong.AudioSource;
			this.ImageSource = newSong.ImageSource;
			this.Artist = newSong.Artist;
			this.Name = newSong.Name;
		}
	}
}
