﻿namespace MusicPlayer.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MyPlaylistPageViewModel: ViewModelBase, IPageViewModel
    {
        private readonly string PageTitle = "My Playlists";

        public MyPlaylistPageViewModel(IContentViewModel contentViewModel)
        {
            this.ContentViewModel = contentViewModel;
        }

        public string Title
        {
            get
            {
                return this.PageTitle;
            }
        }

        public IContentViewModel ContentViewModel { get; set; }
    }
}