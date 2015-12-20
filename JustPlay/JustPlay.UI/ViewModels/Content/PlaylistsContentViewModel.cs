namespace JustPlay.UI.ViewModels.Content
{
    using Commands;
    using Contracts;
    using Extensions;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Windows.Input;

    public class PlaylistsContentViewModel : ViewModelBase, IContentViewModel
    {
        private ObservableCollection<SoundViewModel> songs { get; set; }
        private ICommand addCommand;
        private ICommand deleteCommand;

        public IEnumerable<SoundViewModel> Songs
        {
            get
            {
                if (this.songs == null)
                {
                    this.songs = new ObservableCollection<SoundViewModel>();
                }

                return this.songs;
            }
            set
            {
                if (this.songs == null)
                {
                    this.songs = new ObservableCollection<SoundViewModel>();
                }

                this.songs.Clear();
                value.ForEach(this.songs.Add);
            }
        }

        public ICommand Save
        {
            get
            {
                if (this.addCommand == null)
                {
                    this.addCommand = new DelegateCommand<SoundViewModel>((newSong) =>
                    {
                        this.songs.Add(new SoundViewModel(newSong));
                    });
                }

                return this.addCommand;
            }
        }

        public ICommand Delete
        {
            get
            {
                if (this.deleteCommand == null)
                {
                    this.deleteCommand = new DelegateCommand<SoundViewModel>((song) =>
                    {
                        song.Name = "Master Yoda";
                    });
                }
                return this.deleteCommand;
            }
        }
    }
}