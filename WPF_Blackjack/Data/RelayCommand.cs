using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Blackjack.Data
{
    public class RelayCommand : ICommand
    {
        private readonly Func<bool>? _canExecute;

        private readonly Action _executeAction;

        public event EventHandler? CanExecuteChanged;

        public RelayCommand(Action executeAction) : this(null, executeAction) { }

        public RelayCommand(Func<bool>? canExecute, Action executeAction)
        {
            _canExecute = canExecute;
            _executeAction = executeAction;
        }

        public void UpdateCanExecute()
        {
            this.CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        bool ICommand.CanExecute(object? parameter)
        {
            if (_canExecute != null)
                return _canExecute();

            return true;
        }

        void ICommand.Execute(object? parameter)
        {
            _executeAction?.Invoke();
        }
    }
}
