using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace HelloWindowsStore
{
    public class App :Application
    {
        static void Main(string[] args)
        {
            Application.Start((p) => new App());
        }


        protected override void OnLaunched(Windows.ApplicationModel.Activation.LaunchActivatedEventArgs args)
        {
            TextBlock txtBlk = new TextBlock
            {

                Text = "Striped Down vresion of the Windows phone 8 application",
                FontFamily = new FontFamily("Times New Roman"),
                Foreground = new SolidColorBrush(Colors.Red)
            };

            Window.Current.Content = txtBlk;
            Window.Current.Activate();
            
        }

    }
}
