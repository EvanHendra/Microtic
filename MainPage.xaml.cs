
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Microtic
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
     
        public MainPage()
        {
            this.InitializeComponent();

            MyFrame.Navigate(typeof(Page1));
            TitleTextBlock.Text = "Mikrotic";
            Home.IsSelected = true;

        }
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySpliteView.IsPaneOpen = !MySpliteView.IsPaneOpen;
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
            }
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Home.IsSelected)
            {
                MyFrame.Navigate(typeof(Page1));
                TitleTextBlock.Text = "Microtic";

            }
            else if (About.IsSelected)
            {
                MyFrame.Navigate(typeof(About));
            }
           
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Home.IsSelected = true;
        }
    }
}
