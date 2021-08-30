using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;

namespace Tama.Views
{
    public class ParamImage : UserControl
    {

        public static readonly StyledProperty<int> ValueProperty =
            AvaloniaProperty.Register<ParamImage, int>(nameof(Value));
        
        public int Value {
            get => GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        public ParamImage() {
            InitializeComponent();
            
        }

        private void InitializeComponent() {
            AvaloniaXamlLoader.Load(this);
        }
    }
}