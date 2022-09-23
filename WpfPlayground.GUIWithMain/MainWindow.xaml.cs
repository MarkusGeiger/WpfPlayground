using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfPlayground.GUIWithMain
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void Grid_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      Console.WriteLine("1 Grid clicked!");
      Debug.WriteLine("2 Grid clicked!");
      Trace.WriteLine("3 Grid clicked!");
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      Console.WriteLine("1 MainWindow loaded!");
      Debug.WriteLine("2 MainWindow loaded!");
      Trace.WriteLine("3 MainWindow loaded!");
    }
  }
}
