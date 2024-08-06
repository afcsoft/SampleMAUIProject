using System.Runtime.InteropServices;

namespace SampleInternalProject
{
  public partial class App : Application
  {
    [DllImport("__Internal",EntryPoint ="main")]
    public static extern int main();
    public App()
    {
      main();
      InitializeComponent();

      MainPage = new AppShell();
    }
  }
}
