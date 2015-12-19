namespace MusicPlayer.Contracts
{
	using System.Collections.Generic;
	using ViewModels;

	public interface IPlaylistsViewModel
    {
        IEnumerable<SongViewModel> Songs { get; set; }
    }
}
