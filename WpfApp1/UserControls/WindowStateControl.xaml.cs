using System.Windows;
using System.Windows.Controls;

namespace MainApp.UserControls
{
    /// <summary>
    /// WindowState.xaml 的交互逻辑
    /// </summary>
    public partial class WindowStateControl : UserControl
    {
        public WindowStateControl()
        {
            InitializeComponent();
            parentWindow = Window.GetWindow(this);
        }

        Window parentWindow ;
        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            parentWindow.Close();
        }

        private void MaxBtn_Click(object sender, RoutedEventArgs e)
        {
            if (parentWindow.WindowState == WindowState.Normal)
            {
                parentWindow.WindowState = WindowState.Maximized;
            }
            else
            {
                parentWindow.WindowState = WindowState.Normal;

            }
        }

        private void MinBtn_Click(object sender, RoutedEventArgs e)
        {
            parentWindow.WindowState = WindowState.Minimized;
        }
    }
}
