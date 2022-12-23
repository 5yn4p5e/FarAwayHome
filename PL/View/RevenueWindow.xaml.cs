using HotelFarAwayHome.ViewModel;
using System.Windows.Controls;

namespace HotelFarAwayHome.View
{
    /// <summary>
    /// Логика взаимодействия для RevenueWindow.xaml
    /// </summary>
    public partial class RevenueWindow : UserControl
    {
        public RevenueWindow(ApplicationViewModel appViewModel)
        {
            InitializeComponent();
            DataContext = appViewModel;
        }
    }
}
