using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MCApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        private OverlappedPresenter presenter = null;

        public BlankPage1()
        {
            this.InitializeComponent();
            /*
            IntPtr hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);//
            var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            var appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
            appWindow.Resize(new Windows.Graphics.SizeInt32 { Width = 450, Height = 650 });//
            presenter = appWindow.Presenter as OverlappedPresenter;
            presenter.IsResizable = false;*/
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = new User()
            {
                Email = email.Text,
                Username = username.Text,
                Name = name.Text,
                Surname = surname.Text,
                Password = password.Password
            };

            SaveUser(user);
            DisplayDialog("User Saved");
        }

        public static void SaveUser(User user)
        {
            string text = user.Name + "\t" +
                          user.Surname + "\t" +
                          user.Email + "\t" +
                          user.Username + "\t" +
                          user.Password;

            using (var writer = new StreamWriter("C:\\Users\\senas\\Desktop\\MCApp\\MCApp\\Users.txt", true))
            {
                writer.WriteLine(text);
                writer.Close();
            }
        }

        private async void DisplayDialog(String text)
        {
            var cd = new ContentDialog
            {
                Content = text,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                CloseButtonText = "Ok"
            };

            cd.XamlRoot = this.Content.XamlRoot;
            var result = await cd.ShowAsync();
        }
    }
}
