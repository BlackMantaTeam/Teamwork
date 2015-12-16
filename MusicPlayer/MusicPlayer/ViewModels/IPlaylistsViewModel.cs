namespace MusicPlayer.ViewModels
{
    using System.Collections.Generic;

    public interface IPlaylistsViewModel
    {
        IEnumerable<SongViewModel> Songs { get; set; }
    }
}
