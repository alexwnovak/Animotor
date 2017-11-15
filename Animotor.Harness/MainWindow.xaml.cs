using System.Windows;

namespace Animotor.Harness
{
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();
      }

      private async void MainWindow_OnLoaded( object sender, RoutedEventArgs e )
      {
         await Button.Animate( Property.Opacity );
      }
   }
}
