using WPF_Blackjack.Enum;
using WPF_Blackjack.Util;
using WPF_Blackjack.ViewModel;

namespace WPF_Blackjack.Data
{
    public static class CardsToModels
    {
        public static Dictionary<Tuple<Suit, Value>, CardViewModel> Map = new Dictionary<Tuple<Suit, Value>, CardViewModel>()
        {
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
            { new(Suit.Hearts, Value.Ace), new(ResourceUtil.GetCardsPath("hearts_ace.png")) }
        };
    }
}
