using DotNetBay.Core;
using DotNetBay.Data.Entity;
using DotNetBay.WPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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

namespace DotNetBay.WPF.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            var app = (App) App.Current;
            DataContext = new MainViewModel(app.MainRepository);
        }

        private void NewAuction_Click(object sender, RoutedEventArgs e)
        {
            var sellView = new SellView();
            sellView.ShowDialog();
        }

        private void NewBid_Click(object sender, RoutedEventArgs e)
        {
            var bidView = new BidView();
            bidView.Show();
        }
    }
}
