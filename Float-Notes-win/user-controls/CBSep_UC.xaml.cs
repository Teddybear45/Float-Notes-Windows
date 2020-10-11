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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Float_Notes_win.user_controls
{
    /// <summary>
    /// Interaction logic for CBSep_UC.xaml
    /// </summary>
    public partial class CBSep_UC : UserControl
    {
        public String SepTxt
        {
            get { return (String)GetValue(SepTxtProperty); }
            set { SetValue(SepTxtProperty, value); }
        }
        public static readonly DependencyProperty SepTxtProperty = DependencyProperty.Register("SepTxt", typeof(String), typeof(CBSep_UC), new UIPropertyMetadata(null));

        public CBSep_UC()
        {
            InitializeComponent();
        }
    }
}
