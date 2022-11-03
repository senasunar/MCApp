using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
 using Microsoft.UI.Windowing;
using System;
using System.IO;
using System.Xml.Linq;
using Microsoft.UI.Xaml.Navigation;
using static System.Net.WebRequestMethods;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MCApp
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        /*
        private IntPtr hWnd = IntPtr.Zero;
        private AppWindow appW = null;
        private OverlappedPresenter presenter = null;*/

        public MainWindow()
        {
            this.InitializeComponent();
            nav.SelectedItem = nav.MenuItems[0];
            ShellFrame.Content = new BlankPage1();

            /*IntPtr hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);//
            var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            var appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
            appWindow.Resize(new Windows.Graphics.SizeInt32 { Width = 450, Height = 650 });//
            presenter = appWindow.Presenter as OverlappedPresenter;
            presenter.IsResizable = false;*/

            /*hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            WindowId wndId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            appW = AppWindow.GetFromWindowId(wndId);
            presenter = appW.Presenter as OverlappedPresenter;
            presenter.IsResizable = false;*/
        }

        //C# code behind
        private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            
            
            switch (args.InvokedItemContainer.Tag)
            {
                case "Home":
                    ShellFrame.Navigate(typeof(BlankPage1));
                    break;
                case "Favorite":
                    ShellFrame.Navigate(typeof(BlankPage1));
                    break;
            }
        }

    }
}
