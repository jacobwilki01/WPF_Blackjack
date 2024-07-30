using WPF_Blackjack.Enum;
using WPF_Blackjack.Util;
using WPF_Blackjack.ViewModel;

namespace WPF_Blackjack.Data
{
    public static class CardsToModels
    {
        public readonly static CardViewModel flippedCard = new(ResourceUtil.GetCardsPath("card_flipped.png"));

        public readonly static Dictionary<Tuple<Suit, Value>, CardViewModel> Map = new Dictionary<Tuple<Suit, Value>, CardViewModel>()
        {
            // Hearts
            { new(Suit.Hearts, Value.King), new(ResourceUtil.GetCardsPath("hearts_king.png")) },
            { new(Suit.Hearts, Value.Queen), new(ResourceUtil.GetCardsPath("hearts_queen.png")) },
            { new(Suit.Hearts, Value.Jack), new(ResourceUtil.GetCardsPath("hearts_jack.png")) },
            { new(Suit.Hearts, Value.Ten), new(ResourceUtil.GetCardsPath("hearts_ten.png")) },
            { new(Suit.Hearts, Value.Nine), new(ResourceUtil.GetCardsPath("hearts_nine.png")) },
            { new(Suit.Hearts, Value.Eight), new(ResourceUtil.GetCardsPath("hearts_eight.png")) },
            { new(Suit.Hearts, Value.Seven), new(ResourceUtil.GetCardsPath("hearts_seven.png")) },
            { new(Suit.Hearts, Value.Six), new(ResourceUtil.GetCardsPath("hearts_six.png")) },
            { new(Suit.Hearts, Value.Five), new(ResourceUtil.GetCardsPath("hearts_five.png")) },
            { new(Suit.Hearts, Value.Four), new(ResourceUtil.GetCardsPath("hearts_four.png")) },
            { new(Suit.Hearts, Value.Three), new(ResourceUtil.GetCardsPath("hearts_three.png")) },
            { new(Suit.Hearts, Value.Two), new(ResourceUtil.GetCardsPath("hearts_two.png")) },
            { new(Suit.Hearts, Value.Ace), new(ResourceUtil.GetCardsPath("hearts_ace.png")) },

            // Diamonds
            { new(Suit.Diamonds, Value.King), new(ResourceUtil.GetCardsPath("diamond_king.png")) },
            { new(Suit.Diamonds, Value.Queen), new(ResourceUtil.GetCardsPath("diamond_queen.png")) },
            { new(Suit.Diamonds, Value.Jack), new(ResourceUtil.GetCardsPath("diamond_jack.png")) },
            { new(Suit.Diamonds, Value.Ten), new(ResourceUtil.GetCardsPath("diamond_ten.png")) },
            { new(Suit.Diamonds, Value.Nine), new(ResourceUtil.GetCardsPath("diamond_nine.png")) },
            { new(Suit.Diamonds, Value.Eight), new(ResourceUtil.GetCardsPath("diamond_eight.png")) },
            { new(Suit.Diamonds, Value.Seven), new(ResourceUtil.GetCardsPath("diamond_seven.png")) },
            { new(Suit.Diamonds, Value.Six), new(ResourceUtil.GetCardsPath("diamond_six.png")) },
            { new(Suit.Diamonds, Value.Five), new(ResourceUtil.GetCardsPath("diamond_five.png")) },
            { new(Suit.Diamonds, Value.Four), new(ResourceUtil.GetCardsPath("diamond_four.png")) },
            { new(Suit.Diamonds, Value.Three), new(ResourceUtil.GetCardsPath("diamond_three.png")) },
            { new(Suit.Diamonds, Value.Two), new(ResourceUtil.GetCardsPath("diamond_two.png")) },
            { new(Suit.Diamonds, Value.Ace), new(ResourceUtil.GetCardsPath("diamond_ace.png")) },

            // Spades
            { new(Suit.Spades, Value.King), new(ResourceUtil.GetCardsPath("spade_king.png")) },
            { new(Suit.Spades, Value.Queen), new(ResourceUtil.GetCardsPath("spade_queen.png")) },
            { new(Suit.Spades, Value.Jack), new(ResourceUtil.GetCardsPath("spade_jack.png")) },
            { new(Suit.Spades, Value.Ten), new(ResourceUtil.GetCardsPath("spade_ten.png")) },
            { new(Suit.Spades, Value.Nine), new(ResourceUtil.GetCardsPath("spade_nine.png")) },
            { new(Suit.Spades, Value.Eight), new(ResourceUtil.GetCardsPath("spade_eight.png")) },
            { new(Suit.Spades, Value.Seven), new(ResourceUtil.GetCardsPath("spade_seven.png")) },
            { new(Suit.Spades, Value.Six), new(ResourceUtil.GetCardsPath("spade_six.png")) },
            { new(Suit.Spades, Value.Five), new(ResourceUtil.GetCardsPath("spade_five.png")) },
            { new(Suit.Spades, Value.Four), new(ResourceUtil.GetCardsPath("spade_four.png")) },
            { new(Suit.Spades, Value.Three), new(ResourceUtil.GetCardsPath("spade_three.png")) },
            { new(Suit.Spades, Value.Two), new(ResourceUtil.GetCardsPath("spade_two.png")) },
            { new(Suit.Spades, Value.Ace), new(ResourceUtil.GetCardsPath("spade_ace.png")) },

            // Clubs
            { new(Suit.Clubs, Value.King), new(ResourceUtil.GetCardsPath("club_king.png")) },
            { new(Suit.Clubs, Value.Queen), new(ResourceUtil.GetCardsPath("club_queen.png")) },
            { new(Suit.Clubs, Value.Jack), new(ResourceUtil.GetCardsPath("club_jack.png")) },
            { new(Suit.Clubs, Value.Ten), new(ResourceUtil.GetCardsPath("club_ten.png")) },
            { new(Suit.Clubs, Value.Nine), new(ResourceUtil.GetCardsPath("club_nine.png")) },
            { new(Suit.Clubs, Value.Eight), new(ResourceUtil.GetCardsPath("club_eight.png")) },
            { new(Suit.Clubs, Value.Seven), new(ResourceUtil.GetCardsPath("club_seven.png")) },
            { new(Suit.Clubs, Value.Six), new(ResourceUtil.GetCardsPath("club_six.png")) },
            { new(Suit.Clubs, Value.Five), new(ResourceUtil.GetCardsPath("club_five.png")) },
            { new(Suit.Clubs, Value.Four), new(ResourceUtil.GetCardsPath("club_four.png")) },
            { new(Suit.Clubs, Value.Three), new(ResourceUtil.GetCardsPath("club_three.png")) },
            { new(Suit.Clubs, Value.Two), new(ResourceUtil.GetCardsPath("club_two.png")) },
            { new(Suit.Clubs, Value.Ace), new(ResourceUtil.GetCardsPath("club_ace.png")) },
        };
    }
}
