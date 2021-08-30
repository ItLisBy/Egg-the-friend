using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Tama.Views
{
    public class ThingParams : UserControl
    {
        public ThingParams() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            AvaloniaXamlLoader.Load(this);
        }
    }
}