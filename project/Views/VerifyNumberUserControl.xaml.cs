using project.ViewModels;
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

namespace project.Views
{
    /// <summary>
    /// Interaction logic for VerifyNumberUserControl.xaml
    /// </summary>
    public partial class VerifyNumberUserControl : UserControl
    {
        public VerifyNumberUserControl(string verifyCode)
        {
            InitializeComponent();
            DataContext = new VerifyNumberViewModel(this, verifyCode);
        }
    }
}
