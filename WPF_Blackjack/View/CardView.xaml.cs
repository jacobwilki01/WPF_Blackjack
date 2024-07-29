using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Blackjack.View
{
    /// <summary>
    /// Interaction logic for CardView.xaml
    /// </summary>
    public partial class CardView : UserControl
    {
        public CardView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event for when the mouse begins hovering over a given image.
        /// </summary>
        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            AdjustImage((Image)sender, -7.5);
        }

        /// <summary>
        /// Event for when the mouse stops hovering over a given image.
        /// </summary>
        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            AdjustImage((Image)sender, 7.5);
        }

        /// <summary>
        /// Adjusts an image's Y coordinate by a certain amount.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="amount">The amount to adjust it by, in pixels.</param>
        private void AdjustImage(Image image, double amount)
        {
            TranslateTransform transformation = new TranslateTransform();
            DoubleAnimation verticalAnimation = new DoubleAnimation(0, amount, TimeSpan.FromMilliseconds(125));
            image.RenderTransform = transformation;
            transformation.BeginAnimation(TranslateTransform.YProperty, verticalAnimation);
        }
    }
}
