using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Blackjack.Data;
using WPF_Blackjack.Enum;

namespace WPF_Blackjack.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        public PlayerHandViewModel testHandModel { get; } = new();

        public RelayCommand AddCardCommand { get; }

        static Random rnd = new Random();

        public MainWindowViewModel() 
        {
            AddCardCommand = new(addCard);
        }

        private void addCard()
        {
            int r = rnd.Next(CardsToModels.Map.Count);
            testHandModel.addCard(CardsToModels.Map.Values.ToList()[r]);
        }
    }
}
