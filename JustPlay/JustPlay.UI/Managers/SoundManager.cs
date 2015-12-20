namespace JustPlay.UI.Managers
{
	using ViewModels;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Linq;

	public class SoundManager
	{
		public static void GetAllSounds(ObservableCollection<SoundViewModel> sounds)
		{
			var allSounds = getSounds();
			sounds.Clear();
			allSounds.ForEach(p => sounds.Add(p));
		}

		public static void GetSoundsByCategory(ObservableCollection<SoundViewModel> sounds, string soundCategory)
		{
			var allSounds = getSounds();
			var filteredSounds = allSounds.Where(p => p.Genre == soundCategory).ToList();
			sounds.Clear();
			filteredSounds.ForEach(p => sounds.Add(p));
		}

		public static void GetSoundsByName(ObservableCollection<SoundViewModel> sounds, string name)
		{
			var allSounds = getSounds();
			var filteredSounds = allSounds.Where(p => p.Title == name).ToList();
			sounds.Clear();
			filteredSounds.ForEach(p => sounds.Add(p));
		}

		private static List<SoundViewModel> getSounds()
		{
			var sounds = new List<SoundViewModel>();
			string SoundCategory ="Metal";

			sounds.Add(new SoundViewModel("Cow", SoundCategory));
			sounds.Add(new SoundViewModel("Cat", SoundCategory));

			sounds.Add(new SoundViewModel("Gun", SoundCategory));
			sounds.Add(new SoundViewModel("Spring", SoundCategory));

			sounds.Add(new SoundViewModel("Clock", SoundCategory));
			sounds.Add(new SoundViewModel("LOL", SoundCategory));

			sounds.Add(new SoundViewModel("Ship", SoundCategory));
			sounds.Add(new SoundViewModel("Siren", SoundCategory));

			return sounds;
		}
	}
}
