namespace MusicPlayer.Commands
{
    using System;
    using System.Windows.Input;

    public class DelegateCommand<T> : ICommand
    {
        private Action<T> execute;
        private Func<bool> canExecute;

        public DelegateCommand(Action<T> execute, Func<bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (this.canExecute == null)
            {
                return true;
            }

            return this.canExecute();
        }

        public void Execute(object parameter)
        {
            this.execute((T)parameter);
        }
    }
}
