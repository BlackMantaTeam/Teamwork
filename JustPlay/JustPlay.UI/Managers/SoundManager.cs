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

		public static void GetSoundsByCategory(ObservableCollection<SoundViewModel> sounds, SoundCategory soundCategory)
		{
			var allSounds = getSounds();
			var filteredSounds = allSounds.Where(p => p.Category == soundCategory).ToList();
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

			sounds.Add(new SoundViewModel("Cow", SoundCategory.Animals));
			sounds.Add(new SoundViewModel("Cat", SoundCategory.Animals));

			sounds.Add(new SoundViewModel("Gun", SoundCategory.Cartoons));
			sounds.Add(new SoundViewModel("Spring", SoundCategory.Cartoons));

			sounds.Add(new SoundViewModel("Clock", SoundCategory.Taunts));
			sounds.Add(new SoundViewModel("LOL", SoundCategory.Taunts));

			sounds.Add(new SoundViewModel("Ship", SoundCategory.Warnings));
			sounds.Add(new SoundViewModel("Siren", SoundCategory.Warnings));

			return sounds;
		}
	}
}
