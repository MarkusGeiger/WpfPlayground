using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace WpfPlayground.GUIOnly
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
