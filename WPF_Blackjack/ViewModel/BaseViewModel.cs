using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Blackjack.ViewModel
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Event called when any UI property element is changed.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Method to invoke the property change event with the correct arguments.
        /// </summary>
        /// <param name="name">The property calling the change.</param>
        protected void NotifyPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
