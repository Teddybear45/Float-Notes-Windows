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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Float_Notes_win.user_controls
{
    /// <summary>
    /// Interaction logic for CBBtn_UC.xaml
    /// </summary>
    public partial class CBBtn_UC : UserControl
    {

        public GridLength BtnGridColLen
        {
            get { return (GridLength)GetValue(BtnGridColLenProperty); }
            set { SetValue(BtnGridColLenProperty, value); }

        }

        public static readonly DependencyProperty BtnGridColLenProperty = DependencyProperty.Register("BtnGridColLen", typeof(GridLength), typeof(CBBtn_UC), new UIPropertyMetadata(null));

        public ImageSource BtnImgSource
        {
            get { return (ImageSource)GetValue(BtnImgSourceProperty); }
            set { SetValue(BtnImgSourceProperty, value); }
        }
        public static readonly DependencyProperty BtnImgSourceProperty = DependencyProperty.Register("BtnImgSource", typeof(ImageSource), typeof(CBBtn_UC), new UIPropertyMetadata(null));

        public string BtnTxt
        {
            get { return (String)GetValue(BtnTxtProperty); }
            set { SetValue(BtnTxtProperty, value); }
        }

        public static readonly DependencyProperty BtnTxtProperty = DependencyProperty.Register("BtnTxt", typeof(String), typeof(CBBtn_UC), new UIPropertyMetadata(null));

        public event RoutedEventHandler Click;

        public CBBtn_UC()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            if (Click != null)
            {
                Click(this, e);
            }
        }
    }
}
