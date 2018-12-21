using System;
using System.Windows.Input;

namespace Game_Platform.Helpers
{
    public class DelegateCommand : ICommand
    {
        #region Fields

        private readonly Action<object> execute;
        private readonly Predicate<object> canExecute;

        #endregion

        #region Constructors

        public DelegateCommand(Action<object> execute) : this(execute, null) { }

        public DelegateCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");

            this.execute = execute;
            this.canExecute = canExecute;
        }

        #endregion

        #region ICommand members

        public bool CanExecute(object parameter)
        {
            return canExecute?.Invoke(parameter) ?? true;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }

        #endregion
    }
}
