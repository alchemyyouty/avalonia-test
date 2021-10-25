using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace test
{
    public partial class MainWindow : Window
    {
        private bool IsHello = false;
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void ButtonClick(object sender, RoutedEventArgs e)
        {
            // Change button text when button is clicked.
            string HelloStr = "Hello, Avalonia!";
            string GoodNightStr = "Good night, Avalonia!";
            var button = (Button)sender;
            if(IsHello)
            {
                button.Content = GoodNightStr;
                IsHello = false;
            }
            else
            {
                button.Content = HelloStr;
                IsHello = true;
            }
        }
    }
}
