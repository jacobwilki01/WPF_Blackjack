using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Blackjack.ViewModel
{
    public abstract class HandViewModel : BaseViewModel
    {
        protected readonly ObservableCollection<CardViewModel> _cards = new();
        public ReadOnlyObservableCollection<CardViewModel> Cards { get { return new(_cards); } }

        public void addCard(CardViewModel card)
        {
            _cards.Add(card);
        }
    }
}
