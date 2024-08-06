using System.Runtime.InteropServices;

namespace SampleInternalProject
{
  public partial class App : Application
  {
    [DllImport("__Internal",EntryPoint ="SubMain")]
    public static extern int SubMain();
    public App()
    {
      SubMain();
      InitializeComponent();

      MainPage = new AppShell();
    }
  }
}
