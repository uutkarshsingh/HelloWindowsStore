using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HelloWindowsStore
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            TextBlock tblk = new TextBlock
            {
                Text = "Utkarsh Rathor",
                FontFamily = new FontFamily("Times New Roman"),
                FontStyle=  Windows.UI.Text.FontStyle.Italic ,
                Foreground = new SolidColorBrush(Colors.Yellow),
                HorizontalAlignment = HorizontalAlignment.Center ,
                VerticalAlignment = VerticalAlignment.Top,
                FontSize=50
            };

            utkarshContentGrid.Children.Add(tblk);  
         
            Uri uri = new Uri("http://www.charlespetzold.com/pw6/PetzoldJersey.jpg");
            BitmapImage bitmapIMage = new Windows.UI.Xaml.Media.Imaging.BitmapImage(uri);

            Image image = new Image();
            image.Source = bitmapIMage;
            image.VerticalAlignment = VerticalAlignment.Bottom;
            image.HorizontalAlignment = HorizontalAlignment.Left;

            Grid newGrid = this.Content as Grid;
          //  newGrid.Children.Add(image);

            newGrid.Children.Add(
                new Button(){
                    Content = "Utkarsh"
                }              
                );

            this.Content =
              new Button(){
                  Content = "Rathor"                  ,
                  HorizontalAlignment = HorizontalAlignment.Right,
                  VerticalAlignment = VerticalAlignment.Bottom
              };
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
