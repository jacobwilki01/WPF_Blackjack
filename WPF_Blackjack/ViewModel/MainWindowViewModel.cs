using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Blackjack.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        public CardViewModel TestCard { get; set; }

        public ButtonViewModel TestButton { get; set; }

        public MainWindowViewModel() 
        {
            TestCard = new("C:\\Projects\\WPF_Blackjack\\WPF_Blackjack\\Assets\\Cards\\hearts_ace.png");
            TestButton = new("C:\\Projects\\WPF_Blackjack\\WPF_Blackjack\\Assets\\Buttons\\button_double_enabled.png",
                             "C:\\Projects\\WPF_Blackjack\\WPF_Blackjack\\Assets\\Buttons\\button_double_disabled.png");
        }
    }
}
