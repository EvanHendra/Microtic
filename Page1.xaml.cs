using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Microtic
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page1 : Page
    {
        public Page1()
        {
            this.InitializeComponent();
        }

        private void ResistorButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Resistor));
        }

        private void TransistorButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Transistor));
        }

        private void KapasitorButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Kapasitor));
        }

        private void ICButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(IC));
        }

        private void LEDButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(LED));
        }

        private void PushButtonButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PushButton));
        }

        private void PCBButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PCB));
        }

        private void DiodaButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Dioda));
        }

        private void DownloaderButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Downloader));
        }
    }
}
