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

namespace Float_Notes_win.User_Controls
{
    /// <summary>
    /// Interaction logic for ControlBoardBtn.xaml
    /// </summary>
    public partial class ControlBoardBtn : UserControl
    {
        
        public ControlBoardBtn()
        {
            InitializeComponent();
            this.DataContext = this;

        }

        private void BtnImgSourceChange(object sender, RoutedEventArgs e)
        {
            BindingExpression binding = ControlBoardBtnImg.GetBindingExpression(Image.SourceProperty);
            binding.UpdateSource();
        }



    }
}
