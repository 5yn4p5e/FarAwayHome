using HotelFarAwayHome.ViewModel;
using System.Windows.Controls;

namespace HotelFarAwayHome.View
{
    /// <summary>
    /// Логика взаимодействия для CheckInWindow.xaml
    /// </summary>
    public partial class CheckInWindow : UserControl
    {
        public CheckInWindow(ApplicationViewModel appViewModel)
        {
            InitializeComponent();
            DataContext = appViewModel;
        }
    }
}
