using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WPF_Blackjack.ViewModel
{
    public class ButtonViewModel : BaseViewModel
    {
        private BitmapImage _enabledImage;
        public BitmapImage EnabledImage
        {
            get { return _enabledImage; }
            set { _enabledImage = value; NotifyPropertyChanged(); }
        }

        private BitmapImage? _disabledImage;
        public BitmapImage? DisabledImage
        {
            get { return _disabledImage; }
            set { _disabledImage = value; NotifyPropertyChanged(); }
        }

        private bool _imageEnabled = false;
        public bool ImageEnabled
        {
            get { return _imageEnabled; }
            set { _imageEnabled = value; NotifyPropertyChanged(); }
        }

        public ButtonViewModel(string enabledFilePath, string? disabledFilePath = null)
        {
            _enabledImage = new BitmapImage();
            _enabledImage.BeginInit();
            _enabledImage.UriSource = new Uri(enabledFilePath);
            _enabledImage.EndInit();

            if (disabledFilePath != null)
            {
                _disabledImage = new BitmapImage();
                _disabledImage.BeginInit();
                _disabledImage.UriSource = new Uri(enabledFilePath);
                _disabledImage.EndInit();
            }
        }
    }
}
