﻿namespace MusicPlayer.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MainPageViewModel: ViewModelBase, IPageViewModel
    {
        private readonly string PageTitle = "Music Player";

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
