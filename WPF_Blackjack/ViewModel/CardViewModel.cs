using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WPF_Blackjack.ViewModel
{
    public class CardViewModel : BaseViewModel
    {
        private BitmapImage _cardImage;
        public BitmapImage CardImage
        {
            get { return _cardImage; }
            set { _cardImage = value; NotifyPropertyChanged(); }
        }

        public CardViewModel(string filePath)
        {
            _cardImage = new BitmapImage();
            _cardImage.BeginInit();
            _cardImage.UriSource = new Uri(filePath);
            _cardImage.EndInit();
        }
    }
}
