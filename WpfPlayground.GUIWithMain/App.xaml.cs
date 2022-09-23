using System;
using System.Diagnostics;
using System.Windows;

namespace WpfPlayground.GUIWithMain
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    protected override void OnStartup(StartupEventArgs e)
    {

      Console.WriteLine("1 Application Startup!");
      Debug.WriteLine("2 Application Startupd!");
      Trace.WriteLine("3 Application Startup!");

      base.OnStartup(e);
    }
  }
}
