using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Blackjack.Enum;

namespace WPF_Blackjack.Data
{
    public class Card
    {
        public Suit suit;

        public Value value;

        public Card(Suit suit, Value value)
        {
            this.suit = suit;
            this.value = value;
        }
    }
}
