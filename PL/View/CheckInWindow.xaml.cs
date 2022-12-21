﻿using System;
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
using System.Windows.Shapes;
using HotelFarAwayHome.ViewModel;

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
