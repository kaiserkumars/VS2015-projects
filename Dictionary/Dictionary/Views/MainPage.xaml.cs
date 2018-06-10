using System;
using Dictionary.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
using SQLite.Net;


namespace Dictionary.Views
{
    public sealed partial class MainPage : Page
    {
        private SQLiteConnection con; 
        
        public MainPage()
        {
            
            InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            
            
        }
    }
}
