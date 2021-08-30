using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Tama.Views
{
    public class Environment : UserControl
    {
        public Environment() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            AvaloniaXamlLoader.Load(this);
        }
    }
}