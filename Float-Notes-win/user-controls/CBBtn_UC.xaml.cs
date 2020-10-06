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
    /// Interaction logic for CBBtn_UC.xaml
    /// </summary>
    public partial class CBBtn_UC : UserControl
    {
        public CBBtn_UC()
        {
            InitializeComponent();
        }
        public String ImgSrc { get; set; }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
