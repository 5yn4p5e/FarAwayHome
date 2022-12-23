using HotelFarAwayHome.ViewModel;
using System.Windows.Controls;

namespace HotelFarAwayHome.View
{
    /// <summary>
    /// Логика взаимодействия для BookingWindow.xaml
    /// </summary>
    public partial class BookingWindow : UserControl
    {
        public BookingWindow(ApplicationViewModel appViewModel)
        {
            InitializeComponent();
            DataContext = appViewModel;
        }
    }
}
