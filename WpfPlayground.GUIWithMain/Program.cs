using System.Diagnostics;
using System;

namespace WpfPlayground.GUIWithMain
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("1 Main Application Startup!");
      Debug.WriteLine("2 Main Application Startup!");
      Trace.WriteLine("3 Main Application Startup!");


      var app = new App();
      app.Run();


      Console.WriteLine("1 Main Application Started!");
      Debug.WriteLine("2 Main Application Started!");
      Trace.WriteLine("3 Main Application Started!");
    }
  }
}
