namespace MusicPlayer.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SongViewModel:ViewModelBase
    {
        //public SongViewModel()
        //    : this(0, string.Empty, string.Empty)
        //{
        //}

        public SongViewModel(SongViewModel newSong)
            :this(newSong.Id,newSong.SongTitle,newSong.Url)
        {
        }

        public SongViewModel(int id, string title, string url)
        {
            this.Id = id;
            this.SongTitle = title;
            this.Url = url;
        }

        public int Id { get; set; }

        public string SongTitle { get; set; }

        public string Url { get; set; }
    }
}
